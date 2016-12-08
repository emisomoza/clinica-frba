namespace ClinicaFrba.Registro_Llegada
{
    partial class Registrar_Llegada
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
            this.especialidades = new System.Windows.Forms.ComboBox();
            this.lEspecialidades = new System.Windows.Forms.Label();
            this.profesionales = new System.Windows.Forms.ComboBox();
            this.lProfesionales = new System.Windows.Forms.Label();
            this.btnBuscarTurnos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NUMERO_TURNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliado_nomyap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // especialidades
            // 
            this.especialidades.FormattingEnabled = true;
            this.especialidades.Location = new System.Drawing.Point(100, 20);
            this.especialidades.Name = "especialidades";
            this.especialidades.Size = new System.Drawing.Size(251, 21);
            this.especialidades.TabIndex = 0;
            this.especialidades.SelectionChangeCommitted += new System.EventHandler(this.especialidades_SelectionChangeCommitted);
            // 
            // lEspecialidades
            // 
            this.lEspecialidades.AutoSize = true;
            this.lEspecialidades.Location = new System.Drawing.Point(13, 23);
            this.lEspecialidades.Name = "lEspecialidades";
            this.lEspecialidades.Size = new System.Drawing.Size(81, 13);
            this.lEspecialidades.TabIndex = 1;
            this.lEspecialidades.Text = "Especialidades:";
            // 
            // profesionales
            // 
            this.profesionales.FormattingEnabled = true;
            this.profesionales.Location = new System.Drawing.Point(100, 50);
            this.profesionales.Name = "profesionales";
            this.profesionales.Size = new System.Drawing.Size(251, 21);
            this.profesionales.TabIndex = 0;
            // 
            // lProfesionales
            // 
            this.lProfesionales.AutoSize = true;
            this.lProfesionales.Location = new System.Drawing.Point(13, 53);
            this.lProfesionales.Name = "lProfesionales";
            this.lProfesionales.Size = new System.Drawing.Size(73, 13);
            this.lProfesionales.TabIndex = 1;
            this.lProfesionales.Text = "Profesionales:";
            // 
            // btnBuscarTurnos
            // 
            this.btnBuscarTurnos.Location = new System.Drawing.Point(145, 77);
            this.btnBuscarTurnos.Name = "btnBuscarTurnos";
            this.btnBuscarTurnos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTurnos.TabIndex = 2;
            this.btnBuscarTurnos.Text = "Aceptar";
            this.btnBuscarTurnos.Click += new System.EventHandler(this.btnBuscarTurnos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMERO_TURNO,
            this.afiliado_nomyap});
            this.dataGridView1.Location = new System.Drawing.Point(16, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUMERO_TURNO
            // 
            this.NUMERO_TURNO.HeaderText = "Número de turno";
            this.NUMERO_TURNO.Name = "NUMERO_TURNO";
            // 
            // afiliado_nomyap
            // 
            this.afiliado_nomyap.HeaderText = "Paciente";
            this.afiliado_nomyap.Name = "afiliado_nomyap";
            // 
            // Registrar_Llegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 199);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lEspecialidades);
            this.Controls.Add(this.especialidades);
            this.Controls.Add(this.lProfesionales);
            this.Controls.Add(this.profesionales);
            this.Controls.Add(this.btnBuscarTurnos);
            this.Name = "Registrar_Llegada";
            this.Text = "Registrar Llegada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox especialidades;
        private System.Windows.Forms.Label lEspecialidades;
        private System.Windows.Forms.ComboBox profesionales;
        private System.Windows.Forms.Label lProfesionales;
        private System.Windows.Forms.Button btnBuscarTurnos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_TURNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn afiliado_nomyap;
    }
}