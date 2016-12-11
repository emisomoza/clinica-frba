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

        public Registrar_Resultado(int id_usuario, int id_rol)
        {
            InitializeComponent();

            validarRol(id_rol);

            this.id_profesional = getIdProfesional(id_usuario);

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

        public void validarRol(int id_rol) {
            String query = "SELECT NOMBRE FROM [" + Settings.Default.SQL_Schema + "].ROL WHERE ID_ROL = " + id_rol + ";";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0) {
                if ("Profesional" != tabla.Rows[0].ItemArray[0].ToString()) {
                    MessageBox.Show("Operación permitida únicamente para Profesionales.");
                    this.Close();
                }
            }
        }

        public int getIdProfesional(int id_usuario) {
            String query = "SELECT p.ID_PROFESIONAL FROM [" + Settings.Default.SQL_Schema + "].USUARIO u " +
                            "INNER JOIN [" + Settings.Default.SQL_Schema + "].PROFESIONAL p on u.NOMBRE = p.NRO_DOCUMENTO " +
                            "WHERE u.NOMBRE NOT LIKE 'admin' AND u.ID_USUARIO = " + id_usuario + ";";
            DataTable tabla = sql.ejecutarConsulta(query);
            if (tabla.Rows.Count > 0) {
                return int.Parse(tabla.Rows[0].ItemArray[0].ToString());
            } else {
                MessageBox.Show("Este usuario no corresponde a un profesional.");
                this.Close();
                return 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Registrar_Consulta reg_consulta = new Registrar_Consulta(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            reg_consulta.ShowDialog();
        }

    }
}
