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

namespace ClinicaFrba.Registro_Agenda_Profesional
{
    public partial class Registrar_Agenda_Profesional : Form
    {
        SQL sql = new SQL();
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
            double cantHoras = 0;
            if (dtpDesde.Value.ToShortDateString().CompareTo(dtpHasta.Value.ToShortDateString()) > 0)
            {
                MessageBox.Show("La fecha desde debe ser menor o igual que la fecha hasta.");
            }
            else
            {
                if (cmb1HD.SelectedItem.Equals('-')
                    && cmb2HD.SelectedItem.Equals('-')
                    && cmb3HD.SelectedItem.Equals('-')
                    && cmb4HD.SelectedItem.Equals('-')
                    && cmb5HD.SelectedItem.Equals('-')
                    && cmb6HD.SelectedItem.Equals('-'))
                {
                    MessageBox.Show("Se debe elegir al menos una hora desde y hasta.");
                }
                else
                {
                    cantHoras = calcularHoras();
                    if (cantHoras > 48)
                    {
                        MessageBox.Show("La cantidad de horas semanales debe ser menor o igual a 48.");
                    }
                    else
                    {
                        List<Parametro> parametros = new List<Parametro>();

                        Parametro profesional_param = new Parametro("id_profesional", id_profesional);
                        parametros.Add(profesional_param);
                        Parametro espec_prof_param = new Parametro("id_especialidad_profesional", int.Parse(cmbEspecialidades.SelectedValue.ToString()));
                        parametros.Add(espec_prof_param);
                        Parametro fecha_desde_param = new Parametro("fecha_desde", dtpDesde.Value.Year.ToString() + '-' + dtpDesde.Value.Month.ToString() + '-' + dtpDesde.Value.Day.ToString());
                        parametros.Add(fecha_desde_param);
                        Parametro fecha_hasta_param = new Parametro("fecha_hasta", dtpHasta.Value.Year.ToString() + '-' + dtpHasta.Value.Month.ToString() + '-' + dtpHasta.Value.Day.ToString());
                        parametros.Add(fecha_hasta_param);

                        bool estado_error = false;

                        if (!cmb1HD.SelectedItem.Equals('-')) {
                            Parametro dia_param = new Parametro("dia_semana", 2);
                            parametros.Add(dia_param);
                            Parametro h_desde_param = new Parametro("hora_desde", int.Parse(cmb1HD.SelectedItem.ToString()));
                            parametros.Add(h_desde_param);
                            Parametro h_hasta_param = new Parametro("hora_hasta", int.Parse(cmb1HH.SelectedItem.ToString()));
                            parametros.Add(h_hasta_param);
                            Parametro m_desde_param = new Parametro("minuto_desde", int.Parse(cmb1MD.SelectedItem.ToString()));
                            parametros.Add(m_desde_param);
                            Parametro m_hasta_param = new Parametro("minuto_hasta", int.Parse(cmb1MH.SelectedItem.ToString()));
                            parametros.Add(m_hasta_param);

                            DataTable tabla = sql.ejecutarSP("usp_cargar_dia_agenda", parametros);
                            
                            parametros.Remove(dia_param);
                            parametros.Remove(h_desde_param);
                            parametros.Remove(h_hasta_param);
                            parametros.Remove(m_desde_param);
                            parametros.Remove(m_hasta_param);
                            
                            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                            {
                                estado_error = true;
                            }
                        }
                        if (!cmb2HD.SelectedItem.Equals('-'))
                        {
                            Parametro dia_param = new Parametro("dia_semana", 3);
                            parametros.Add(dia_param);
                            Parametro h_desde_param = new Parametro("hora_desde", int.Parse(cmb2HD.SelectedItem.ToString()));
                            parametros.Add(h_desde_param);
                            Parametro h_hasta_param = new Parametro("hora_hasta", int.Parse(cmb2HH.SelectedItem.ToString()));
                            parametros.Add(h_hasta_param);
                            Parametro m_desde_param = new Parametro("minuto_desde", int.Parse(cmb2MD.SelectedItem.ToString()));
                            parametros.Add(m_desde_param);
                            Parametro m_hasta_param = new Parametro("minuto_hasta", int.Parse(cmb2MH.SelectedItem.ToString()));
                            parametros.Add(m_hasta_param);

                            DataTable tabla = sql.ejecutarSP("usp_cargar_dia_agenda", parametros);

                            parametros.Remove(dia_param);
                            parametros.Remove(h_desde_param);
                            parametros.Remove(h_hasta_param);
                            parametros.Remove(m_desde_param);
                            parametros.Remove(m_hasta_param);

                            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                            {
                                estado_error = true;
                            }
                        }
                        if (!cmb3HD.SelectedItem.Equals('-'))
                        {
                            Parametro dia_param = new Parametro("dia_semana", 4);
                            parametros.Add(dia_param);
                            Parametro h_desde_param = new Parametro("hora_desde", int.Parse(cmb3HD.SelectedItem.ToString()));
                            parametros.Add(h_desde_param);
                            Parametro h_hasta_param = new Parametro("hora_hasta", int.Parse(cmb3HH.SelectedItem.ToString()));
                            parametros.Add(h_hasta_param);
                            Parametro m_desde_param = new Parametro("minuto_desde", int.Parse(cmb3MD.SelectedItem.ToString()));
                            parametros.Add(m_desde_param);
                            Parametro m_hasta_param = new Parametro("minuto_hasta", int.Parse(cmb3MH.SelectedItem.ToString()));
                            parametros.Add(m_hasta_param);

                            DataTable tabla = sql.ejecutarSP("usp_cargar_dia_agenda", parametros);

                            parametros.Remove(dia_param);
                            parametros.Remove(h_desde_param);
                            parametros.Remove(h_hasta_param);
                            parametros.Remove(m_desde_param);
                            parametros.Remove(m_hasta_param);

                            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                            {
                                estado_error = true;
                            }
                        }
                        if (!cmb4HD.SelectedItem.Equals('-'))
                        {
                            Parametro dia_param = new Parametro("dia_semana", 5);
                            parametros.Add(dia_param);
                            Parametro h_desde_param = new Parametro("hora_desde", int.Parse(cmb4HD.SelectedItem.ToString()));
                            parametros.Add(h_desde_param);
                            Parametro h_hasta_param = new Parametro("hora_hasta", int.Parse(cmb4HH.SelectedItem.ToString()));
                            parametros.Add(h_hasta_param);
                            Parametro m_desde_param = new Parametro("minuto_desde", int.Parse(cmb4MD.SelectedItem.ToString()));
                            parametros.Add(m_desde_param);
                            Parametro m_hasta_param = new Parametro("minuto_hasta", int.Parse(cmb4MH.SelectedItem.ToString()));
                            parametros.Add(m_hasta_param);

                            DataTable tabla = sql.ejecutarSP("usp_cargar_dia_agenda", parametros);

                            parametros.Remove(dia_param);
                            parametros.Remove(h_desde_param);
                            parametros.Remove(h_hasta_param);
                            parametros.Remove(m_desde_param);
                            parametros.Remove(m_hasta_param);

                            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                            {
                                estado_error = true;
                            }
                        }
                        if (!cmb5HD.SelectedItem.Equals('-'))
                        {
                            Parametro dia_param = new Parametro("dia_semana", 6);
                            parametros.Add(dia_param);
                            Parametro h_desde_param = new Parametro("hora_desde", int.Parse(cmb5HD.SelectedItem.ToString()));
                            parametros.Add(h_desde_param);
                            Parametro h_hasta_param = new Parametro("hora_hasta", int.Parse(cmb5HH.SelectedItem.ToString()));
                            parametros.Add(h_hasta_param);
                            Parametro m_desde_param = new Parametro("minuto_desde", int.Parse(cmb5MD.SelectedItem.ToString()));
                            parametros.Add(m_desde_param);
                            Parametro m_hasta_param = new Parametro("minuto_hasta", int.Parse(cmb5MH.SelectedItem.ToString()));
                            parametros.Add(m_hasta_param);

                            DataTable tabla = sql.ejecutarSP("usp_cargar_dia_agenda", parametros);

                            parametros.Remove(dia_param);
                            parametros.Remove(h_desde_param);
                            parametros.Remove(h_hasta_param);
                            parametros.Remove(m_desde_param);
                            parametros.Remove(m_hasta_param);

                            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                            {
                                estado_error = true;
                            }
                        }
                        if (!cmb6HD.SelectedItem.Equals('-'))
                        {
                            Parametro dia_param = new Parametro("dia_semana", 7);
                            parametros.Add(dia_param);
                            Parametro h_desde_param = new Parametro("hora_desde", int.Parse(cmb6HD.SelectedItem.ToString()));
                            parametros.Add(h_desde_param);
                            Parametro h_hasta_param = new Parametro("hora_hasta", int.Parse(cmb6HH.SelectedItem.ToString()));
                            parametros.Add(h_hasta_param);
                            Parametro m_desde_param = new Parametro("minuto_desde", int.Parse(cmb6MD.SelectedItem.ToString()));
                            parametros.Add(m_desde_param);
                            Parametro m_hasta_param = new Parametro("minuto_hasta", int.Parse(cmb6MH.SelectedItem.ToString()));
                            parametros.Add(m_hasta_param);

                            DataTable tabla = sql.ejecutarSP("usp_cargar_dia_agenda", parametros);

                            parametros.Remove(dia_param);
                            parametros.Remove(h_desde_param);
                            parametros.Remove(h_hasta_param);
                            parametros.Remove(m_desde_param);
                            parametros.Remove(m_hasta_param);

                            if (tabla.Rows.Count > 0 && tabla.Rows[0].ItemArray[0].ToString() == "ERROR")
                            {
                                estado_error = true;
                            }
                        }

                        if (estado_error)
                        {
                            MessageBox.Show("No se pueden cargar los valores ingresados porque se superponen con la agenda preexistente.");
                        }
                        else
                        {
                            MessageBox.Show("Agenda cargada exitosamente!");
                            cleanFormulario();
                        }
                    }
                }
            }
        }

