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

namespace ClinicaFrba.Compra_Bono
{
    public partial class Comprar_Bono : Form
    {
        public int id_usuario { get; set; }
        public int id_rol { get; set; }
        public int nro_usuario { get; set; }

        public Comprar_Bono(int id_usuario, int id_rol)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.id_rol = id_rol; 
            
            SQL sql = new SQL();
            String query = "SELECT NOMBRE FROM [" + Settings.Default.SQL_Schema + "].[ROL] WHERE ID_ROL = " + id_rol + ";";
            DataTable tabla = sql.ejecutarConsulta(query);
            String nombre_rol = tabla.Rows[0].ItemArray[0].ToString();
            if (!nombre_rol.Equals("Afiliado")) {
                this.txtNumeroAfiliado.Visible = true;
                this.lNumeroAfiliado.Visible = true;
                nro_usuario = 0;
            } else {
                query = "SELECT NRO_AFILIADO FROM [" + Settings.Default.SQL_Schema + "].[AFILIADO] WHERE ID_USUARIO = " + id_usuario + ";";
                tabla = sql.ejecutarConsulta(query);
                if (tabla.Rows.Count > 0) {
                    nro_usuario = int.Parse(tabla.Rows[0].ItemArray[0].ToString());
                }
            }
        }

        void txtNumeroAfiliado_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {
            if (!e.IsValidInput && !this.txtNumeroAfiliado.Equals("")) {
                MessageBox.Show("El número de Afiliado debe ser numérico");
                this.txtNumeroAfiliado.Clear();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();
            Parametro afiliado;
            if (nro_usuario == 0) {
                afiliado = new Parametro("nro_afiliado", this.txtNumeroAfiliado.Text);
            } else {
                afiliado = new Parametro("nro_afiliado", nro_usuario);
            }
            Parametro cantidad= new Parametro("cantidad", this.txtCantidad.Text);
            parametros.Add(afiliado);
            parametros.Add(cantidad);

            DataTable tabla = sql.ejecutarSP("usp_compra_bono", parametros);
            if (tabla.Rows.Count > 0) {
                String mensaje = tabla.Rows[0].ItemArray[0].ToString();
                MessageBox.Show(mensaje);
            }
            this.txtNumeroAfiliado.Clear();
            this.txtCantidad.Text = "1";
        }
    }
}
