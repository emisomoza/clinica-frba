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

namespace ClinicaFrba.Registro_Resultado
{
    public partial class Registrar_Resultado : Form
    {
        int id_profesional;
        SQL sql = new SQL();

        public Registrar_Resultado(int id_profesional)
        {
            InitializeComponent();
            this.id_profesional = id_profesional;
        }

        private void Registrar_Resultado_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM [" + Settings.Default.SQL_Schema + "].fn_traer_turnos_profesional (" +
                            id_profesional + ");";
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
            Registrar_Consulta reg_consulta = new Registrar_Consulta(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            reg_consulta.ShowDialog();
        }

    }
}
