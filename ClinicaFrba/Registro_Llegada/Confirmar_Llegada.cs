using ClinicaFrba.DB_Connection;
using ClinicaFrba.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class Confirmar_Llegada : Form
    {
        int nro_turno;

        public Confirmar_Llegada( int nro_turno )
        {
            InitializeComponent();
            this.nro_turno = nro_turno;
            this.lConfirmacion.Text = "¿Confirma que desea registrar la llegada para el turno " + nro_turno + "?";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();
            Parametro turno = new Parametro("nro_turno", nro_turno);
            parametros.Add(turno);
            Parametro fecha = new Parametro("dia_actual", Settings.Default.Fecha_Sistema.ToShortDateString());
            parametros.Add(fecha);

            DataTable tabla = sql.ejecutarSP("usp_registrar_llegada", parametros);
            if (tabla.Rows.Count > 0) {
                String mensaje = tabla.Rows[0].ItemArray[0].ToString();
                MessageBox.Show(mensaje);
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
