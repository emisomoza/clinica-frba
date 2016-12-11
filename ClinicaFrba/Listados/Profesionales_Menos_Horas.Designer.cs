namespace ClinicaFrba.Listados
{
    partial class Profesionales_Menos_Horas
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
            this.combo_semestre = new System.Windows.Forms.ComboBox();
            this.semestre = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plan = new System.Windows.Forms.Label();
            this.combo_plan = new System.Windows.Forms.ComboBox();
            this.especialidad = new System.Windows.Forms.Label();
            this.combo_especialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_semestre
            // 
            this.combo_semestre.FormattingEnabled = true;
            this.combo_semestre.Location = new System.Drawing.Point(203, 50);
            this.combo_semestre.Name = "combo_semestre";
            this.combo_semestre.Size = new System.Drawing.Size(121, 21);
            this.combo_semestre.TabIndex = 2;
            // 
            // semestre
            // 
            this.semestre.AutoSize = true;
            this.semestre.Location = new System.Drawing.Point(143, 54);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(54, 13);
            this.semestre.TabIndex = 3;
            this.semestre.Text = "Semestre:";
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(180, 111);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(100, 23);
            this.btn_listar.TabIndex = 4;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 190);
            this.dataGridView1.TabIndex = 3;
            // 
            // plan
            // 
            this.plan.AutoSize = true;
            this.plan.Location = new System.Drawing.Point(165, 82);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(31, 13);
            this.plan.TabIndex = 6;
            this.plan.Text = "Plan:";
            // 
            // combo_plan
            // 
            this.combo_plan.FormattingEnabled = true;
            this.combo_plan.Location = new System.Drawing.Point(203, 78);
            this.combo_plan.Name = "combo_plan";
            this.combo_plan.Size = new System.Drawing.Size(121, 21);
            this.combo_plan.TabIndex = 5;
            // 
            // especialidad
            // 
            this.especialidad.AutoSize = true;
            this.especialidad.Location = new System.Drawing.Point(126, 26);
            this.especialidad.Name = "especialidad";
            this.especialidad.Size = new System.Drawing.Size(70, 13);
            this.especialidad.TabIndex = 8;
            this.especialidad.Text = "Especialidad:";
            // 
            // combo_especialidad
            // 
            this.combo_especialidad.FormattingEnabled = true;
            this.combo_especialidad.Location = new System.Drawing.Point(203, 23);
            this.combo_especialidad.Name = "combo_especialidad";
            this.combo_especialidad.Size = new System.Drawing.Size(121, 21);
            this.combo_especialidad.TabIndex = 7;
            // 
            // Profesionales_Menos_Horas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 365);
            this.Controls.Add(this.plan);
            this.Controls.Add(this.combo_plan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.combo_semestre);
            this.Controls.Add(this.especialidad);
            this.Controls.Add(this.combo_especialidad);
            this.Name = "Profesionales_Menos_Horas";
            this.Text = "Profesionales Mas Consultados";
            this.Load += new System.EventHandler(this.Profesionales_Menos_Horas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_semestre;
        private System.Windows.Forms.Label semestre;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label plan;
        private System.Windows.Forms.ComboBox combo_plan;
        private System.Windows.Forms.Label especialidad;
        private System.Windows.Forms.ComboBox combo_especialidad;
    }
}