        private double calcularHoras() {
            double acum = 0;
            int min_desde;
            int min_hasta;
            if (!cmb1HD.SelectedItem.Equals('-')) {
                min_hasta = int.Parse(cmb1MH.SelectedItem.ToString());
                min_desde = int.Parse(cmb1MD.SelectedItem.ToString());
                acum = acum + int.Parse(cmb1HH.SelectedItem.ToString()) - int.Parse(cmb1HD.SelectedItem.ToString());
                if (min_desde < min_hasta) {
                    acum = acum + 0.5;
                }
                else {
                    if (min_desde > min_hasta) {
                        acum = acum - 0.5;
                    }
                }
            }
            if (!cmb2HD.SelectedItem.Equals('-'))
            {
                min_hasta = int.Parse(cmb2MH.SelectedItem.ToString());
                min_desde = int.Parse(cmb2MD.SelectedItem.ToString());
                acum = acum + int.Parse(cmb2HH.SelectedItem.ToString()) - int.Parse(cmb2HD.SelectedItem.ToString());
                if (min_desde < min_hasta)
                {
                    acum = acum + 0.5;
                }
                else
                {
                    if (min_desde > min_hasta)
                    {
                        acum = acum - 0.5;
                    }
                }
            }
            if (!cmb3HD.SelectedItem.Equals('-'))
            {
                min_hasta = int.Parse(cmb3MH.SelectedItem.ToString());
                min_desde = int.Parse(cmb3MD.SelectedItem.ToString());
                acum = acum + int.Parse(cmb3HH.SelectedItem.ToString()) - int.Parse(cmb3HD.SelectedItem.ToString());
                if (min_desde < min_hasta)
                {
                    acum = acum + 0.5;
                }
                else
                {
                    if (min_desde > min_hasta)
                    {
                        acum = acum - 0.5;
                    }
                }
            }
            if (!cmb4HD.SelectedItem.Equals('-'))
            {
                min_hasta = int.Parse(cmb4MH.SelectedItem.ToString());
                min_desde = int.Parse(cmb4MD.SelectedItem.ToString());
                acum = acum + int.Parse(cmb4HH.SelectedItem.ToString()) - int.Parse(cmb4HD.SelectedItem.ToString());
                if (min_desde < min_hasta)
                {
                    acum = acum + 0.5;
                }
                else
                {
                    if (min_desde > min_hasta)
                    {
                        acum = acum - 0.5;
                    }
                }
            }
            if (!cmb5HD.SelectedItem.Equals('-'))
            {
                min_hasta = int.Parse(cmb5MH.SelectedItem.ToString());
                min_desde = int.Parse(cmb5MD.SelectedItem.ToString());
                acum = acum + int.Parse(cmb5HH.SelectedItem.ToString()) - int.Parse(cmb5HD.SelectedItem.ToString());
                if (min_desde < min_hasta)
                {
                    acum = acum + 0.5;
                }
                else
                {
                    if (min_desde > min_hasta)
                    {
                        acum = acum - 0.5;
                    }
                }
            }
            if (!cmb6HD.SelectedItem.Equals('-'))
            {
                min_hasta = int.Parse(cmb6MH.SelectedItem.ToString());
                min_desde = int.Parse(cmb6MD.SelectedItem.ToString());
                acum = acum + int.Parse(cmb6HH.SelectedItem.ToString()) - int.Parse(cmb6HD.SelectedItem.ToString());
                if (min_desde < min_hasta)
                {
                    acum = acum + 0.5;
                }
                else
                {
                    if (min_desde > min_hasta)
                    {
                        acum = acum - 0.5;
                    }
                }
            }
            return acum;
        }

