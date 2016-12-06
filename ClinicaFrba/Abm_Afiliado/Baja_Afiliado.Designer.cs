namespace ClinicaFrba.Abm_Afiliado
{
    partial class Baja_Afiliado
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
            this.dgvAfiliados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBaja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAfiliados
            // 
            this.dgvAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliados.Location = new System.Drawing.Point(-1, 96);
            this.dgvAfiliados.Name = "dgvAfiliados";
            this.dgvAfiliados.Size = new System.Drawing.Size(785, 129);
            this.dgvAfiliados.TabIndex = 0;
            this.dgvAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfiliados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar por documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(146, 23);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(101, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(287, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(698, 231);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 4;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Visible = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id de afiliado";
            // 
            // txtIdBaja
            // 
            this.txtIdBaja.Location = new System.Drawing.Point(649, 49);
            this.txtIdBaja.Name = "txtIdBaja";
            this.txtIdBaja.Size = new System.Drawing.Size(100, 20);
            this.txtIdBaja.TabIndex = 6;
            this.txtIdBaja.TextChanged += new System.EventHandler(this.txtIdBaja_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elegir id de afiliado a dar de baja";
            // 
            // Baja_Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAfiliados);
            this.Name = "Baja_Afiliado";
            this.Text = "Baja_Afiliado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAfiliados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBaja;
        private System.Windows.Forms.Label label3;
    }
}