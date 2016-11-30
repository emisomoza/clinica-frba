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

namespace ClinicaFrba.Logueo
{
    public partial class Login : Form
    {
        private int id_usuario { get; set; }
        private string rol { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_aceptar_Click(object sender, EventArgs e) {
            if (this.validarCampos()) {
                Seleccionar_Rol rol = new Seleccionar_Rol(id_usuario);
                this.Hide();
                rol.ShowDialog();
                this.Close();
            }
            texto_usuario.Clear();
            texto_contrasenia.Clear();
        }

        private bool validarCampos() {
            if (texto_usuario.Text.Length == 0 || texto_contrasenia.Text.Length == 0) {
                MessageBox.Show("Completar los campos Usuario y Contraseña");
                return false;
            }

            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();
            Parametro usuario = new Parametro("usuario", texto_usuario.Text);
            Parametro contrasenia = new Parametro("contrasenia", texto_contrasenia.Text);
            parametros.Add(usuario);
            parametros.Add(contrasenia);

            DataTable tabla = sql.ejecutarSP("usp_login_user", parametros);
            if (tabla.Rows.Count > 0) {
                String mensaje = tabla.Rows[0].ItemArray[0].ToString();
                if (mensaje == "0") {
                    id_usuario = int.Parse(tabla.Rows[0].ItemArray[1].ToString());
                    return true;
                } else {
                    MessageBox.Show(mensaje);
                    return false;
                }
            }
            return true;
        }
    }
}