        private void linkCleanFormulario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cleanFormulario();
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
            cmb1HD.Items.Clear();
            cmb2HD.Items.Clear();
            cmb3HD.Items.Clear();
            cmb4HD.Items.Clear();
            cmb5HD.Items.Clear();
            cmb6HD.Items.Clear();
            object[] combo_semanal = new object[] { '-', 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            cmb1HD.Items.AddRange(combo_semanal);
            this.cmb1HD.SelectedIndex = 0;
            cmb2HD.Items.AddRange(combo_semanal);
            this.cmb2HD.SelectedIndex = 0;
            cmb3HD.Items.AddRange(combo_semanal);
            this.cmb3HD.SelectedIndex = 0;
            cmb4HD.Items.AddRange(combo_semanal);
            this.cmb4HD.SelectedIndex = 0;
            cmb5HD.Items.AddRange(combo_semanal);
            this.cmb5HD.SelectedIndex = 0;
            cmb6HD.Items.AddRange(new object[] {'-',10,11,12,13,14});
            this.cmb6HD.SelectedIndex = 0;
            inicializarCombosDeMinutosDesde(cmb1HD.SelectedItem, cmb1MD);
            inicializarCombosDeMinutosDesde(cmb2HD.SelectedItem, cmb2MD);
            inicializarCombosDeMinutosDesde(cmb3HD.SelectedItem, cmb3MD);
            inicializarCombosDeMinutosDesde(cmb4HD.SelectedItem, cmb4MD);
            inicializarCombosDeMinutosDesde(cmb5HD.SelectedItem, cmb5MD);
            inicializarCombosDeMinutosDesde(cmb6HD.SelectedItem, cmb6MD);
            inicializarCombosDeHoraHasta(cmb1HD.SelectedItem, cmb1MD.SelectedItem, cmb1HH, 20);
            inicializarCombosDeHoraHasta(cmb2HD.SelectedItem, cmb2MD.SelectedItem, cmb2HH, 20);
            inicializarCombosDeHoraHasta(cmb3HD.SelectedItem, cmb3MD.SelectedItem, cmb3HH, 20);
            inicializarCombosDeHoraHasta(cmb4HD.SelectedItem, cmb4MD.SelectedItem, cmb4HH, 20);
            inicializarCombosDeHoraHasta(cmb5HD.SelectedItem, cmb5MD.SelectedItem, cmb5HH, 20);
            inicializarCombosDeHoraHasta(cmb6HD.SelectedItem, cmb6MD.SelectedItem, cmb6HH, 15);
            inicalizarCombosDeMinutosHasta(cmb1HD.SelectedItem, cmb1HH.SelectedItem, cmb1MH, "20");
            inicalizarCombosDeMinutosHasta(cmb2HD.SelectedItem, cmb2HH.SelectedItem, cmb2MH, "20");
            inicalizarCombosDeMinutosHasta(cmb3HD.SelectedItem, cmb3HH.SelectedItem, cmb3MH, "20");
            inicalizarCombosDeMinutosHasta(cmb4HD.SelectedItem, cmb4HH.SelectedItem, cmb4MH, "20");
            inicalizarCombosDeMinutosHasta(cmb5HD.SelectedItem, cmb5HH.SelectedItem, cmb5MH, "20");
            inicalizarCombosDeMinutosHasta(cmb6HD.SelectedItem, cmb6HH.SelectedItem, cmb6MH, "15");
        }

