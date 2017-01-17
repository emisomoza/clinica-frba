using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.DB_Connection;

namespace ClinicaFrba.Registrar_Agenda_Profesional
{
    public partial class Registrar_Agenda_Profesional : Form
    {
        private int id_profesional { get; set; }
        private int id_usuario { get; set; }
        public Registrar_Agenda_Profesional()
        {
            InitializeComponent();
        }

        private void btnBuscarProfesional_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Debe ingresar un número de documento.");
            }
            else
            {
                SQL sql = new SQL();
                List<Parametro> parametros = new List<Parametro>();

                Parametro documento_param = new Parametro("nro_documento", Convert.ToInt32(txtDocumento.Text));
                parametros.Add(documento_param);

                DataTable tabla = sql.ejecutarSP("usp_obtener_profesional_x_documento", parametros);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existe el profesional con el documento ingresado");
                }
                else if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    id_profesional = Convert.ToInt32(tabla.Rows[0].ItemArray[0]);
                    lblProfesional.Visible = true;
                    lblProfesional.Text = tabla.Rows[0].ItemArray[2].ToString() + ", " + tabla.Rows[0].ItemArray[1].ToString();
                    btnRegistrarAgenda.Visible = true;
                    inicializarCombos();
                    inicializarEspecialidades();
                }
            }
        }

        private void btnRegistrarAgenda_Click(object sender, EventArgs e)
        {

        }

        private void linkCleanAfiliado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDocumento.Text = null;
            btnRegistrarAgenda.Visible = false;
        }

        private void inicializarEspecialidades()
        {
            SQL sql = new SQL();

            List<Parametro> parametros = new List<Parametro>();

            Parametro id_profesional_param = new Parametro("id_profesional", id_profesional);
            parametros.Add(id_profesional_param);

            DataTable tabla = sql.ejecutarSP("usp_obtener_especialidades_profesional", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbEspecialidades.DataSource = tabla;
                cmbEspecialidades.DisplayMember = "DESCRIPCION";
                cmbEspecialidades.ValueMember = "ID_ESPECIALIDAD_PROFESIONAL";
                cmbEspecialidades.SelectedIndex = 0;
            }
        }

        private void inicializarCombos()
        {
            cmb1HD.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19});
            this.cmb1HD.SelectedIndex = 0;
            cmb2HD.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19});
            this.cmb2HD.SelectedIndex = 0;
            cmb3HD.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19});
            this.cmb3HD.SelectedIndex = 0;
            cmb4HD.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19});
            this.cmb4HD.SelectedIndex = 0;
            cmb5HD.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19});
            this.cmb5HD.SelectedIndex = 0;
            cmb6HD.Items.AddRange(new object[] {
                '-',10,11,12,13,14});
            this.cmb6HD.SelectedIndex = 0;

            cmb1HH.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19,20});
            this.cmb1HH.SelectedIndex = 0;
            cmb2HH.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19,20});
            this.cmb2HH.SelectedIndex = 0;
            cmb3HH.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19,20});
            this.cmb3HH.SelectedIndex = 0;
            cmb4HH.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19,20});
            this.cmb4HH.SelectedIndex = 0;
            cmb5HH.Items.AddRange(new object[] {
                '-',7,8,9,10,11,12,13,14,15,16,17,18,19,20});
            this.cmb5HH.SelectedIndex = 0;
            cmb6HH.Items.AddRange(new object[] {
                '-',10,11,12,13,14,15});
            this.cmb6HH.SelectedIndex = 0;

            cmb1MD.Items.AddRange(new object[] {
                "00","30"});
            this.cmb1MD.SelectedIndex = 0;
            cmb2MD.Items.AddRange(new object[] {
                "00","30"});
            this.cmb2MD.SelectedIndex = 0;
            cmb3MD.Items.AddRange(new object[] {
                "00","30"});
            this.cmb3MD.SelectedIndex = 0;
            cmb4MD.Items.AddRange(new object[] {
                "00","30"});
            this.cmb4MD.SelectedIndex = 0;
            cmb5MD.Items.AddRange(new object[] {
                "00","30"});
            this.cmb5MD.SelectedIndex = 0;
            cmb6MD.Items.AddRange(new object[] {
                "00","30"});
            this.cmb6MD.SelectedIndex = 0;

            cmb1MH.Items.AddRange(new object[] {
                "00","30"});
            this.cmb1MH.SelectedIndex = 0;
            cmb2MH.Items.AddRange(new object[] {
                "00","30"});
            this.cmb2MH.SelectedIndex = 0;
            cmb3MH.Items.AddRange(new object[] {
                "00","30"});
            this.cmb3MH.SelectedIndex = 0;
            cmb4MH.Items.AddRange(new object[] {
                "00","30"});
            this.cmb4MH.SelectedIndex = 0;
            cmb5MH.Items.AddRange(new object[] {
                "00","30"});
            this.cmb5MH.SelectedIndex = 0;
            cmb6MH.Items.AddRange(new object[] {
                "00","30"});
            this.cmb6MH.SelectedIndex = 0;
        }
    }
}
