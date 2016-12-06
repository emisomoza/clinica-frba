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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Alta_Afiliado : Form
    {
        public Alta_Afiliado()
        {
            InitializeComponent();
            inicializarCombos();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBusquedaGral_Enter(object sender, EventArgs e)
        {

        }

        private void groupBuscarEmp_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int parsedValue;
            int id_afiliado_raiz;
            int nro_afiliado;
            int id_usuario;

            if (
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtNroDocumento.Text) ||
                string.IsNullOrEmpty(this.cmbPlan.Text) ||
                string.IsNullOrEmpty(this.cmbSexo.Text)
                )
            {
                MessageBox.Show("Completa todos los datos");
            }
            else if (!int.TryParse(txtTelefono.Text, out parsedValue))
            {
                MessageBox.Show("El teléfono debe contener solo números.");
            }
            else if (!int.TryParse(txtNroDocumento.Text, out parsedValue))
            {
                MessageBox.Show("El documento debe contener solo números.");
            }
            else
            {
                SQL sql = new SQL();

                List<Parametro> parametros = new List<Parametro>();

                Parametro param_id_afiliado_raiz = new Parametro("id_afiliado_raiz", 0);
                parametros.Add(param_id_afiliado_raiz);
                Parametro nombre = new Parametro("nombre", txtNombre.Text);
                parametros.Add(nombre);
                Parametro apellido = new Parametro("apellido", txtApellido.Text);
                parametros.Add(apellido);
                Parametro tipo_documento = new Parametro("tipo_documento", cmbTipoDocumento.Text);
                parametros.Add(tipo_documento);
                Parametro nro_documento = new Parametro("nro_documento", txtNroDocumento.Text);
                parametros.Add(nro_documento);
                Parametro id_estado_civil = new Parametro("id_estado_civil", cmbEstadoCivil.SelectedValue);
                parametros.Add(id_estado_civil);
                Parametro direccion = new Parametro("direccion", txtDireccion.Text);
                parametros.Add(direccion);
                Parametro telefono = new Parametro("telefono", txtTelefono.Text);
                parametros.Add(telefono);
                Parametro email = new Parametro("email", txtEmail.Text);
                parametros.Add(email);
                Parametro fecha_nacimiento = new Parametro("fecha_nacimiento", dtpFechaNacimiento.Value.Day.ToString() + '-' + dtpFechaNacimiento.Value.Month.ToString() + '-' + dtpFechaNacimiento.Value.Year.ToString());
                parametros.Add(fecha_nacimiento);
                Parametro sexo = new Parametro("sexo", cmbSexo.Text);
                parametros.Add(sexo);
                Parametro id_plan = new Parametro("id_plan", cmbPlan.SelectedValue);
                parametros.Add(id_plan);
                Parametro cantidad_familiares = new Parametro("cantidad_familiares", cmbCantidadFamiliares.Text);
                parametros.Add(cantidad_familiares);
                Parametro hijo = new Parametro("hijo", 0);
                parametros.Add(hijo);
                Parametro conyuge = new Parametro("conyuge", 0);
                parametros.Add(conyuge);

                DataTable tabla = sql.ejecutarSP("usp_alta_afiliado", parametros);
                if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    id_afiliado_raiz = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                    id_usuario = Convert.ToInt32(tabla.Rows[0].ItemArray[1]);
                    nro_afiliado = Convert.ToInt32(tabla.Rows[0].ItemArray[2]);
                    if (Convert.ToInt32(cmbCantidadFamiliares.Text) > 0)
                    {
                        this.Close();
                        Alta_Familiares af = new Alta_Familiares(id_afiliado_raiz, id_usuario, nro_afiliado);
                        af.ShowDialog();
                    }
                    else
                    {
                        this.Close();
                        MessageBox.Show("Nro de afiliado: " + nro_afiliado + " - Id de usuario: " + id_usuario);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicializarCombos()
        {
            cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            inicializarTipoDocumento();
            cmbCantidadFamiliares.Items.AddRange(new object[] {
                0,1,2,3,4,5,6,7,8,9,10});
            this.cmbCantidadFamiliares.SelectedIndex = 0;
            inicializarPlanes();
            inicializarEstadosCiviles();
        }

        private void inicializarTipoDocumento()
        {
            cmbTipoDocumento.Items.AddRange(new object[] {
            "DNI", "LE", "CI", "DOC. EXTRANJERO"});
            cmbTipoDocumento.SelectedIndex = 0;
        }

        private void inicializarPlanes()
        {
            SQL sql = new SQL();

            DataTable tabla = sql.ejecutarSP("usp_get_planes");
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbPlan.DataSource = tabla;
                cmbPlan.DisplayMember = "NOMBRE";
                cmbPlan.ValueMember = "ID_PLAN";
            }
        }

        private void inicializarEstadosCiviles()
        {
            SQL sql = new SQL();

            DataTable tabla = sql.ejecutarSP("usp_get_estados_civiles");
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbEstadoCivil.DataSource = tabla;
                cmbEstadoCivil.DisplayMember = "DESCRIPCION";
                cmbEstadoCivil.ValueMember = "ID_ESTADO_CIVIL";
            }
        }

        private void limpiarCampos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtApellido.Text = String.Empty;
            this.txtDireccion.Text = String.Empty;
            this.txtEmail.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.cmbCantidadFamiliares.SelectedIndex = 0;
            this.cmbEstadoCivil.SelectedIndex = 0;
            this.cmbPlan.SelectedIndex = 0;
            this.cmbSexo.SelectedItem = null;
            this.cmbTipoDocumento.SelectedIndex = 0;
            this.txtNroDocumento.Text = String.Empty;
        }
    }
}