        private void inicializarCombosDeMinutosDesde(Object hora_desde, ComboBox cmb)
        {
            cmb.Items.Clear();
            if (hora_desde.ToString().Equals("-"))
            {
                cmb.Items.AddRange(new object[] { "-" });
            }
            else
            {
                cmb.Items.AddRange(new object[] { "00", "30" });
            }
            cmb.SelectedIndex = 0;
        }

        public void inicializarCombosDeHoraHasta(Object hora_desde, Object minutos_desde, ComboBox cmb_HH, int max)
        {
            cmb_HH.Items.Clear();
            if (hora_desde.ToString().Equals("-")){
                cmb_HH.Items.AddRange(new object[] { "-" });
            } else {
                int i = int.Parse(hora_desde.ToString());
                if (minutos_desde.ToString().Equals("30"))
                {   
                    i++;
                }
                for (; i <= max; i++) {
                    cmb_HH.Items.AddRange(new object[] { i });
                }
            }
            cmb_HH.SelectedIndex = 0;
        }

        private void inicalizarCombosDeMinutosHasta(Object hora_desde, Object hora_hasta, ComboBox cmb, String max)
        {
            cmb.Items.Clear();
            if (hora_desde.ToString().Equals("-"))
            {
                cmb.Items.AddRange(new object[] {"-"});
            } else {
                cmb.Items.AddRange(new object[] { "00" });
                if (hora_desde.ToString().Equals(hora_hasta.ToString()))
                {
                    cmb.Items.Clear();
                    cmb.Items.AddRange(new object[] { "30" });
                }
                else
                {
                    if (!hora_hasta.ToString().Equals(max))
                    {
                        cmb.Items.AddRange(new object[] { "30" });
                    }
                }
            }
            cmb.SelectedIndex = 0;
        }

