namespace ClinicaFrba.Cancelar_Atencion
{
    partial class Cancelar_Atencion
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
            this.btnMedica = new System.Windows.Forms.Button();
            this.btnAfiliado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedica
            // 
            this.btnMedica.Location = new System.Drawing.Point(12, 46);
            this.btnMedica.Name = "btnMedica";
            this.btnMedica.Size = new System.Drawing.Size(112, 51);
            this.btnMedica.TabIndex = 0;
            this.btnMedica.Text = "Cancelar Atención Medica";
            this.btnMedica.UseVisualStyleBackColor = true;
            this.btnMedica.Click += new System.EventHandler(this.btnMedica_Click);
            // 
            // btnAfiliado
            // 
            this.btnAfiliado.Location = new System.Drawing.Point(188, 46);
            this.btnAfiliado.Name = "btnAfiliado";
            this.btnAfiliado.Size = new System.Drawing.Size(112, 51);
            this.btnAfiliado.TabIndex = 1;
            this.btnAfiliado.Text = "Cancelar Atención Afiliado";
            this.btnAfiliado.UseVisualStyleBackColor = true;
            this.btnAfiliado.Click += new System.EventHandler(this.btnAfiliado_Click);
            // 
            // Cancelar_Atencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 149);
            this.Controls.Add(this.btnAfiliado);
            this.Controls.Add(this.btnMedica);
            this.Name = "Cancelar_Atencion";
            this.Text = "Agregar_Atencion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedica;
        private System.Windows.Forms.Button btnAfiliado;
    }
}