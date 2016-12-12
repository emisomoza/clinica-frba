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
using ClinicaFrba.Registro_Llegada;
using ClinicaFrba.Pedido_Turno;
using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Registro_Resultado;
using ClinicaFrba.Listados;
using ClinicaFrba.Properties;

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
                            this.pedirTurnoToolStripMenuItem.Visible = true;
                            break;
                        case 4: // Cancelar Turno
                            this.cancelarAtenciónToolStripMenuItem.Visible = true;
                            this.cancelarAtenciónPorAfiliadoToolStripMenuItem.Visible = true;
                            break;
                        case 5: // Cancelar dia
                            this.cancelarAtenciónToolStripMenuItem.Visible = true;
                            this.cancelarAtenciónPorToolStripMenuItem.Visible = true;
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
            Comprar_Bono compra_bono = new Comprar_Bono(id_usuario, id_rol);
            compra_bono.MdiParent = this;
            compra_bono.Show();
        }

        private void registrarLlegadaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Registrar_Llegada registro_llegada = new Registrar_Llegada();
            registro_llegada.MdiParent = this;
            registro_llegada.Show();
        }

        private void pedirTurnoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Pedir_Turno pedir_turno = new Pedir_Turno(id_usuario);
            pedir_turno.MdiParent = this;
            pedir_turno.Show();
        }

        private void afiliadosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ABMAfiliado abm_afiliados = new ABMAfiliado();
            abm_afiliados.MdiParent = this;
            abm_afiliados.Show();
        }

        private void registrarResultadoDeConsultaToolStripMenuItem_Click(object sender, System.EventArgs e) {
            int id_profesional = getIdProfesional(id_usuario);
            if (id_profesional == 0) {
                MessageBox.Show("Operación permitida únicamente para Profesionales.\nEste usuario no corresponde a un profesional.");
            } else {
                Registrar_Resultado registro_resultado = new Registrar_Resultado(id_profesional);
                registro_resultado.MdiParent = this;
                registro_resultado.Show();
            }
        }
        
        public int getIdProfesional(int id_usuario) {
            SQL sql = new SQL();
            String query = "SELECT p.ID_PROFESIONAL FROM [" + Settings.Default.SQL_Schema + "].USUARIO u " +
                            "INNER JOIN [" + Settings.Default.SQL_Schema + "].PROFESIONAL p on u.NOMBRE = p.NRO_DOCUMENTO " +
                            "WHERE u.NOMBRE NOT LIKE 'admin' AND u.ID_USUARIO = " + id_usuario + ";";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0) {
                return int.Parse(tabla.Rows[0].ItemArray[0].ToString());
            } else {
                return 0;
            }
        }

        //private void cancelarAtencionPorAdminToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Cancelar_Atencion.Cancelar_Atencion ca = new Cancelar_Atencion.Cancelar_Atencion();
        //    ca.MdiParent = this;
        //    ca.Show();
        //}

        private void cancelarAtenciónPorAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.Cancelar_Atencion_Afiliado ca = new Cancelar_Atencion.Cancelar_Atencion_Afiliado(id_usuario);
            ca.MdiParent = this;
            ca.Show();
        }

        private void cancelarAtenciónPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.Cancelar_Atencion_Medica ca = new Cancelar_Atencion.Cancelar_Atencion_Medica(id_usuario);
            ca.MdiParent = this;
            ca.Show();
        }

        private void verEstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.MdiParent = this;
            estadisticas.Show();
        }
    }
}