        private void cmb1HD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeMinutosDesde(this.cmb1HD.SelectedItem, this.cmb1MD);
            inicializarCombosDeHoraHasta(this.cmb1HD.SelectedItem, this.cmb1MD.SelectedItem, this.cmb1HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb1HD.SelectedItem, this.cmb1HH.SelectedItem, this.cmb1MH, "20");
        }

        private void cmb1MD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeHoraHasta(this.cmb1HD.SelectedItem, this.cmb1MD.SelectedItem, this.cmb1HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb1HD.SelectedItem, this.cmb1HH.SelectedItem, this.cmb1MH, "20");
        }

        private void cmb1HH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicalizarCombosDeMinutosHasta(this.cmb1HD.SelectedItem, this.cmb1HH.SelectedItem, this.cmb1MH, "20");
        }

        private void cmb2HD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeMinutosDesde(this.cmb2HD.SelectedItem, this.cmb2MD);
            inicializarCombosDeHoraHasta(this.cmb2HD.SelectedItem, this.cmb2MD.SelectedItem, this.cmb2HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb2HD.SelectedItem, this.cmb2HH.SelectedItem, this.cmb2MH, "20");
        }

        private void cmb2MD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeHoraHasta(this.cmb2HD.SelectedItem, this.cmb2MD.SelectedItem, this.cmb2HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb2HD.SelectedItem, this.cmb2HH.SelectedItem, this.cmb2MH, "20");
        }

        private void cmb2HH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicalizarCombosDeMinutosHasta(this.cmb2HH.SelectedItem, this.cmb2HD, this.cmb2MH, "20");
        }

        private void cmb3HD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeMinutosDesde(this.cmb3HD.SelectedItem, this.cmb3MD);
            inicializarCombosDeHoraHasta(this.cmb3HD.SelectedItem, this.cmb3MD.SelectedItem, this.cmb3HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb3HD.SelectedItem, this.cmb3HH.SelectedItem, this.cmb3MH, "20");
        }

        private void cmb3MD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeHoraHasta(this.cmb3HD.SelectedItem, this.cmb3MD.SelectedItem, this.cmb3HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb3HD.SelectedItem, this.cmb3HH.SelectedItem, this.cmb3MH, "20");
        }

        private void cmb3HH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicalizarCombosDeMinutosHasta(this.cmb3HD.SelectedItem, this.cmb3HH.SelectedItem, this.cmb3MH, "20");
        }

        private void cmb4HD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeMinutosDesde(this.cmb4HD.SelectedItem, this.cmb4MD);
            inicializarCombosDeHoraHasta(this.cmb4HD.SelectedItem, this.cmb4MD.SelectedItem, this.cmb4HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb4HD.SelectedItem, this.cmb4HH.SelectedItem, this.cmb4MH, "20");
        }

        private void cmb4MD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeHoraHasta(this.cmb4HD.SelectedItem, this.cmb4MD.SelectedItem, this.cmb4HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb4HD.SelectedItem, this.cmb4HH.SelectedItem, this.cmb4MH, "20");
        }

        private void cmb4HH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicalizarCombosDeMinutosHasta(this.cmb4HD.SelectedItem, this.cmb4HH.SelectedItem, this.cmb4MH, "20");
        }

        private void cmb5HD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeMinutosDesde(this.cmb5HD.SelectedItem, this.cmb5MD);
            inicializarCombosDeHoraHasta(this.cmb5HD.SelectedItem, this.cmb5MD.SelectedItem, this.cmb5HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb5HD.SelectedItem, this.cmb5HH.SelectedItem, this.cmb5MH, "20");
        }

        private void cmb5MD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeHoraHasta(this.cmb5HD.SelectedItem, this.cmb5MD.SelectedItem, this.cmb5HH, 20);
            inicalizarCombosDeMinutosHasta(this.cmb5HD.SelectedItem, this.cmb5HH.SelectedItem, this.cmb5MH, "20");
        }

        private void cmb5HH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicalizarCombosDeMinutosHasta(this.cmb5HD.SelectedItem, this.cmb5HH.SelectedItem, this.cmb5MH, "20");
        }

        private void cmb6HD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeMinutosDesde(this.cmb6HD.SelectedItem, this.cmb6MD);
            inicializarCombosDeHoraHasta(this.cmb6HD.SelectedItem, this.cmb6MD.SelectedItem, this.cmb6HH, 15);
            inicalizarCombosDeMinutosHasta(this.cmb6HD.SelectedItem, this.cmb6HH.SelectedItem, this.cmb6MH, "15");
        }

        private void cmb6MD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicializarCombosDeHoraHasta(this.cmb6HD.SelectedItem, this.cmb6MD.SelectedItem, this.cmb6HH, 15);
            inicalizarCombosDeMinutosHasta(this.cmb6HD.SelectedItem, this.cmb6HH.SelectedItem, this.cmb6MH, "15");
        }

        private void cmb6HH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            inicalizarCombosDeMinutosHasta(this.cmb6HD.SelectedItem, this.cmb6HH.SelectedItem, this.cmb6MH, "15");
        }

        private void cleanFormulario()
        {
            this.txtDocumento.Text = null;
            this.btnRegistrarAgenda.Visible = false;
            id_profesional = 0; 
            lblProfesional.Visible = false;
            inicializarEspecialidades();
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            inicializarCombos();
        }

    }
}
