using ClinicaFrba.DB_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class Registrar_Consulta : Form
    {
        int nro_turno;

        public Registrar_Consulta(int nro_turno)
        {
            InitializeComponent();
            this.nro_turno = nro_turno;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.txt_sintomas.Text.Length == 0 || this.txt_diagnostico.Text.Length == 0) {
                MessageBox.Show("Debe completar los campos Síntomas y Diagnóstico.");
            } else {
                SQL sql = new SQL();
                List<Parametro> parametros = new List<Parametro>();
                Parametro fecha = new Parametro("fecha", dateTimePicker1.Value.ToShortDateString());
                parametros.Add(fecha);
                String hora;
                if (this.numericUpDown1.Value < 10) { hora = "0" + numericUpDown1.Value.ToString(); }
                else { hora = numericUpDown1.Value.ToString(); }
                String minutos;
                if (this.numericUpDown1.Value < 10) { minutos = "0" + numericUpDown2.Value.ToString(); }
                else { minutos = numericUpDown2.Value.ToString(); }
                Parametro horario = new Parametro("hora", hora + ":" + minutos);
                parametros.Add(horario);
                Parametro turno = new Parametro("nro_turno", nro_turno);
                parametros.Add(turno);
                Parametro sintomas = new Parametro("sintomas", txt_sintomas.Text);
                parametros.Add(sintomas);
                Parametro diagnostico = new Parametro("diagnostico", txt_diagnostico.Text);
                parametros.Add(diagnostico);

                DataTable tabla = sql.ejecutarSP("usp_resultado_atencion", parametros);
                if (tabla.Rows.Count > 0) {
                    MessageBox.Show("Hubo un error al intentar registrar la consulta.");
                } else {
                    MessageBox.Show("Registro de consulta exitoso.");
                    this.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(this.dateTimePicker1.Value.Date > DateTime.Today) {
                MessageBox.Show("La fecha es incorrecta");
            }
        }
    }
}
