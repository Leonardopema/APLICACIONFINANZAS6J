namespace Finanzas6J
{
    partial class FPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRIngreso = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvRGastos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIngreso)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRGastos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrada +";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cboMes.Location = new System.Drawing.Point(6, 36);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(80, 21);
            this.cboMes.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 154);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRIngreso);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvRIngreso
            // 
            this.dgvRIngreso.AllowUserToAddRows = false;
            this.dgvRIngreso.AllowUserToDeleteRows = false;
            this.dgvRIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRIngreso.Location = new System.Drawing.Point(19, 11);
            this.dgvRIngreso.Name = "dgvRIngreso";
            this.dgvRIngreso.ReadOnly = true;
            this.dgvRIngreso.Size = new System.Drawing.Size(357, 103);
            this.dgvRIngreso.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSaldo);
            this.tabPage2.Controls.Add(this.txtGastos);
            this.tabPage2.Controls.Add(this.txtIngreso);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saldo";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(162, 83);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(164, 20);
            this.txtSaldo.TabIndex = 13;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSaldo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtGastos
            // 
            this.txtGastos.BackColor = System.Drawing.Color.White;
            this.txtGastos.Location = new System.Drawing.Point(162, 53);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.Size = new System.Drawing.Size(164, 20);
            this.txtGastos.TabIndex = 12;
            this.txtGastos.Text = "0";
            this.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGastos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIngreso
            // 
            this.txtIngreso.BackColor = System.Drawing.Color.White;
            this.txtIngreso.Location = new System.Drawing.Point(162, 24);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.ReadOnly = true;
            this.txtIngreso.Size = new System.Drawing.Size(164, 20);
            this.txtIngreso.TabIndex = 11;
            this.txtIngreso.Text = "0";
            this.txtIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIngreso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saldo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gastos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingresos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvRGastos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(397, 128);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gastos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvRGastos
            // 
            this.dgvRGastos.AllowUserToAddRows = false;
            this.dgvRGastos.AllowUserToDeleteRows = false;
            this.dgvRGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRGastos.Location = new System.Drawing.Point(20, 6);
            this.dgvRGastos.Name = "dgvRGastos";
            this.dgvRGastos.ReadOnly = true;
            this.dgvRGastos.Size = new System.Drawing.Size(357, 116);
            this.dgvRGastos.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salida -";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(104, 36);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(60, 20);
            this.txtAño.TabIndex = 6;
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.AllowUserToAddRows = false;
            this.dgvMovimiento.AllowUserToDeleteRows = false;
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(4, 240);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.ReadOnly = true;
            this.dgvMovimiento.Size = new System.Drawing.Size(420, 198);
            this.dgvMovimiento.TabIndex = 5;
            this.dgvMovimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(227, 193);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control De Gastos";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRIngreso)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRGastos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMovimiento;
        private System.Windows.Forms.DataGridView dgvRGastos;
        private System.Windows.Forms.DataGridView dgvRIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnBuscar;
    }
}