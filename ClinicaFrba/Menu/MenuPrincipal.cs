using ClinicaFrba.AbmRol;
using ClinicaFrba.DB_Connection;
using ClinicaFrba.Compra_Bono;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Menu
{
    public partial class MenuPrincipal : Form
    {
        public int id_usuario { get; set; }
        public int id_rol { get; set; }

        public MenuPrincipal(int id_usuario, int id_rol) {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.id_rol = id_rol;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();
            Parametro rol = new Parametro("rol_id", id_rol);
            parametros.Add(rol);

            DataTable tabla = sql.ejecutarSP("usp_funcionalidades_x_rol", parametros);
            if (tabla.Rows.Count > 0) {
                for (int i = 0; i < tabla.Rows.Count; i++) {
                    switch (int.Parse(tabla.Rows[i].ItemArray[0].ToString())) {
                        case 1: // ABM de Rol
                            this.aBMToolStripMenuItem.Visible = true;
                            this.rolToolStripMenuItem.Visible = true;
                            break;
                        case 2: // Sacar Turno
                            this.pedirTurnoToolStripMenuItem.Visible = true;
                            break;
                        case 3: // Sacar Turno (admin)
                            break;
                        case 4: // Cancelar Turno
                            this.cancelarAtenciónToolStripMenuItem.Visible = true;
                            break;
                        case 5: // Cancelar dia
                            break;
                        case 6: // Comprar Bono
                            this.compraBonoToolStripMenuItem.Visible = true;
                            break;
                        case 7: // ABM Afiliado
                            this.aBMToolStripMenuItem.Visible = true;
                            this.afiliadosToolStripMenuItem.Visible = true;
                            break;
                        case 8: // Registrar Atención
                            this.registrarLlegadaToolStripMenuItem.Visible = true;
                            break;
                        case 9: // Registrar Resultado de Atención
                            this.registrarResultadoDeConsultaToolStripMenuItem.Visible = true;
                            break;
                        case 10: // Consultar Estadísticas
                            this.verEstadísticasToolStripMenuItem.Visible = true;
                            break;
                        default:
                            break;
                    }
                }
            } else {
                MessageBox.Show("Rol inválido");
                this.Close();
            }
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Rol abm_rol = new ABM_Rol();
            abm_rol.MdiParent = this;
            abm_rol.Show();
        }

        private void compraBonoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Comprar_Bono compra_bono = new Comprar_Bono();
            compra_bono.MdiParent = this;
            compra_bono.Show();
        }
    }
}
