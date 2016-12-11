namespace ClinicaFrba.Listados
{
    partial class Estadisticas
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
            this.combo_anio = new System.Windows.Forms.ComboBox();
            this.anio = new System.Windows.Forms.Label();
            this.estadistica1 = new System.Windows.Forms.Button();
            this.estadistica2 = new System.Windows.Forms.Button();
            this.estadistica3 = new System.Windows.Forms.Button();
            this.estadistica4 = new System.Windows.Forms.Button();
            this.estadistica5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_anio
            // 
            this.combo_anio.FormattingEnabled = true;
            this.combo_anio.Location = new System.Drawing.Point(121, 12);
            this.combo_anio.Name = "combo_anio";
            this.combo_anio.Size = new System.Drawing.Size(86, 21);
            this.combo_anio.TabIndex = 3;
            // 
            // anio
            // 
            this.anio.AutoSize = true;
            this.anio.Location = new System.Drawing.Point(87, 16);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(29, 13);
            this.anio.TabIndex = 2;
            this.anio.Text = "Año:";
            // 
            // estadistica1
            // 
            this.estadistica1.Location = new System.Drawing.Point(45, 52);
            this.estadistica1.Name = "estadistica1";
            this.estadistica1.Size = new System.Drawing.Size(200, 23);
            this.estadistica1.TabIndex = 4;
            this.estadistica1.Text = "Especialidades mas canceladas";
            this.estadistica1.UseVisualStyleBackColor = true;
            this.estadistica1.Click += new System.EventHandler(this.estadistica1_Click);
            // 
            // estadistica2
            // 
            this.estadistica2.Location = new System.Drawing.Point(45, 81);
            this.estadistica2.Name = "estadistica2";
            this.estadistica2.Size = new System.Drawing.Size(200, 23);
            this.estadistica2.TabIndex = 5;
            this.estadistica2.Text = "Profesionales mas consultados";
            this.estadistica2.UseVisualStyleBackColor = true;
            this.estadistica2.Click += new System.EventHandler(this.estadistica2_Click);
            // 
            // estadistica3
            // 
            this.estadistica3.Location = new System.Drawing.Point(45, 110);
            this.estadistica3.Name = "estadistica3";
            this.estadistica3.Size = new System.Drawing.Size(200, 23);
            this.estadistica3.TabIndex = 6;
            this.estadistica3.Text = "Profesionales con menos hs trabajadas";
            this.estadistica3.UseVisualStyleBackColor = true;
            this.estadistica3.Click += new System.EventHandler(this.estadistica3_Click);
            // 
            // estadistica4
            // 
            this.estadistica4.Location = new System.Drawing.Point(45, 139);
            this.estadistica4.Name = "estadistica4";
            this.estadistica4.Size = new System.Drawing.Size(200, 23);
            this.estadistica4.TabIndex = 7;
            this.estadistica4.Text = "Afiliados con mas bonos comprados";
            this.estadistica4.UseVisualStyleBackColor = true;
            this.estadistica4.Click += new System.EventHandler(this.estadistica4_Click);
            // 
            // estadistica5
            // 
            this.estadistica5.Location = new System.Drawing.Point(45, 168);
            this.estadistica5.Name = "estadistica5";
            this.estadistica5.Size = new System.Drawing.Size(200, 23);
            this.estadistica5.TabIndex = 8;
            this.estadistica5.Text = "Especialidades con mas bonos usados";
            this.estadistica5.UseVisualStyleBackColor = true;
            this.estadistica5.Click += new System.EventHandler(this.estadistica5_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.estadistica5);
            this.Controls.Add(this.estadistica4);
            this.Controls.Add(this.estadistica3);
            this.Controls.Add(this.estadistica2);
            this.Controls.Add(this.estadistica1);
            this.Controls.Add(this.combo_anio);
            this.Controls.Add(this.anio);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_anio;
        private System.Windows.Forms.Label anio;
        private System.Windows.Forms.Button estadistica1;
        private System.Windows.Forms.Button estadistica2;
        private System.Windows.Forms.Button estadistica3;
        private System.Windows.Forms.Button estadistica4;
        private System.Windows.Forms.Button estadistica5;
    }
}