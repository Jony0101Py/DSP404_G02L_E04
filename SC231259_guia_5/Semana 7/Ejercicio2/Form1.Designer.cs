namespace Ejercicio2
{
    partial class Form1
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
            this.nudSaldo = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudInteres = new System.Windows.Forms.NumericUpDown();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIngresoC = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnActu = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.nudNCuenta = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            this.nudIngC = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIngC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudSaldo);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.nudInteres);
            this.groupBox1.Controls.Add(this.lblInteres);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.txtDUI);
            this.groupBox1.Controls.Add(this.lblDUI);
            this.groupBox1.Controls.Add(this.nudNCuenta);
            this.groupBox1.Controls.Add(this.lblNumCuenta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Cuenta";
            // 
            // nudSaldo
            // 
            this.nudSaldo.Location = new System.Drawing.Point(136, 100);
            this.nudSaldo.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudSaldo.Name = "nudSaldo";
            this.nudSaldo.Size = new System.Drawing.Size(120, 22);
            this.nudSaldo.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(174, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 30);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nudInteres
            // 
            this.nudInteres.Location = new System.Drawing.Point(136, 132);
            this.nudInteres.Maximum = new decimal(new int[] {
            223,
            0,
            0,
            65536});
            this.nudInteres.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudInteres.Name = "nudInteres";
            this.nudInteres.Size = new System.Drawing.Size(120, 22);
            this.nudInteres.TabIndex = 7;
            this.nudInteres.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(7, 132);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(87, 16);
            this.lblInteres.TabIndex = 6;
            this.lblInteres.Text = "Interés Anual:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(7, 100);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(110, 16);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo de Cuenta:";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(136, 69);
            this.txtDUI.MaxLength = 9;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(120, 22);
            this.txtDUI.TabIndex = 3;
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(7, 69);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(103, 16);
            this.lblDUI.TabIndex = 2;
            this.lblDUI.Text = "Número de DUI:";
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Location = new System.Drawing.Point(7, 37);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(122, 16);
            this.lblNumCuenta.TabIndex = 0;
            this.lblNumCuenta.Text = "Número de Cuenta:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(690, 498);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(97, 25);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudIngC);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.btnRetirar);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.lblIngresoC);
            this.groupBox2.Location = new System.Drawing.Point(299, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Saldo";
            // 
            // lblIngresoC
            // 
            this.lblIngresoC.AutoSize = true;
            this.lblIngresoC.Location = new System.Drawing.Point(6, 39);
            this.lblIngresoC.Name = "lblIngresoC";
            this.lblIngresoC.Size = new System.Drawing.Size(136, 16);
            this.lblIngresoC.TabIndex = 0;
            this.lblIngresoC.Text = "Número de la Cuenta:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(7, 68);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(149, 69);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 3;
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(633, 182);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(155, 29);
            this.btnActu.TabIndex = 4;
            this.btnActu.Text = "Actualizar Saldos";
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(391, 110);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(87, 29);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(298, 110);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(87, 29);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // nudNCuenta
            // 
            this.nudNCuenta.Location = new System.Drawing.Point(136, 37);
            this.nudNCuenta.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudNCuenta.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudNCuenta.Name = "nudNCuenta";
            this.nudNCuenta.Size = new System.Drawing.Size(120, 22);
            this.nudNCuenta.TabIndex = 1;
            this.nudNCuenta.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(489, 183);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 29);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar Saldo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // nudIngC
            // 
            this.nudIngC.Location = new System.Drawing.Point(149, 37);
            this.nudIngC.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudIngC.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIngC.Name = "nudIngC";
            this.nudIngC.Size = new System.Drawing.Size(120, 22);
            this.nudIngC.TabIndex = 10;
            this.nudIngC.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIngC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nudInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.NumericUpDown nudSaldo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIngresoC;
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.NumericUpDown nudNCuenta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.NumericUpDown nudIngC;
    }
}

