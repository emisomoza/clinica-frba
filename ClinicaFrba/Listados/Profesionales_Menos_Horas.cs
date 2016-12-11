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
    public partial class Profesionales_Menos_Horas : Form
    {
        SQL sql = new SQL();
        int anio;
        public Profesionales_Menos_Horas(int anio)
        {
            InitializeComponent();
            this.anio = anio;
        }

        private void Profesionales_Menos_Horas_Load(object sender, EventArgs e)
        {
            rellenarComboSemestre();
            rellenarComboPlan();
            rellenarComboEspecialidad();
        }

        private void rellenarComboSemestre()
        {
            var dataSource = new List<ComboItem>();
            dataSource.Add(new ComboItem() { Name = "Primero", Value = "1" });
            dataSource.Add(new ComboItem() { Name = "Segundo", Value = "2" });
            this.combo_semestre.DataSource = dataSource;
            this.combo_semestre.DisplayMember = "Name";
            this.combo_semestre.ValueMember = "Value";
            this.combo_semestre.SelectedIndex = 0;

        }

        private void rellenarComboPlan()
        {
            String query = "SELECT ID_PLAN, NOMBRE FROM [" + Settings.Default.SQL_Schema + "].PLANES;";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0)
            {
                combo_plan.DataSource = tabla;
                combo_plan.DisplayMember = "NOMBRE";
                combo_plan.ValueMember = "ID_PLAN";
            }

        }

        private void rellenarComboEspecialidad()
        {
            String query = "SELECT ID_ESPECIALIDAD, DESCRIPCION FROM [" + Settings.Default.SQL_Schema + "].ESPECIALIDAD;";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0)
            {
                combo_especialidad.DataSource = tabla;
                combo_especialidad.DisplayMember = "DESCRIPCION";
                combo_especialidad.ValueMember = "ID_ESPECIALIDAD";
            }

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM [" + Settings.Default.SQL_Schema + "].fn_estad_prof_menos_horas (" +
                            this.anio + ", " +
                            int.Parse(combo_semestre.SelectedValue.ToString()) + ", " +
                            int.Parse(combo_plan.SelectedValue.ToString()) + ", " +
                            int.Parse(combo_especialidad.SelectedValue.ToString()) + ");";
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
