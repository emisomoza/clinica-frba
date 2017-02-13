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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Baja_Afiliado : Form
    {
        public Baja_Afiliado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtIdBaja.Text = "";
            btnBaja.Visible = false;
            int parsedValue;
            if (int.TryParse(txtDocumento.Text, out parsedValue))
            {
                this.dgvAfiliados.AllowUserToAddRows = false;
                this.dgvAfiliados.MultiSelect = false;
                this.dgvAfiliados.CancelEdit();
                this.dgvAfiliados.DataSource = getAfiliadosPorDocumento(txtDocumento.Text.ToString());
                this.dgvAfiliados.ClearSelection();
            }
            else
            {
                MessageBox.Show("El nro de documento ingresado no es válido.");
            }
        }

        public static DataTable getAfiliadosPorDocumento(String documento)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro documento_param = new Parametro("nro_documento", documento);
            parametros.Add(documento_param);

            DataTable tabla = sql.ejecutarSP("usp_obtener_afiliados_x_documento", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                return null;
            }
            else if (tabla.Rows.Count == 0) {
                MessageBox.Show("No se encontró ningún afiliado activo con ese nro de documento.");
                return null;
            }
            else {
                return tabla;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro id_afiliado = new Parametro("id_afiliado", Convert.ToInt32(txtIdBaja.Text));
            parametros.Add(id_afiliado);

            DataTable tabla = sql.ejecutarSP("usp_baja_afiliado", parametros);
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[0].ToString());
            }
            limpiar();
        }

        private void limpiar() {
            txtIdBaja.Text = "";
            btnBaja.Visible = false;
            this.dgvAfiliados.Rows.RemoveAt(this.dgvAfiliados.CurrentRow.Index);
        }

        private void txtIdBaja_TextChanged(object sender, EventArgs e)
        {
            btnBaja.Visible = true;
        }

        private void dgvAfiliados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_afiliado;
            if (e.RowIndex >= 0)
            {
                id_afiliado = Convert.ToInt32(this.dgvAfiliados.Rows[e.RowIndex].Cells[0].Value);
                txtIdBaja.Text = id_afiliado.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione el afiliado a dar de baja.");
            }
        }
    }
}
