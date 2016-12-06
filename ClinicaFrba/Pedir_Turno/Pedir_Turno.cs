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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Pedir_Turno : Form
    {
        private int id_afiliado { get; set; }
        public Pedir_Turno()
        {
            InitializeComponent();
        }

        private void btnAfiliado_Click(object sender, EventArgs e)
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

                DataTable tabla = sql.ejecutarSP("usp_obtener_afiliados_x_documento", parametros);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existe el afiliado con el documento ingresado");
                }
                else if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    id_afiliado = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                    inicializarEspecialidades();
                    inicializarProfesionales();
                }
            }
        }

        private void inicializarEspecialidades()
        {
            SQL sql = new SQL();

            DataTable tabla = sql.ejecutarSP("usp_obtener_especialidades");
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbEspecialidades.DataSource = tabla;
                cmbEspecialidades.DisplayMember = "DESCRIPCION";
                cmbEspecialidades.ValueMember = "ID_ESPECIALIDAD";
            }
        }

        private void inicializarProfesionales()
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro id_especialidad = new Parametro("id_especialidad", 0);
            parametros.Add(id_especialidad);

            DataTable tabla = sql.ejecutarSP("usp_obtener_profesionales", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbProfesional.DataSource = tabla;
                cmbProfesional.DisplayMember = "NOMBRE";
                cmbProfesional.ValueMember = "ID_ESPECIALIDAD_PROFESIONAL";
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrarProfesionales();
        }

        private void filtrarProfesionales()
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro id_especialidad = new Parametro("id_especialidad", Convert.ToInt32(cmbEspecialidades.SelectedValue));
            parametros.Add(id_especialidad);

            DataTable tabla = sql.ejecutarSP("usp_obtener_profesionales", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbProfesional.DataSource = tabla;
                cmbProfesional.DisplayMember = "NOMBRE";
                cmbProfesional.ValueMember = "ID_ESPECIALIDAD_PROFESIONAL";
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            buscarFechasDisponibles();
        }

        private void buscarFechasDisponibles()
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro id_especialidad_profesional = new Parametro("id_especialidad_profesional", Convert.ToInt32(cmbProfesional.SelectedValue));
            parametros.Add(id_especialidad_profesional);
            Parametro fecha_actual = new Parametro("fecha_actual", Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(1).Day.ToString() + '-' + Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(1).Month.ToString() + '-' + Settings.Default.Fecha_Sistema.ToLocalTime().AddDays(1).Year.ToString());
            parametros.Add(fecha_actual);

            DataTable tabla = sql.ejecutarSP("usp_fechas_turnos_disponibles", parametros);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay turnos disponibles para el profesional elegido.");
            }
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                
            }
        }
    }
}
