namespace ClinicaFrba.Menu
{
    partial class cl_Menu
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
            this.titulo_rol = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_abm_usuario = new System.Windows.Forms.Button();
            this.btn_abm_rol = new System.Windows.Forms.Button();
            this.titulo_usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo_rol
            // 
            this.titulo_rol.Location = new System.Drawing.Point(0, 25);
            this.titulo_rol.Name = "titulo_rol";
            this.titulo_rol.Size = new System.Drawing.Size(340, 13);
            this.titulo_rol.TabIndex = 0;
            this.titulo_rol.Text = "Titulo Rol";
            this.titulo_rol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(100, 280);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 40);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_abm_usuario
            // 
            this.btn_abm_usuario.Location = new System.Drawing.Point(100, 125);
            this.btn_abm_usuario.Name = "btn_abm_usuario";
            this.btn_abm_usuario.Size = new System.Drawing.Size(140, 40);
            this.btn_abm_usuario.TabIndex = 1;
            this.btn_abm_usuario.Text = "ABM Usuario";
            this.btn_abm_usuario.UseVisualStyleBackColor = true;
            this.btn_abm_usuario.Click += new System.EventHandler(this.btn_abm_usuario_Click);
            // 
            // btn_abm_rol
            // 
            this.btn_abm_rol.Location = new System.Drawing.Point(100, 177);
            this.btn_abm_rol.Name = "btn_abm_rol";
            this.btn_abm_rol.Size = new System.Drawing.Size(140, 40);
            this.btn_abm_rol.TabIndex = 0;
            this.btn_abm_rol.Text = "ABM Rol";
            this.btn_abm_rol.UseVisualStyleBackColor = true;
            this.btn_abm_rol.Click += new System.EventHandler(this.btn_abm_rol_Click);
            // 
            // titulo_usuario
            // 
            this.titulo_usuario.Location = new System.Drawing.Point(0, 50);
            this.titulo_usuario.Name = "titulo_usuario";
            this.titulo_usuario.Size = new System.Drawing.Size(340, 13);
            this.titulo_usuario.TabIndex = 9;
            this.titulo_usuario.Text = "Titulo usuario";
            this.titulo_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cl_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(340, 343);
            this.Controls.Add(this.titulo_usuario);
            this.Controls.Add(this.btn_abm_usuario);
            this.Controls.Add(this.btn_abm_rol);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.titulo_rol);
            this.Name = "cl_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.cl_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titulo_usuario;
        private System.Windows.Forms.Label titulo_rol;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_abm_usuario;
        private System.Windows.Forms.Button btn_abm_rol;
        
    }
}