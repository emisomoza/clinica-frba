using ClinicaFrba.DB_Connection;
using ClinicaFrba.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Logueo
{
    public partial class Seleccionar_Rol : Form
    {
        public String nombre_rol {get; set; }
        public int id_usuario { get; set; }

        public Seleccionar_Rol(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;

            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();
            Parametro usuario = new Parametro("user_id", id_usuario);
            parametros.Add(usuario);

            DataTable tabla = sql.ejecutarSP("usp_roles_x_usuario", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR") {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else {
                roles.DataSource = tabla;
                roles.DisplayMember = "NOMBRE";
                roles.ValueMember = "ID_ROL";
            }
            if (tabla.Rows.Count == 1) {
                this.nombre_rol = tabla.Rows[0].ItemArray[1].ToString();
            }

            
        }

        private void boton_aceptar_Click(object sender, EventArgs e) {
            this.nombre_rol = roles.Text;
            cl_Menu menu = new cl_Menu(id_usuario, nombre_rol);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
