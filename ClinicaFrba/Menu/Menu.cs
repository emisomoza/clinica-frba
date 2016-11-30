using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicaFrba.Menu
{
    public partial class cl_Menu : Form
    {
        private int usuario_id { get; set; }
        private string usuario_rol { get; set; }
        public cl_Menu(int usuario_id, String usuario_rol)
        {
            InitializeComponent();
            this.usuario_id = usuario_id;
            this.usuario_rol = usuario_rol;

            this.titulo_usuario.Text = "Usuario ID: " + usuario_id;
            this.titulo_rol.Text = "Rol: " + usuario_rol;
            /*
            ProcesarSubastas();
            ProcesarPublicaciones();*/
        }

        private void btn_abm_rol_Click(object sender, EventArgs e)
        {
           // cl_abm_rol rol = new cl_abm_rol();
            //rol.ShowDialog();
        }

        private void btn_abm_usuario_Click(object sender, EventArgs e)
        {
            // cl_abm_usuario usuario = new cl_abm_usuario();
            //usuario.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public void m_rol(string rol)
        {

            /*
            cl_SQL sql = new cl_SQL();
            cl_Parametros lista = new cl_Parametros();
            DataTable tabla;
            this.usuario_rol = rol;
            lista.m_add("nombre_rol", rol);
            tabla = sql.m_ejecutarSP("sp_get_asignaciones_fr", lista);
            foreach (Control subchild in this.Controls)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (subchild.Name == tabla.Rows[i][0].ToString())
                    {
                        subchild.Enabled = tabla.Rows[i][1].Equals(true);
                        subchild.Visible = tabla.Rows[i][1].Equals(true);
                    }
                }
            } */
        }

        private void cl_Menu_Load(object sender, EventArgs e)
        {

        }
        /*
        private void btn_abm_rubro_Click(object sender, EventArgs e)
        {
            cl_abm_rubro rubro = new cl_abm_rubro();
            rubro.ShowDialog();
        }

        private void btn_abm_visibilidad_Click(object sender, EventArgs e)
        {
            cl_abm_visibilidad visibilidad = new cl_abm_visibilidad();
            visibilidad.ShowDialog();
        }

        private void btn_generar_publicacion_Click(object sender, EventArgs e)
        {
            cl_generar_publicacion publicacion = new cl_generar_publicacion(this.usuario_id);
            publicacion.ShowDialog();
        }

        private void btn_comprar_ofertar_Click(object sender, EventArgs e)
        {
            cl_comprar_ofertar comprar_ofertar = new cl_comprar_ofertar(this.usuario_id);
            comprar_ofertar.ShowDialog();
        }

        private void btn_calificar_Click(object sender, EventArgs e)
        {
            cl_menu_calificar calificar = new cl_menu_calificar( usuario_id );
            calificar.ShowDialog();
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
           cl_historial_cliente historial = new cl_historial_cliente(this.usuario_id);
            historial.ShowDialog();
        }

        private void btn_consulta_facturas_Click(object sender, EventArgs e)
        {
            cl_facturas facturas = new cl_facturas(this.usuario_id, this.usuario_rol);
            facturas.ShowDialog();
        }

        private void btn_listado_estadistico_Click(object sender, EventArgs e)
        {
            cl_listado_estadistico topfive = new cl_listado_estadistico();
            topfive.ShowDialog();
        }

        private void ProcesarSubastas()
        {
            cl_Parametros lista1 = new cl_Parametros();
            cl_SQL sql = new cl_SQL();

            lista1.m_add("fecha", Settings.Default.Fecha_Sistema.ToString("yyyy-MM-dd HH:mm:ss"));

            DataTable tabla = sql.m_ejecutarSP("sp_cerrar_subastas", lista1);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());    
            }
        }

        private void ProcesarPublicaciones()
        {
            cl_Parametros lista1 = new cl_Parametros();
            cl_SQL sql = new cl_SQL();

            lista1.m_add("fecha", Settings.Default.Fecha_Sistema.ToString("yyyy-MM-dd HH:mm:ss"));

            DataTable tabla = sql.m_ejecutarSP("sp_cerrar_publicaciones", lista1);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
        }

        private void btn_ver_preguntas_Click(object sender, EventArgs e)
        {
            cl_Listado_preguntas preguntas = new cl_Listado_preguntas(this.usuario_id);
            preguntas.ShowDialog();
        }
        */
    }
}
