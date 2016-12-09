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
using ClinicaFrba.Properties;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class Cancelar_Atencion_Afiliado : Form
    {
        private int id_afiliado { get; set; }
        private int id_usuario { get; set; }
        public Cancelar_Atencion_Afiliado(int id_usuario)
        {
            InitializeComponent();
            obtenerDocumentoUsuario(id_usuario);
        }

        private void obtenerDocumentoUsuario(int id_usuario)
        {
            this.id_usuario = id_usuario;
            if (id_usuario != 0)
            {
                SQL sql = new SQL();
                List<Parametro> parametros = new List<Parametro>();

                Parametro id_usuario_param = new Parametro("id_usuario", id_usuario);
                parametros.Add(id_usuario_param);

                DataTable tabla = sql.ejecutarSP("usp_obtener_datos_x_usuario", parametros);

                if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    txtDocumento.Text = tabla.Rows[0].ItemArray[1].ToString();
                    txtDocumento.Enabled = false;
                    lblProfesional.Text = tabla.Rows[0].ItemArray[4].ToString() + ", " + tabla.Rows[0].ItemArray[3].ToString();
                    lblProfesional.Visible = true;
                    id_afiliado = Convert.ToInt32(tabla.Rows[0].ItemArray[0].ToString());
                }
            }
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro id_afiliado_param = new Parametro("id_afiliado", id_afiliado);
            parametros.Add(id_afiliado_param);
            Parametro fecha_desde = new Parametro("fecha_desde", Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(2).Day.ToString() + "-" + Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(2).Month.ToString() + "-" + Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(2).Year.ToString());
            parametros.Add(fecha_desde);

            DataTable tabla = sql.ejecutarSP("usp_buscar_turnos_afiliado", parametros);
            if (tabla.Rows.Count == 0)
            {
                dgvTurnos.DataSource = null;
                MessageBox.Show("No existen turnos a cancelar.");
            }
            else if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                dgvTurnos.DataSource = tabla;
                this.dgvTurnos.AllowUserToAddRows = false;
            }

            if (id_usuario == 0)
            {
                getAfiliadosPorDocumento(txtDocumento.Text.ToString());
            }
        }

        private void getAfiliadosPorDocumento(String documento)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro documento_param = new Parametro("nro_documento", documento);
            parametros.Add(documento_param);

            DataTable tabla = sql.ejecutarSP("usp_obtener_afiliados_x_documento", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                id_afiliado = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                lblProfesional.Text = tabla.Rows[0].ItemArray[2].ToString() + ", " + tabla.Rows[0].ItemArray[1].ToString();
                lblProfesional.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo de cancelación.");
            }
            else if (String.IsNullOrWhiteSpace(txtTurno.Text))
            {
                MessageBox.Show("Debe seleccionar un turno.");
            }
            else
            {
                SQL sql = new SQL();
                List<Parametro> parametros = new List<Parametro>();

                Parametro id_afiliado_param = new Parametro("id_afiliado", id_afiliado);
                parametros.Add(id_afiliado_param);
                Parametro id_turno = new Parametro("id_turno", Convert.ToInt32(txtTurno.Text));
                parametros.Add(id_turno);
                Parametro fecha_actual = new Parametro("fecha_actual", Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(1).Day.ToString() + "-" + Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(1).Month.ToString() + "-" + Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(1).Year.ToString());
                parametros.Add(fecha_actual);
                Parametro motivo = new Parametro("motivo", txtMotivo.Text.ToString());
                parametros.Add(motivo);

                DataTable tabla = sql.ejecutarSP("usp_cancelar_turno_afiliado", parametros);
                if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[0].ToString());
                }
            }
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.txtTurno.Text = this.dgvTurnos.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
