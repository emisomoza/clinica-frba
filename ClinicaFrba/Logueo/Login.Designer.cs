namespace ClinicaFrba.Logueo
{
    partial class Login
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
            this.titulo_usuario = new System.Windows.Forms.Label();
            this.texto_usuario = new System.Windows.Forms.TextBox();
            this.titulo_contrasenia = new System.Windows.Forms.Label();
            this.texto_contrasenia = new System.Windows.Forms.TextBox();
            this.boton_aceptar = new System.Windows.Forms.Button();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // titulo_usuario
            this.titulo_usuario.AutoSize = true;
            this.titulo_usuario.Location = new System.Drawing.Point(40, 23);
            this.titulo_usuario.Name = "titulo_usuario";
            //this.titulo_usuario.Size = new System.Drawing.Size(43, 13);
            this.titulo_usuario.TabIndex = 0;
            this.titulo_usuario.Text = "Usuario: ";
            // texto_usuario
            this.texto_usuario.Location = new System.Drawing.Point(90, 20);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(173, 20);
            this.texto_usuario.TabIndex = 1;
            this.texto_usuario.Focus();
            // titulo_contrasenia
            this.titulo_contrasenia.AutoSize = true;
            this.titulo_contrasenia.Location = new System.Drawing.Point(40, 63);
            this.titulo_contrasenia.Name = "titulo_contrasenia";
            this.titulo_contrasenia.Size = new System.Drawing.Size(61, 13);
            this.titulo_contrasenia.TabIndex = 2;
            this.titulo_contrasenia.Text = "Contraseña: ";
            // texto_contrasenia
            this.texto_contrasenia.Location = new System.Drawing.Point(110, 60);
            this.texto_contrasenia.Name = "texto_contrasenia";
            this.texto_contrasenia.Size = new System.Drawing.Size(153, 20);
            this.texto_contrasenia.TabIndex = 3;
            this.texto_contrasenia.UseSystemPasswordChar = true;
            // boton_aceptar
            this.boton_aceptar.Location = new System.Drawing.Point(60, 120);
            this.boton_aceptar.Name = "boton_aceptar";
            this.boton_aceptar.Size = new System.Drawing.Size(70, 21);
            this.boton_aceptar.TabIndex = 4;
            this.boton_aceptar.Text = "Aceptar";
            this.boton_aceptar.Click += new System.EventHandler(this.boton_aceptar_Click);
            // boton_cancelar
            this.boton_cancelar.Location = new System.Drawing.Point(154, 120);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(70, 21);
            this.boton_cancelar.TabIndex = 5;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // Login
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Location = new System.Drawing.Point(150, 150);
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_aceptar);
            this.Controls.Add(this.texto_contrasenia);
            this.Controls.Add(this.titulo_contrasenia);
            this.Controls.Add(this.texto_usuario);
            this.Controls.Add(this.titulo_usuario);
            this.Name = "Login";
            this.Text = "ClinicaFRBA - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo_usuario;
        private System.Windows.Forms.TextBox texto_usuario;
        private System.Windows.Forms.Label titulo_contrasenia;
        private System.Windows.Forms.TextBox texto_contrasenia;
        private System.Windows.Forms.Button boton_aceptar;
        private System.Windows.Forms.Button boton_cancelar;
    }
}

