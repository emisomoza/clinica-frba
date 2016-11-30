namespace ClinicaFrba.Logueo
{
    partial class Seleccionar_Rol
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
            this.roles = new System.Windows.Forms.ComboBox();
            this.seleccionar_rol = new System.Windows.Forms.Label();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // Seleccionar Rol
            this.seleccionar_rol.AutoSize = true;
            this.seleccionar_rol.Location = new System.Drawing.Point(13, 23);
            this.seleccionar_rol.Name = "label1";
            this.seleccionar_rol.Size = new System.Drawing.Size(35, 13);
            this.seleccionar_rol.TabIndex = 1;
            this.seleccionar_rol.Text = "Seleccionar el Rol:";
            // roles
            this.roles.FormattingEnabled = true;
            this.roles.Location = new System.Drawing.Point(112, 20);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(196, 21);
            this.roles.TabIndex = 0;
            // boton_aceptar
            this.boton_aceptar.Location = new System.Drawing.Point(122, 57);
            this.boton_aceptar.Name = "button1";
            this.boton_aceptar.Size = new System.Drawing.Size(75, 23);
            this.boton_aceptar.TabIndex = 2;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 104);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.seleccionar_rol);
            this.Controls.Add(this.roles);
            this.Name = "Seleccionar Rol";
            this.Text = "Seleccionar Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roles;
        private System.Windows.Forms.Label seleccionar_rol;
        private System.Windows.Forms.Button boton_aceptar;
    }
}