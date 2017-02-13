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
    public partial class Cancelar_Atencion_Medica : Form
    {
        private int id_profesional { get; set; }
        private int id_usuario { get; set; }
        public Cancelar_Atencion_Medica(int id_usuario)
        {
            InitializeComponent();
            obtenerDocumentoUsuario(id_usuario);
        }

        private void obtenerDocumentoUsuario(int id_usuario)
        {
            this.id_usuario = id_usuario;

            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro id_usuario_param = new Parametro("id_usuario", id_usuario);
            parametros.Add(id_usuario_param);

            DataTable tabla = sql.ejecutarSP("usp_obtener_profesional_x_usuario", parametros);

            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else if (tabla.Rows.Count > 0)
            {
                txtDocumento.Text = tabla.Rows[0].ItemArray[1].ToString();
                txtDocumento.Enabled = false;
                lblProfesional.Text = tabla.Rows[0].ItemArray[3].ToString() + ", " + tabla.Rows[0].ItemArray[2].ToString();
                lblProfesional.Visible = true;
                id_profesional = Convert.ToInt32(tabla.Rows[0].ItemArray[0].ToString());
                inicializarParametros();
            }
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtDocumento.Text, out parsedValue))
            {
                if (String.IsNullOrWhiteSpace(txtDocumento.Text))
                {
                    MessageBox.Show("Debe ingresar un número de documento.");
                }
                else
                {
                    SQL sql = new SQL();
                    List<Parametro> parametros = new List<Parametro>();

                    Parametro documento_param = new Parametro("nro_documento", Convert.ToInt32(txtDocumento.Text));
                    parametros.Add(documento_param);

                    DataTable tabla = sql.ejecutarSP("usp_obtener_profesional_x_documento", parametros);
                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No existe el profesional con el documento ingresado");
                    }
                    else if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                    {
                        MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                    }
                    else
                    {
                        id_profesional = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                        lblProfesional.Visible = true;
                        lblProfesional.Text = tabla.Rows[0].ItemArray[2].ToString() + ", " + tabla.Rows[0].ItemArray[1].ToString();
                        inicializarParametros();
                    }
                }
            }
            else {
                MessageBox.Show("El nro de documento ingresado no es válido.");
                id_profesional = 0;
                lblProfesional.Text = "";
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo de cancelación.");
            }
            else if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a la fecha hasta.");
            }
            else
            {
                SQL sql = new SQL();
                List<Parametro> parametros = new List<Parametro>();

                Parametro id_profesional_param = new Parametro("id_profesional", id_profesional);
                parametros.Add(id_profesional_param);
                Parametro fecha_desde = new Parametro("fecha_desde", dtpDesde.Value);
                parametros.Add(fecha_desde);
                Parametro fecha_hasta = new Parametro("fecha_hasta", dtpHasta.Value);
                parametros.Add(fecha_hasta);
                Parametro fecha_actual = new Parametro("fecha_actual", DateTime.Parse(Settings.Default.Fecha_Sistema.ToString()).ToString("yyyy-MM-dd"));
                parametros.Add(fecha_actual);
                Parametro motivo = new Parametro("motivo", txtMotivo.Text.ToString());
                parametros.Add(motivo);

                DataTable tabla = sql.ejecutarSP("usp_cancelar_agenda_profesional", parametros);
                if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[0].ToString());
                    inicializarParametros();
                }
            }
        }

        private void inicializarParametros()
        {
            dtpDesde.Value = dtpDesde.MinDate;
            dtpHasta.Value = dtpHasta.MinDate;
            txtMotivo.Text = "";
        }

    }
}
