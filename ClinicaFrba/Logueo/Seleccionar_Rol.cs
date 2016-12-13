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
        public int id_rol {get; set; }
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
            //if (tabla.Rows.Count == 1) {
            //    this.id_rol = int.Parse(tabla.Rows[0].ItemArray[0].ToString());
            //}
            
        }

        private void boton_aceptar_Click(object sender, EventArgs e) {
            try {
                this.id_rol = int.Parse(roles.SelectedValue.ToString());
                this.Hide();
                MenuPrincipal mp = new MenuPrincipal(id_usuario, id_rol);
                mp.ShowDialog();
                this.Close();
            } catch { 
                this.Close(); 
            }
        }
    }
}
