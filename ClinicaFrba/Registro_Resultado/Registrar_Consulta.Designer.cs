namespace ClinicaFrba.Registro_Resultado
{
    partial class Registrar_Consulta
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
            this.fechayhora = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lsintomas = new System.Windows.Forms.Label();
            this.ldiagnostico = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_sintomas = new System.Windows.Forms.RichTextBox();
            this.txt_diagnostico = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // fechayhora
            // 
            this.fechayhora.AutoSize = true;
            this.fechayhora.Location = new System.Drawing.Point(13, 30);
            this.fechayhora.Name = "fechayhora";
            this.fechayhora.Size = new System.Drawing.Size(134, 13);
            this.fechayhora.TabIndex = 0;
            this.fechayhora.Text = "Fecha y hora de atención: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lsintomas
            // 
            this.lsintomas.AutoSize = true;
            this.lsintomas.Location = new System.Drawing.Point(90, 60);
            this.lsintomas.Name = "lsintomas";
            this.lsintomas.Size = new System.Drawing.Size(56, 13);
            this.lsintomas.TabIndex = 2;
            this.lsintomas.Text = "Síntomas: ";
            // 
            // ldiagnostico
            // 
            this.ldiagnostico.AutoSize = true;
            this.ldiagnostico.Location = new System.Drawing.Point(77, 137);
            this.ldiagnostico.Name = "ldiagnostico";
            this.ldiagnostico.Size = new System.Drawing.Size(69, 13);
            this.ldiagnostico.TabIndex = 4;
            this.ldiagnostico.Text = "Diagnóstico: ";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(129, 226);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(100, 23);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(249, 226);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_sintomas
            // 
            this.txt_sintomas.Location = new System.Drawing.Point(152, 57);
            this.txt_sintomas.Name = "txt_sintomas";
            this.txt_sintomas.Size = new System.Drawing.Size(200, 67);
            this.txt_sintomas.TabIndex = 9;
            this.txt_sintomas.Text = "";
            // 
            // txt_diagnostico
            // 
            this.txt_diagnostico.Location = new System.Drawing.Point(152, 134);
            this.txt_diagnostico.Name = "txt_diagnostico";
            this.txt_diagnostico.Size = new System.Drawing.Size(200, 67);
            this.txt_diagnostico.TabIndex = 10;
            this.txt_diagnostico.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(359, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(411, 28);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // Registrar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txt_diagnostico);
            this.Controls.Add(this.txt_sintomas);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.ldiagnostico);
            this.Controls.Add(this.lsintomas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.fechayhora);
            this.Name = "Registrar_Consulta";
            this.Text = "Registrar Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fechayhora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lsintomas;
        private System.Windows.Forms.Label ldiagnostico;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RichTextBox txt_sintomas;
        private System.Windows.Forms.RichTextBox txt_diagnostico;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
    }
}