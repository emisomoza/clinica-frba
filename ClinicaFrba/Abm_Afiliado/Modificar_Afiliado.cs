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
    public partial class Modificar_Afiliado : Form
    {
        public int id_afiliado { get; set; }
        public Modificar_Afiliado()
        {
            InitializeComponent();
            inicializarEstadosCiviles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text)
                )
            {
                MessageBox.Show("Completa todos los datos");
            }
            else if (!int.TryParse(txtTelefono.Text, out parsedValue))
            {
                MessageBox.Show("El teléfono debe contener solo números.");
            }
            else
            {
                SQL sql = new SQL();

                List<Parametro> parametros = new List<Parametro>();

                Parametro param_id_afiliado = new Parametro("id_afiliado", this.id_afiliado);
                parametros.Add(param_id_afiliado);
                Parametro id_estado_civil = new Parametro("id_estado_civil", cmbEstadoCivil.SelectedValue);
                parametros.Add(id_estado_civil);
                Parametro direccion = new Parametro("direccion", txtDireccion.Text);
                parametros.Add(direccion);
                Parametro telefono = new Parametro("telefono", txtTelefono.Text);
                parametros.Add(telefono);
                Parametro email = new Parametro("email", txtEmail.Text);
                parametros.Add(email);

                DataTable tabla = sql.ejecutarSP("usp_modifica_afiliado", parametros);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.lblApellido.Visible = false;
            this.lblNombre.Visible = false;
            this.lblDocumento.Visible = false;
            this.txtDireccion.Text = String.Empty;
            this.txtEmail.Text = String.Empty;
            this.txtTelefono.Text = String.Empty;
            this.cmbEstadoCivil.SelectedIndex = 0;
            this.txtDocumento.Text = String.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro documento_param = new Parametro("nro_documento", Convert.ToInt32(txtDocumento.Text));
            parametros.Add(documento_param);

            DataTable tabla = sql.ejecutarSP("usp_obtener_afiliados_x_documento_modif", parametros);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se obtuvieron resultados con el documento ingresado");
            }
            else if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                id_afiliado = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                lblNombre.Visible = true;
                lblApellido.Visible = true;
                lblDocumento.Visible = true;
                lblNombre.Text = tabla.Rows[0].ItemArray[1].ToString();
                lblApellido.Text = tabla.Rows[0].ItemArray[2].ToString();
                txtDireccion.Text = tabla.Rows[0].ItemArray[3].ToString();
                txtTelefono.Text = tabla.Rows[0].ItemArray[4].ToString();
                txtEmail.Text = tabla.Rows[0].ItemArray[5].ToString();
                lblDocumento.Text = txtDocumento.Text;
                cmbEstadoCivil.SelectedValue = tabla.Rows[0].ItemArray[6].ToString();
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                btnBuscar.Visible = true;
            }
        }
    }
}
