using ClinicaFrba.DB_Connection;
using ClinicaFrba.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class Registrar_Llegada : Form
    {
           
        SQL sql = new SQL();

        public Registrar_Llegada()
        {
            InitializeComponent();

            String query = "SELECT 0 as id_especialidad, 'Seleccionar especialidad' as descripcion " +
                "UNION SELECT ID_ESPECIALIDAD, DESCRIPCION FROM [" + Settings.Default.SQL_Schema + "].[ESPECIALIDAD];";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0) {
                especialidades.DataSource = tabla;
                especialidades.DisplayMember = "DESCRIPCION";
                especialidades.ValueMember = "ID_ESPECIALIDAD";
            }
        }

        private void especialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String query = "SELECT p.ID_PROFESIONAL, CONCAT(p.APELLIDO, ', ', p.NOMBRE) as nomyap " +
                            "FROM [" + Settings.Default.SQL_Schema + "].[PROFESIONAL] p " +
                            "INNER JOIN [" + Settings.Default.SQL_Schema + "].ESPECIALIDAD_PROFESIONAL ep on p.ID_PROFESIONAL = ep.ID_PROFESIONAL " +
                            "WHERE ep.ID_ESPECIALIDAD = " + int.Parse(especialidades.SelectedValue.ToString()) + 
                            "ORDER BY 2;";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0)
            {
                profesionales.DataSource = tabla;
                profesionales.DisplayMember = "nomyap";
                profesionales.ValueMember = "ID_PROFESIONAL";
            }
        }

        private void profesionales_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String query = "SELECT * FROM [" + Settings.Default.SQL_Schema + "].fn_traer_turnos (" +
                            int.Parse(especialidades.SelectedValue.ToString()) + ", " +
                            int.Parse(profesionales.SelectedValue.ToString()) + ");";
            DataTable tabla = sql.ejecutarConsulta(query);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Confirmar_Llegada cnf_llegada = new Confirmar_Llegada(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            cnf_llegada.ShowDialog();
            this.Close();
        }
    }
}
