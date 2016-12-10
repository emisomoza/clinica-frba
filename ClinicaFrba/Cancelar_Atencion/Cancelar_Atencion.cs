using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class Cancelar_Atencion : Form
    {
        public Cancelar_Atencion()
        {
            InitializeComponent();
        }

        private void btnMedica_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion_Medica cam = new Cancelar_Atencion_Medica();
            cam.ShowDialog();
        }

        private void btnAfiliado_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion_Afiliado caa = new Cancelar_Atencion_Afiliado(0);
            caa.ShowDialog();
        }
    }
}
