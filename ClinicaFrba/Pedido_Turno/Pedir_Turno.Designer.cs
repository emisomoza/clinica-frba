namespace ClinicaFrba.Pedido_Turno
{
    partial class Pedir_Turno
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLimpiar = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnAfiliado = new System.Windows.Forms.Button();
            this.cmbFechas = new System.Windows.Forms.ComboBox();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Profesional";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(12, 97);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(164, 21);
            this.cmbProfesional.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(198, 97);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(499, 95);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar por especialidad";
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(318, 97);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(164, 21);
            this.cmbEspecialidades.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fechas disponibles:";
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(198, 151);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(96, 23);
            this.btnFecha.TabIndex = 8;
            this.btnFecha.Text = "Confirmar Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(14, 205);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(72, 21);
            this.cmbHora.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horarios disponibles:";
            // 
            // linkLimpiar
            // 
            this.linkLimpiar.AutoSize = true;
            this.linkLimpiar.Location = new System.Drawing.Point(6, 245);
            this.linkLimpiar.Name = "linkLimpiar";
            this.linkLimpiar.Size = new System.Drawing.Size(80, 13);
            this.linkLimpiar.TabIndex = 12;
            this.linkLimpiar.TabStop = true;
            this.linkLimpiar.Text = "Limpiar campos";
            this.linkLimpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpiar_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ingresa nro de documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(12, 27);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 21;
            // 
            // btnAfiliado
            // 
            this.btnAfiliado.Location = new System.Drawing.Point(118, 25);
            this.btnAfiliado.Name = "btnAfiliado";
            this.btnAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btnAfiliado.TabIndex = 22;
            this.btnAfiliado.Text = "Comprobar";
            this.btnAfiliado.UseVisualStyleBackColor = true;
            this.btnAfiliado.Click += new System.EventHandler(this.btnAfiliado_Click);
            // 
            // cmbFechas
            // 
            this.cmbFechas.FormattingEnabled = true;
            this.cmbFechas.Location = new System.Drawing.Point(12, 151);
            this.cmbFechas.Name = "cmbFechas";
            this.cmbFechas.Size = new System.Drawing.Size(164, 21);
            this.cmbFechas.TabIndex = 23;
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(16, 50);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(0, 13);
            this.lblAfiliado.TabIndex = 24;
            this.lblAfiliado.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(297, 230);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 38);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar Turno";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // Pedir_Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 295);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.cmbFechas);
            this.Controls.Add(this.btnAfiliado);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.label1);
            this.Name = "Pedir_Turno";
            this.Text = "Pedir_Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnAfiliado;
        private System.Windows.Forms.ComboBox cmbFechas;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Button btnConfirmar;
    }
}