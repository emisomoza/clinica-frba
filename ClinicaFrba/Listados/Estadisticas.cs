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
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            rellenarComboAnio();
        }

        private void rellenarComboAnio() {
            var dataSource = new List<ComboItem>();
            for (int i = 2015; i <= 2018; i++)
            {
                dataSource.Add(new ComboItem() { Name = i.ToString(), Value = i.ToString() });
            }
            this.combo_anio.DataSource = dataSource;
            this.combo_anio.DisplayMember = "Name";
            this.combo_anio.ValueMember = "Value";
            this.combo_anio.SelectedIndex = 0;
        }

        private void estadistica1_Click(object sender, EventArgs e)
        {
            Especialidades_Mas_Canceladas especialidades = new Especialidades_Mas_Canceladas(int.Parse(combo_anio.SelectedValue.ToString()));
            especialidades.Show();
        }

        private void estadistica2_Click(object sender, EventArgs e)
        {
            Profesionales_Mas_Consultados prof_consultados = new Profesionales_Mas_Consultados(int.Parse(combo_anio.SelectedValue.ToString()));
            prof_consultados.Show();
        }

        private void estadistica3_Click(object sender, EventArgs e)
        {
            Profesionales_Menos_Horas prof_horas = new Profesionales_Menos_Horas(int.Parse(combo_anio.SelectedValue.ToString()));
            prof_horas.Show();
        }

        private void estadistica4_Click(object sender, EventArgs e)
        {
            Afiliados_Mas_Bonos afil_bonos = new Afiliados_Mas_Bonos(int.Parse(combo_anio.SelectedValue.ToString()));
            afil_bonos.Show();
        }

        private void estadistica5_Click(object sender, EventArgs e)
        {
            Especialidades_Mas_Bonos esp_bonos = new Especialidades_Mas_Bonos(int.Parse(combo_anio.SelectedValue.ToString()));
            esp_bonos.Show();
        }
    }
}
