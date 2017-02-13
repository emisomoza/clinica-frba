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
    public partial class Modificar_Plan : Form
    {
        private int id_afiliado { get; set; }
        public Modificar_Plan()
        {
            InitializeComponent();
            inicializarPlanes();
        }

        private void inicializarPlanes()
        {
            SQL sql = new SQL();

            DataTable tabla = sql.ejecutarSP("usp_get_planes");
            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
            }
            else
            {
                cmbPlan.DataSource = tabla;
                cmbPlan.DisplayMember = "NOMBRE";
                cmbPlan.ValueMember = "ID_PLAN";
                this.cmbPlan.SelectedIndex = -1;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtDocumento.Text, out parsedValue))
            {
                this.dgvPlanesAfiliado.DataSource = getPlanesPorDocumento(int.Parse(txtDocumento.Text.ToString()));
                this.dgvPlanesAfiliado.AllowUserToAddRows = false;
                this.dgvPlanesAfiliado.MultiSelect = false;
                if (this.dgvPlanesAfiliado.RowCount > 0)
                {
                    btnCambiar.Visible = true;
                    this.id_afiliado = Convert.ToInt32(this.dgvPlanesAfiliado.Rows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("El nro de documento ingresado no es válido.");
            }
        }

        public static DataTable getPlanesPorDocumento(int documento)
        {
            SQL sql = new SQL();
            List<Parametro> parametros = new List<Parametro>();

            Parametro documento_param = new Parametro("nro_documento", documento);
            parametros.Add(documento_param);

            DataTable tabla = sql.ejecutarSP("usp_get_planes_afiliado_historico", parametros);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No existe un afiliado activo con el documento ingresado");
                return null;
            }
            else if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
            {
                MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                return null;
            }
            return tabla;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbPlan.Text))
            {
                MessageBox.Show("Debe seleccionar un plan");
            }
            else if (string.IsNullOrEmpty(this.txtMotivo.Text))
            {
                MessageBox.Show("Debe ingresar un motivo");
            }
            else
            {
                SQL sql = new SQL();
                List<Parametro> parametros = new List<Parametro>();

                Parametro id_afiliado_param = new Parametro("id_afiliado", id_afiliado);
                parametros.Add(id_afiliado_param);
                Parametro id_plan = new Parametro("id_plan", cmbPlan.SelectedValue);
                parametros.Add(id_plan);
                Parametro motivo = new Parametro("motivo", txtMotivo.Text.ToString());
                parametros.Add(motivo);

                DataTable tabla = sql.ejecutarSP("usp_actualiza_plan_afiliado", parametros);
                if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[1].ToString());
                }
                else
                {
                    MessageBox.Show(tabla.Rows[0].ItemArray[0].ToString());
                }
                txtMotivo.Text = "";
                inicializarPlanes();
                btnBuscar_Click(sender, e);
            }
        }
    }
}
