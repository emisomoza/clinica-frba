namespace ClinicaFrba.Abm_Afiliado
{
    partial class Alta_Familiares
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
            this.btnConyuge = new System.Windows.Forms.Button();
            this.btnHijos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Desea agregar cónyuge e hijos?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConyuge
            // 
            this.btnConyuge.Location = new System.Drawing.Point(12, 107);
            this.btnConyuge.Name = "btnConyuge";
            this.btnConyuge.Size = new System.Drawing.Size(107, 62);
            this.btnConyuge.TabIndex = 1;
            this.btnConyuge.Text = "Agregar cónyuge";
            this.btnConyuge.UseVisualStyleBackColor = true;
            this.btnConyuge.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHijos
            // 
            this.btnHijos.Location = new System.Drawing.Point(162, 107);
            this.btnHijos.Name = "btnHijos";
            this.btnHijos.Size = new System.Drawing.Size(110, 62);
            this.btnHijos.TabIndex = 2;
            this.btnHijos.Text = "Agregar hijos";
            this.btnHijos.UseVisualStyleBackColor = true;
            this.btnHijos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(197, 226);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(12, 9);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(41, 13);
            this.lblAfiliado.TabIndex = 4;
            this.lblAfiliado.Text = "Afiliado";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 41);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // Alta_Familiares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnHijos);
            this.Controls.Add(this.btnConyuge);
            this.Controls.Add(this.label1);
            this.Name = "Alta_Familiares";
            this.Text = "Alta de familiares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConyuge;
        private System.Windows.Forms.Button btnHijos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Label lblUsuario;
    }
}