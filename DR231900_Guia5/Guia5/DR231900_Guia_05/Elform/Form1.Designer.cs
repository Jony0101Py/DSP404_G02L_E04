namespace Elform
{
    partial class frmRegistoEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.Lblfechanac = new System.Windows.Forms.Label();
            this.Lblapellidos = new System.Windows.Forms.Label();
            this.Lblnombres = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIsss = new System.Windows.Forms.Label();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txtSueldoini = new System.Windows.Forms.TextBox();
            this.lblRenta = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.LblContrato = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.Lblfechanac);
            this.groupBox1.Controls.Add(this.Lblapellidos);
            this.groupBox1.Controls.Add(this.Lblnombres);
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales de empleados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(161, 114);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(223, 26);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(161, 75);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(194, 26);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(161, 31);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(194, 26);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // Lblfechanac
            // 
            this.Lblfechanac.AutoSize = true;
            this.Lblfechanac.Location = new System.Drawing.Point(16, 121);
            this.Lblfechanac.Name = "Lblfechanac";
            this.Lblfechanac.Size = new System.Drawing.Size(139, 20);
            this.Lblfechanac.TabIndex = 2;
            this.Lblfechanac.Text = "Fecha nacimiento:";
            // 
            // Lblapellidos
            // 
            this.Lblapellidos.AutoSize = true;
            this.Lblapellidos.Location = new System.Drawing.Point(16, 82);
            this.Lblapellidos.Name = "Lblapellidos";
            this.Lblapellidos.Size = new System.Drawing.Size(77, 20);
            this.Lblapellidos.TabIndex = 1;
            this.Lblapellidos.Text = "Apellidos:";
            // 
            // Lblnombres
            // 
            this.Lblnombres.AutoSize = true;
            this.Lblnombres.Location = new System.Drawing.Point(16, 38);
            this.Lblnombres.Name = "Lblnombres";
            this.Lblnombres.Size = new System.Drawing.Size(77, 20);
            this.Lblnombres.TabIndex = 0;
            this.Lblnombres.Text = "Nombres:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIsss);
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.txtSueldoini);
            this.groupBox2.Controls.Add(this.lblRenta);
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Controls.Add(this.LblContrato);
            this.groupBox2.Location = new System.Drawing.Point(439, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos laborales:";
            // 
            // lblIsss
            // 
            this.lblIsss.AutoSize = true;
            this.lblIsss.Location = new System.Drawing.Point(238, 120);
            this.lblIsss.Name = "lblIsss";
            this.lblIsss.Size = new System.Drawing.Size(90, 20);
            this.lblIsss.TabIndex = 9;
            this.lblIsss.Text = "Tasa ISSS:";
            // 
            // nudISSS
            // 
            this.nudISSS.DecimalPlaces = 1;
            this.nudISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudISSS.Location = new System.Drawing.Point(330, 114);
            this.nudISSS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(82, 26);
            this.nudISSS.TabIndex = 8;
            this.nudISSS.ValueChanged += new System.EventHandler(this.nudISSS_ValueChanged);
            // 
            // nudRenta
            // 
            this.nudRenta.DecimalPlaces = 1;
            this.nudRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRenta.Location = new System.Drawing.Point(136, 114);
            this.nudRenta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(75, 26);
            this.nudRenta.TabIndex = 7;
            this.nudRenta.ValueChanged += new System.EventHandler(this.nudRenta_ValueChanged);
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(136, 31);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaContrato.TabIndex = 6;
            // 
            // txtSueldoini
            // 
            this.txtSueldoini.Location = new System.Drawing.Point(136, 76);
            this.txtSueldoini.Name = "txtSueldoini";
            this.txtSueldoini.Size = new System.Drawing.Size(151, 26);
            this.txtSueldoini.TabIndex = 5;
            this.txtSueldoini.TextChanged += new System.EventHandler(this.txtSueldoini_TextChanged);
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(24, 120);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(96, 20);
            this.lblRenta.TabIndex = 2;
            this.lblRenta.Text = "Tasa Renta:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(24, 81);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(102, 20);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo base:";
            // 
            // LblContrato
            // 
            this.LblContrato.AutoSize = true;
            this.LblContrato.Location = new System.Drawing.Point(20, 37);
            this.LblContrato.Name = "LblContrato";
            this.LblContrato.Size = new System.Drawing.Size(121, 20);
            this.LblContrato.TabIndex = 0;
            this.LblContrato.Text = "Fecha contrato:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(29, 208);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(183, 28);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(236, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(183, 29);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Proximo empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(439, 208);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(189, 28);
            this.btnAbrirPlanilla.TabIndex = 4;
            this.btnAbrirPlanilla.Text = "Abrir Planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            this.btnAbrirPlanilla.Click += new System.EventHandler(this.btnAbrirPlanilla_Click);
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(654, 208);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(197, 29);
            this.btnGenerarPlanilla.TabIndex = 5;
            this.btnGenerarPlanilla.Text = "Generar Planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            this.btnGenerarPlanilla.Click += new System.EventHandler(this.btnGenerarPlanilla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(822, 243);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmRegistoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistoEmpleados";
            this.Text = "Registro inicial de empleados";
            this.Load += new System.EventHandler(this.frmRegistoEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label Lblfechanac;
        private System.Windows.Forms.Label Lblapellidos;
        private System.Windows.Forms.Label Lblnombres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSueldoini;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label LblContrato;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblIsss;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnGenerarPlanilla;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

