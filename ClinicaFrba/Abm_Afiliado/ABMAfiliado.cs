using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class ABMAfiliado : Form
    {
        public ABMAfiliado()
        {
            InitializeComponent();
        }

        private void boton_alta_afiliado(object sender, EventArgs e)
        {
            Alta_Afiliado rol = new Alta_Afiliado();
            this.Hide();
            rol.ShowDialog();
            this.Close();
        }
    }
}
