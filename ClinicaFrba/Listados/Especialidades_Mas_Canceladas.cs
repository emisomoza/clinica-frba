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

namespace ClinicaFrba.Listados
{
    public partial class Especialidades_Mas_Canceladas : Form
    {
        int anio;
        public Especialidades_Mas_Canceladas(int anio)
        {
            InitializeComponent();
            this.anio = anio;
        }

        private void Especialidades_Mas_Canceladas_Load(object sender, EventArgs e)
        {
            rellenarComboSemestre();
        }

        private void rellenarComboSemestre() {
            var dataSource = new List<ComboItem>();
            dataSource.Add(new ComboItem() { Name = "Primero", Value = "1" });
            dataSource.Add(new ComboItem() { Name = "Segundo", Value = "2" });
            this.combo_semestre.DataSource = dataSource;
            this.combo_semestre.DisplayMember = "Name";
            this.combo_semestre.ValueMember = "Value";
            this.combo_semestre.SelectedIndex = 0;
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            String query = "SELECT * FROM [" + Settings.Default.SQL_Schema + "].fn_estad_especialidades (" +
                            this.anio + ", " +
                            int.Parse(combo_semestre.SelectedValue.ToString()) + ");";
            DataTable tabla = sql.ejecutarConsulta(query);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = true;

        }
    }
}
