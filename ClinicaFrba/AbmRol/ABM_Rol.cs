using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DB_Connection;
using System.Diagnostics;

namespace ClinicaFrba.AbmRol
{
    public partial class ABM_Rol : Form
    {
        private int rol_id { get; set; }
        public ABM_Rol()
        {
            InitializeComponent();
            this.comboEstado.Items.AddRange(new object[] {
            "Dehabilitado",
            "Habilitado"});
            this.comboEstado.SelectedIndex = 1;
            this.chkFuncionalidades.DataSource = getFuncionalidades();
            this.chkFuncionalidades.DisplayMember = "Nombre";
        }

        public static DataTable getFuncionalidades()
        {
            SQL sql = new SQL();

            DataTable tabla = sql.ejecutarSP("usp_obtener_funcionalidades");
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                return null;
            }
            return tabla;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCampos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtNombreRol.Text = String.Empty;
            this.comboEstado.SelectedIndex = 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dgvRoles.DataSource = getRoles();
            this.chkFuncionalidades.DisplayMember = "Nombre";
            this.dgvRoles.AllowUserToAddRows = false;
            if (this.dgvRoles.RowCount > 0)
            {
                this.rol_id = Convert.ToInt32(this.dgvRoles.SelectedRows[0].Cells[0].Value);
                this.txtNombreRol.Text = this.dgvRoles.SelectedRows[0].Cells[1].Value.ToString();
                this.comboEstado.SelectedIndex = Convert.ToInt32(this.dgvRoles.SelectedRows[0].Cells[2].Value);
                this.f_completar_funcionalidades();
            }
        }

        private Boolean validarForm()
        {
            return (this.txtNombreRol.Text.Length > 0);
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.rol_id = Convert.ToInt32(this.dgvRoles.Rows[e.RowIndex].Cells[0].Value);
                this.txtNombreRol.Text = dgvRoles.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.comboEstado.SelectedIndex = Convert.ToInt32(dgvRoles.Rows[e.RowIndex].Cells[2].Value);
                this.f_completar_funcionalidades();
            }
        }

        private void f_completar_funcionalidades()
        {
            if (this.rol_id > 0)
            {
                getFuncRol(this.rol_id, this.chkFuncionalidades);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.validarForm() == false)
            {
                MessageBox.Show("Completar Nombre");
                return;
            }
            int estado = Convert.ToInt32(this.comboEstado.SelectedIndex.ToString());
            crearRol(this.txtNombreRol.Text, estado, chkFuncionalidades);

            //Se actualiza el listado de roles
            this.dgvRoles.DataSource = getRoles();
        }

        public static DataTable getRoles()
        {
            SQL sql = new SQL();

            DataTable tabla = sql.ejecutarSP("usp_obtener_roles");
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                return null;
            }
            return tabla;
        }

        public static void getFuncRol(int idRol, CheckedListBox funcionalidades)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro rol_id = new Parametro("rol_id", idRol.ToString());
            parametros.Add(rol_id);

            DataTable tabla = sql.ejecutarSP("usp_funcionalidades_x_rol", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                return;
            }

            Int32 cantidadFuncionalidades = funcionalidades.Items.Count;

            for (int i = 0; i < cantidadFuncionalidades; i++)
            {
                //Deshabilito todas las funcionalidades
                funcionalidades.SetItemChecked(i, false);
            }

            Int32 cantidadFuncionalidadesRol = tabla.Rows.Count;
            String elem;
            for (int i = 0; i < cantidadFuncionalidadesRol; i++)
            {
                elem = tabla.Rows[i].ItemArray[1].ToString();
                int index = funcionalidades.FindString(elem);
                funcionalidades.SetItemChecked(index, true);
            }
        }

        public static void crearRol(string nombreRol, int estado, CheckedListBox funcionalidades)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro nombre_rol = new Parametro("nombre_rol", nombreRol);
            Parametro habilitado = new Parametro("habilitado", estado.ToString());

            parametros.Add(nombre_rol);
            parametros.Add(habilitado);
            DataTable tabla = sql.ejecutarSP("sp_crear_rol", parametros);

            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else if (tabla.Rows.Count > 0)
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[0].ToString());
            }
            else
            {
                bool hab;
                bool error = false;
                Int32 cantidad = funcionalidades.Items.Count;
                for (int i = 0; i < cantidad; i++)
                {
                    DataRowView fila = (DataRowView)funcionalidades.Items[i];
                    hab = funcionalidades.GetItemChecked(i);
                    error = modificarFunc(nombreRol,
                                  fila.Row[0].ToString(),
                                  Convert.ToInt32(hab));
                    if (error == true)
                        break;
                }
                if (error == true)
                {
                    MessageBox.Show("Rol creado con inconsistencias");
                }
                else
                {
                    MessageBox.Show("Rol creado exitosamente");
                }
            }
        }

        public static bool modificarFunc(string nombreRol, string funcionalidad, Int32 hab)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro nombre_rol = new Parametro("nombre_rol", nombreRol);
            Parametro nombre_func = new Parametro("nombre_func", funcionalidad.ToString());
            Parametro habilitado = new Parametro("habilitado", hab.ToString());

            parametros.Add(nombre_rol);
            parametros.Add(nombre_func);
            parametros.Add(habilitado);

            DataTable tabla = sql.ejecutarSP("fn_actualizar_rol", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                return true;
            }
            return false;
        }
        public static void modificarRol(string nombreRol, Int32 estado, CheckedListBox funcionalidades)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro nombre_rol = new Parametro("nombre_rol", nombreRol);
            Parametro habilitado = new Parametro("habilitado", estado.ToString());

            parametros.Add(nombre_rol);
            parametros.Add(habilitado);

            DataTable tabla = sql.ejecutarSP("sp_update_rol", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                bool hab;
                bool error = false;
                Int32 cantidad = funcionalidades.Items.Count;
                for (int i = 0; i < cantidad; i++)
                {
                    DataRowView fila = (DataRowView)funcionalidades.Items[i];
                    hab = funcionalidades.GetItemChecked(i);
                    error = modificarFunc(nombreRol,
                                  fila.Row[0].ToString(),
                                  Convert.ToInt32(hab));
                    if (error == true)
                        break;
                }
                if (error == true)
                {
                    MessageBox.Show("Rol modificado con inconsistencias");
                }
                else
                {
                    MessageBox.Show("Rol modificado exitosamente");
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.validarForm() == false)
            {
                MessageBox.Show("Por favor complete Nombre");
                return;
            }
            int estado = Convert.ToInt32(this.comboEstado.SelectedIndex.ToString());
            modificarRol(this.txtNombreRol.Text, estado, chkFuncionalidades);
        }
    }
}
