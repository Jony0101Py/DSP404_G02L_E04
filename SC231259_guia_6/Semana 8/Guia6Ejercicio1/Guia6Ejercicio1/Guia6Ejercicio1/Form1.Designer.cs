namespace Guia6Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregarDoc = new System.Windows.Forms.Button();
            this.mtbCodDoctor = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.picFotoDoc = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSueldo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAnno = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.txtNomDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarVen = new System.Windows.Forms.Button();
            this.dtpFechaC = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.picFotoVen = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomVen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbVendedores = new System.Windows.Forms.RadioButton();
            this.rbDoctores = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoVen)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1179, 665);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAgregarDoc);
            this.tabPage1.Controls.Add(this.mtbCodDoctor);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.nudSueldo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.txtNomDoc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1171, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de Doctores";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.Location = new System.Drawing.Point(560, 572);
            this.btnAgregarDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Size = new System.Drawing.Size(160, 33);
            this.btnAgregarDoc.TabIndex = 8;
            this.btnAgregarDoc.Text = "Agregar a Doctor";
            this.btnAgregarDoc.UseVisualStyleBackColor = true;
            this.btnAgregarDoc.Click += new System.EventHandler(this.btnAgregarDoc_Click);
            // 
            // mtbCodDoctor
            // 
            this.mtbCodDoctor.Location = new System.Drawing.Point(797, 369);
            this.mtbCodDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCodDoctor.Mask = "AA-000000";
            this.mtbCodDoctor.Name = "mtbCodDoctor";
            this.mtbCodDoctor.Size = new System.Drawing.Size(269, 22);
            this.mtbCodDoctor.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.picFotoDoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(85, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 190);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // picFotoDoc
            // 
            this.picFotoDoc.Location = new System.Drawing.Point(201, 52);
            this.picFotoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFotoDoc.Name = "picFotoDoc";
            this.picFotoDoc.Size = new System.Drawing.Size(188, 208);
            this.picFotoDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoDoc.TabIndex = 1;
            this.picFotoDoc.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciona una foto:";
            // 
            // nudSueldo
            // 
            this.nudSueldo.DecimalPlaces = 2;
            this.nudSueldo.Location = new System.Drawing.Point(796, 300);
            this.nudSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSueldo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSueldo.Name = "nudSueldo";
            this.nudSueldo.Size = new System.Drawing.Size(273, 22);
            this.nudSueldo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cod. Medico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sueldo Base:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cmbAnno);
            this.groupBox2.Controls.Add(this.cmbMes);
            this.groupBox2.Controls.Add(this.cmbDia);
            this.groupBox2.Location = new System.Drawing.Point(593, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(529, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de Nacimiento";
            // 
            // cmbAnno
            // 
            this.cmbAnno.FormattingEnabled = true;
            this.cmbAnno.Location = new System.Drawing.Point(377, 55);
            this.cmbAnno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAnno.Name = "cmbAnno";
            this.cmbAnno.Size = new System.Drawing.Size(117, 24);
            this.cmbAnno.TabIndex = 2;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(215, 55);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(119, 24);
            this.cmbMes.TabIndex = 1;
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(29, 55);
            this.cmbDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(125, 24);
            this.cmbDia.TabIndex = 0;
            // 
            // txtNomDoc
            // 
            this.txtNomDoc.Location = new System.Drawing.Point(225, 84);
            this.txtNomDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomDoc.Name = "txtNomDoc";
            this.txtNomDoc.Size = new System.Drawing.Size(325, 22);
            this.txtNomDoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarVen);
            this.tabPage2.Controls.Add(this.dtpFechaC);
            this.tabPage2.Controls.Add(this.dtpFechaNac);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.txtNomVen);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1171, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso de Vendedores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVen
            // 
            this.btnAgregarVen.Location = new System.Drawing.Point(611, 507);
            this.btnAgregarVen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarVen.Name = "btnAgregarVen";
            this.btnAgregarVen.Size = new System.Drawing.Size(203, 33);
            this.btnAgregarVen.TabIndex = 10;
            this.btnAgregarVen.Text = "Agregar a Vendedor";
            this.btnAgregarVen.UseVisualStyleBackColor = true;
            this.btnAgregarVen.Click += new System.EventHandler(this.btnAgregarVen_Click);
            // 
            // dtpFechaC
            // 
            this.dtpFechaC.Location = new System.Drawing.Point(829, 190);
            this.dtpFechaC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaC.Name = "dtpFechaC";
            this.dtpFechaC.Size = new System.Drawing.Size(261, 22);
            this.dtpFechaC.TabIndex = 9;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(829, 92);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(259, 22);
            this.dtpFechaNac.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de Contratación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Nacimiento:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnBuscar2);
            this.groupBox3.Controls.Add(this.picFotoVen);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(100, 146);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(467, 290);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Foto";
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(59, 150);
            this.btnBuscar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(92, 30);
            this.btnBuscar2.TabIndex = 4;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // picFotoVen
            // 
            this.picFotoVen.Location = new System.Drawing.Point(247, 43);
            this.picFotoVen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFotoVen.Name = "picFotoVen";
            this.picFotoVen.Size = new System.Drawing.Size(188, 208);
            this.picFotoVen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoVen.TabIndex = 1;
            this.picFotoVen.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seleccione una foto:";
            // 
            // txtNomVen
            // 
            this.txtNomVen.Location = new System.Drawing.Point(240, 85);
            this.txtNomVen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomVen.Name = "txtNomVen";
            this.txtNomVen.Size = new System.Drawing.Size(325, 22);
            this.txtNomVen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre Completo:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rbVendedores);
            this.tabPage3.Controls.Add(this.rbDoctores);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1171, 636);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ver Empleados Registrados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rbVendedores
            // 
            this.rbVendedores.AutoSize = true;
            this.rbVendedores.Location = new System.Drawing.Point(285, 65);
            this.rbVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbVendedores.Name = "rbVendedores";
            this.rbVendedores.Size = new System.Drawing.Size(204, 20);
            this.rbVendedores.TabIndex = 2;
            this.rbVendedores.TabStop = true;
            this.rbVendedores.Text = "Ver Vendedores Registrados";
            this.rbVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbVendedores.UseVisualStyleBackColor = true;
            this.rbVendedores.CheckedChanged += new System.EventHandler(this.rbVendedores_CheckedChanged);
            // 
            // rbDoctores
            // 
            this.rbDoctores.AutoSize = true;
            this.rbDoctores.Location = new System.Drawing.Point(33, 65);
            this.rbDoctores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDoctores.Name = "rbDoctores";
            this.rbDoctores.Size = new System.Drawing.Size(184, 20);
            this.rbDoctores.TabIndex = 1;
            this.rbDoctores.TabStop = true;
            this.rbDoctores.Text = "Ver Doctores Registrados";
            this.rbDoctores.UseVisualStyleBackColor = true;
            this.rbDoctores.CheckedChanged += new System.EventHandler(this.rbDoctores_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.Nom,
            this.Foto,
            this.Column1,
            this.campo});
            this.dataGridView1.Location = new System.Drawing.Point(33, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 120;
            this.dataGridView1.Size = new System.Drawing.Size(916, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // num
            // 
            this.num.HeaderText = "#";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.num.Width = 39;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nombre completo";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 200;
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha nacimiento";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 125;
            // 
            // campo
            // 
            this.campo.HeaderText = "campo";
            this.campo.MinimumWidth = 6;
            this.campo.Name = "campo";
            this.campo.ReadOnly = true;
            this.campo.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 815);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoVen)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox picFotoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCodDoctor;
        private System.Windows.Forms.NumericUpDown nudSueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAnno;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picFotoVen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomVen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaC;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnAgregarDoc;
        private System.Windows.Forms.Button btnAgregarVen;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbVendedores;
        private System.Windows.Forms.RadioButton rbDoctores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn campo;
    }
}

