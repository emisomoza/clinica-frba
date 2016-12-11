namespace ClinicaFrba.Listados
{
    partial class Profesionales_Mas_Consultados
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_semestre
            // 
            this.combo_semestre.FormattingEnabled = true;
            this.combo_semestre.Location = new System.Drawing.Point(206, 15);
            this.combo_semestre.Name = "combo_semestre";
            this.combo_semestre.Size = new System.Drawing.Size(121, 21);
            this.combo_semestre.TabIndex = 2;
            // 
            // semestre
            // 
            this.semestre.AutoSize = true;
            this.semestre.Location = new System.Drawing.Point(146, 19);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(54, 13);
            this.semestre.TabIndex = 3;
            this.semestre.Text = "Semestre:";
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(183, 76);
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
            this.dataGridView1.Location = new System.Drawing.Point(66, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 190);
            this.dataGridView1.TabIndex = 3;
            // 
            // plan
            // 
            this.plan.AutoSize = true;
            this.plan.Location = new System.Drawing.Point(168, 47);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(31, 13);
            this.plan.TabIndex = 6;
            this.plan.Text = "Plan:";
            // 
            // combo_plan
            // 
            this.combo_plan.FormattingEnabled = true;
            this.combo_plan.Location = new System.Drawing.Point(206, 43);
            this.combo_plan.Name = "combo_plan";
            this.combo_plan.Size = new System.Drawing.Size(121, 21);
            this.combo_plan.TabIndex = 5;
            // 
            // Profesionales_Mas_Consultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 327);
            this.Controls.Add(this.plan);
            this.Controls.Add(this.combo_plan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.combo_semestre);
            this.Name = "Profesionales_Mas_Consultados";
            this.Text = "Profesionales Mas Consultados";
            this.Load += new System.EventHandler(this.Profesionales_Mas_Consultados_Load);
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
    }
}