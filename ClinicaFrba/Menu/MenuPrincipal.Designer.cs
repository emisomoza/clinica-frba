using System.Windows.Forms;
namespace ClinicaFrba.Menu
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraBonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesMasCanceladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalesMasConsultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadosConMasBonosCompradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesConMasBonosUsadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedirTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLlegadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarResultadoDeConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.cancelarAtenciónToolStripMenuItem,
            this.compraBonoToolStripMenuItem,
            this.verEstadísticasToolStripMenuItem,
            this.pedirTurnoToolStripMenuItem,
            this.registrarLlegadaToolStripMenuItem,
            this.registrarResultadoDeConsultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.afiliadosToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aBMToolStripMenuItem.Text = "ABMs";
            this.aBMToolStripMenuItem.Visible = false;
            // 
            // cancelarAtenciónToolStripMenuItem
            // 
            this.cancelarAtenciónToolStripMenuItem.Name = "cancelarAtenciónToolStripMenuItem";
            this.cancelarAtenciónToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.cancelarAtenciónToolStripMenuItem.Text = "Cancelar Atención";
            this.cancelarAtenciónToolStripMenuItem.Visible = false;
            // 
            // compraBonoToolStripMenuItem
            // 
            this.compraBonoToolStripMenuItem.Name = "compraBonoToolStripMenuItem";
            this.compraBonoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.compraBonoToolStripMenuItem.Text = "Compra Bono";
            this.compraBonoToolStripMenuItem.Click += new System.EventHandler(this.compraBonoToolStripMenuItem_Click);
            this.compraBonoToolStripMenuItem.Visible = false;
            // 
            // verEstadísticasToolStripMenuItem
            // 
            this.verEstadísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadesMasCanceladasToolStripMenuItem,
            this.profesionalesMasConsultadosToolStripMenuItem,
            this.afiliadosConMasBonosCompradosToolStripMenuItem,
            this.especialidadesConMasBonosUsadosToolStripMenuItem});
            this.verEstadísticasToolStripMenuItem.Name = "verEstadísticasToolStripMenuItem";
            this.verEstadísticasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.verEstadísticasToolStripMenuItem.Text = "Ver Estadísticas";
            this.verEstadísticasToolStripMenuItem.Visible = false;
            // 
            // especialidadesMasCanceladasToolStripMenuItem
            // 
            this.especialidadesMasCanceladasToolStripMenuItem.Name = "especialidadesMasCanceladasToolStripMenuItem";
            this.especialidadesMasCanceladasToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.especialidadesMasCanceladasToolStripMenuItem.Text = "Especialidades mas canceladas";
            // 
            // profesionalesMasConsultadosToolStripMenuItem
            // 
            this.profesionalesMasConsultadosToolStripMenuItem.Name = "profesionalesMasConsultadosToolStripMenuItem";
            this.profesionalesMasConsultadosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.profesionalesMasConsultadosToolStripMenuItem.Text = "Profesionales mas consultados";
            // 
            // afiliadosConMasBonosCompradosToolStripMenuItem
            // 
            this.afiliadosConMasBonosCompradosToolStripMenuItem.Name = "afiliadosConMasBonosCompradosToolStripMenuItem";
            this.afiliadosConMasBonosCompradosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.afiliadosConMasBonosCompradosToolStripMenuItem.Text = "Afiliados con mas bonos comprados";
            // 
            // especialidadesConMasBonosUsadosToolStripMenuItem
            // 
            this.especialidadesConMasBonosUsadosToolStripMenuItem.Name = "especialidadesConMasBonosUsadosToolStripMenuItem";
            this.especialidadesConMasBonosUsadosToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.especialidadesConMasBonosUsadosToolStripMenuItem.Text = "Especialidades con mas bonos usados";
            // 
            // pedirTurnoToolStripMenuItem
            // 
            this.pedirTurnoToolStripMenuItem.Name = "pedirTurnoToolStripMenuItem";
            this.pedirTurnoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.pedirTurnoToolStripMenuItem.Text = "Pedir turno";
            this.pedirTurnoToolStripMenuItem.Visible = false;
            // 
            // registrarLlegadaToolStripMenuItem
            // 
            this.registrarLlegadaToolStripMenuItem.Name = "registrarLlegadaToolStripMenuItem";
            this.registrarLlegadaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.registrarLlegadaToolStripMenuItem.Text = "Registrar llegada";
            this.registrarLlegadaToolStripMenuItem.Visible = false;
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            this.rolToolStripMenuItem.Visible = false;
            // 
            // afiliadosToolStripMenuItem
            // 
            this.afiliadosToolStripMenuItem.Name = "afiliadosToolStripMenuItem";
            this.afiliadosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.afiliadosToolStripMenuItem.Text = "Afiliados";
            this.afiliadosToolStripMenuItem.Visible = false;
            // 
            // registrarResultadoDeConsultaToolStripMenuItem
            // 
            this.registrarResultadoDeConsultaToolStripMenuItem.Name = "registrarResultadoDeConsultaToolStripMenuItem";
            this.registrarResultadoDeConsultaToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
            this.registrarResultadoDeConsultaToolStripMenuItem.Text = "Registrar resultado de consulta";
            this.registrarResultadoDeConsultaToolStripMenuItem.Visible = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 254);
            this.WindowState = FormWindowState.Maximized;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraBonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesMasCanceladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesionalesMasConsultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadosConMasBonosCompradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesConMasBonosUsadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedirTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLlegadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarResultadoDeConsultaToolStripMenuItem;

        /* Que hacer con estas funcionalidades?
        Sacar Turno (admin)
        Cancelar dia
        Modificar Plan_Afiliado
        */
    }
}