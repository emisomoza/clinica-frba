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
    public partial class Alta_Familiares : Form
    {
        public int id_usuario { get; set; }
        public int id_afiliado { get; set; }

        public Alta_Familiares(int id_afiliado, int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.id_afiliado = id_afiliado;
            lblAfiliado.Text = "Id Afiliado: " + id_afiliado.ToString();
            lblUsuario.Text = "Id Usuario: " + id_usuario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alta_Conyuge ac = new Alta_Conyuge(id_afiliado, id_usuario);
            ac.ShowDialog();
            btnConyuge.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnHijos.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
