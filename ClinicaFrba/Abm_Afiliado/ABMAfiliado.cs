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
            Alta_Afiliado aa = new Alta_Afiliado();
            aa.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Afiliado ma = new Modificar_Afiliado();
            ma.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Modificar_Plan mp = new Modificar_Plan();
            mp.ShowDialog();
        }
    }
}
