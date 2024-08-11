namespace EjercicioG2_4
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
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.lblDivisaIni = new System.Windows.Forms.Label();
            this.cboDivisaIni = new System.Windows.Forms.ComboBox();
            this.lblDivisaFin = new System.Windows.Forms.Label();
            this.cboDivisaFin = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblConversion = new System.Windows.Forms.Label();
            this.lblResPantalla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(38, 27);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(64, 16);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Cantidad:";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(190, 27);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(205, 22);
            this.txtIngreso.TabIndex = 1;
            // 
            // lblDivisaIni
            // 
            this.lblDivisaIni.AutoSize = true;
            this.lblDivisaIni.Location = new System.Drawing.Point(35, 75);
            this.lblDivisaIni.Name = "lblDivisaIni";
            this.lblDivisaIni.Size = new System.Drawing.Size(104, 16);
            this.lblDivisaIni.TabIndex = 2;
            this.lblDivisaIni.Text = "Desde la divisa:";
            // 
            // cboDivisaIni
            // 
            this.cboDivisaIni.FormattingEnabled = true;
            this.cboDivisaIni.Items.AddRange(new object[] {
            "Dolar Estadounidense",
            "Euro",
            "Yen Japonés",
            "Libra Esterlina",
            "Franco Suizo"});
            this.cboDivisaIni.Location = new System.Drawing.Point(190, 75);
            this.cboDivisaIni.Name = "cboDivisaIni";
            this.cboDivisaIni.Size = new System.Drawing.Size(205, 24);
            this.cboDivisaIni.TabIndex = 3;
            this.cboDivisaIni.Text = "Selecciona una Divisa";
            this.cboDivisaIni.SelectedIndexChanged += new System.EventHandler(this.cboDivisaIni_SelectedIndexChanged);
            // 
            // lblDivisaFin
            // 
            this.lblDivisaFin.AutoSize = true;
            this.lblDivisaFin.Location = new System.Drawing.Point(38, 119);
            this.lblDivisaFin.Name = "lblDivisaFin";
            this.lblDivisaFin.Size = new System.Drawing.Size(72, 16);
            this.lblDivisaFin.TabIndex = 4;
            this.lblDivisaFin.Text = "A la divisa:";
            // 
            // cboDivisaFin
            // 
            this.cboDivisaFin.FormattingEnabled = true;
            this.cboDivisaFin.Items.AddRange(new object[] {
            "Dolar Estadounidense",
            "Euro",
            "Yen Japonés",
            "Libra Esterlina",
            "Franco Suizo"});
            this.cboDivisaFin.Location = new System.Drawing.Point(190, 119);
            this.cboDivisaFin.Name = "cboDivisaFin";
            this.cboDivisaFin.Size = new System.Drawing.Size(205, 24);
            this.cboDivisaFin.TabIndex = 5;
            this.cboDivisaFin.Text = "Selecciona una Divisa";
            this.cboDivisaFin.SelectedIndexChanged += new System.EventHandler(this.cboDivisaFin_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(274, 173);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(121, 32);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(118, 173);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(121, 32);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nueva cantidad";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(274, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblConversion
            // 
            this.lblConversion.AutoSize = true;
            this.lblConversion.Location = new System.Drawing.Point(38, 246);
            this.lblConversion.Name = "lblConversion";
            this.lblConversion.Size = new System.Drawing.Size(72, 16);
            this.lblConversion.TabIndex = 9;
            this.lblConversion.Text = "Resultado:";
            // 
            // lblResPantalla
            // 
            this.lblResPantalla.AutoSize = true;
            this.lblResPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResPantalla.Location = new System.Drawing.Point(190, 246);
            this.lblResPantalla.Name = "lblResPantalla";
            this.lblResPantalla.Size = new System.Drawing.Size(0, 16);
            this.lblResPantalla.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.lblResPantalla);
            this.Controls.Add(this.lblConversion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboDivisaFin);
            this.Controls.Add(this.lblDivisaFin);
            this.Controls.Add(this.cboDivisaIni);
            this.Controls.Add(this.lblDivisaIni);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Name = "Form1";
            this.Text = "Conversor de Monedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label lblDivisaIni;
        private System.Windows.Forms.ComboBox cboDivisaIni;
        private System.Windows.Forms.Label lblDivisaFin;
        private System.Windows.Forms.ComboBox cboDivisaFin;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblConversion;
        private System.Windows.Forms.Label lblResPantalla;
    }
}

