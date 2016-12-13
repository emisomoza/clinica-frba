using System.Windows.Forms;
namespace ClinicaFrba.Compra_Bono
{
    partial class Comprar_Bono
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
            this.txtNumeroAfiliado = new System.Windows.Forms.MaskedTextBox();
            this.lNumeroAfiliado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.lCantidad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(130, 22);
            this.txtNumeroAfiliado.MaxLength = 255;
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(120, 20);
            this.txtNumeroAfiliado.TabIndex = 1;
            this.txtNumeroAfiliado.Visible = false;
            this.txtNumeroAfiliado.ValidatingType = typeof(int);
            this.txtNumeroAfiliado.TypeValidationCompleted += new TypeValidationEventHandler(txtNumeroAfiliado_TypeValidationCompleted);
            // 
            // lNumeroAfiliado
            // 
            this.lNumeroAfiliado.AutoSize = true;
            this.lNumeroAfiliado.Location = new System.Drawing.Point(25, 25);
            this.lNumeroAfiliado.Name = "lNumeroAfiliado";
            this.lNumeroAfiliado.Size = new System.Drawing.Size(99, 13);
            this.lNumeroAfiliado.TabIndex = 0;
            this.lNumeroAfiliado.Text = "Numero de Afiliado:";
            this.lNumeroAfiliado.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(130, 47);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Minimum = 1;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(72, 50);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(55, 13);
            this.lCantidad.TabIndex = 2;
            this.lCantidad.Text = "Cantidad: ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(45, 100);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Comprar_Bono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 161);
            this.Controls.Add(this.lNumeroAfiliado);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Comprar_Bono";
            this.Text = "Comprar Bono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.MaskedTextBox txtNumeroAfiliado;
        private System.Windows.Forms.Label lNumeroAfiliado;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}