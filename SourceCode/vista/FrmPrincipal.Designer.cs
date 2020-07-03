using System.ComponentModel;

namespace SourceCode
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFiebre = new System.Windows.Forms.Button();
            this.btnSinFiebre = new System.Windows.Forms.Button();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.entrada = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAsistencia = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LblBienveindo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEmpleados);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historico Empleado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(17, 87);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(609, 258);
            this.dgvEmpleados.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFiebre);
            this.tabPage2.Controls.Add(this.btnSinFiebre);
            this.tabPage2.Controls.Add(this.dtpEntrada);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.entrada);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbAsistencia);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pasar lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFiebre
            // 
            this.btnFiebre.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.btnFiebre.Location = new System.Drawing.Point(100, 177);
            this.btnFiebre.Name = "btnFiebre";
            this.btnFiebre.Size = new System.Drawing.Size(163, 67);
            this.btnFiebre.TabIndex = 33;
            this.btnFiebre.Text = "Reportar fiebre alta";
            this.btnFiebre.UseVisualStyleBackColor = true;
            // 
            // btnSinFiebre
            // 
            this.btnSinFiebre.Font = new System.Drawing.Font("Showcard Gothic", 15.75F);
            this.btnSinFiebre.Location = new System.Drawing.Point(430, 177);
            this.btnSinFiebre.Name = "btnSinFiebre";
            this.btnSinFiebre.Size = new System.Drawing.Size(163, 52);
            this.btnSinFiebre.TabIndex = 32;
            this.btnSinFiebre.Text = "Dejar pasar";
            this.btnSinFiebre.UseVisualStyleBackColor = true;
            this.btnSinFiebre.Click += new System.EventHandler(this.btnSinFiebre_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(447, 100);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(124, 23);
            this.dtpEntrada.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {1, 0, 0, 65536});
            this.numericUpDown1.Location = new System.Drawing.Point(129, 100);
            this.numericUpDown1.Maximum = new decimal(new int[] {41, 0, 0, 0});
            this.numericUpDown1.Minimum = new decimal(new int[] {34, 0, 0, 0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(156, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {34, 0, 0, 0});
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(535, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Salida";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(447, 40);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(104, 24);
            this.entrada.TabIndex = 4;
            this.entrada.Text = "Entrada";
            this.entrada.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado:";
            // 
            // cmbAsistencia
            // 
            this.cmbAsistencia.FormattingEnabled = true;
            this.cmbAsistencia.Location = new System.Drawing.Point(129, 47);
            this.cmbAsistencia.Name = "cmbAsistencia";
            this.cmbAsistencia.Size = new System.Drawing.Size(221, 23);
            this.cmbAsistencia.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Añadir empleado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(646, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resumen";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LblBienveindo
            // 
            this.LblBienveindo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LblBienveindo.Location = new System.Drawing.Point(140, 9);
            this.LblBienveindo.Name = "LblBienveindo";
            this.LblBienveindo.Size = new System.Drawing.Size(413, 38);
            this.LblBienveindo.TabIndex = 23;
            this.LblBienveindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 488);
            this.Controls.Add(this.LblBienveindo);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label LblBienveindo;
        private System.Windows.Forms.Button btnFiebre;
        private System.Windows.Forms.Button btnSinFiebre;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.CheckBox entrada;
        private System.Windows.Forms.ComboBox cmbAsistencia;
    }
}