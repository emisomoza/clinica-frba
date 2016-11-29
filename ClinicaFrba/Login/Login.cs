using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba;
using ClinicaFrba.DB_Connection;

namespace ClinicaFrba
{
    public partial class Login : Form
    {
        private int usuario_id { get; set; }
        private string rol { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e) {
            if (this.validarCampos()) {
                MessageBox.Show("Hola chicos!");
            }
            txt_usuario.Clear();
            txt_contrasenia.Clear();
        }
 
        private void cl_Login_Load(object sender, EventArgs e)
        {
        }

        private bool validarCampos()
        {
            if (txt_usuario.Text.Length == 0 || txt_contrasenia.Text.Length == 0) {
                MessageBox.Show("Completar los campos Usuario y Contraseña");
                return false;
            }
            
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();
            Parametro usuario = new Parametro("usuario", txt_usuario.Text);
            Parametro contrasenia = new Parametro("contrasenia", txt_contrasenia.Text);
            parametros.Add(usuario);
            parametros.Add(contrasenia);

            DataTable tabla = sql.ejecutarSP("usp_login_user", parametros);
            if (tabla.Rows.Count > 0) {
                MessageBox.Show(tabla.Rows[0].ItemArray[0].ToString());
                return false;
            }

            return true;
        }

      
      
    }
}
