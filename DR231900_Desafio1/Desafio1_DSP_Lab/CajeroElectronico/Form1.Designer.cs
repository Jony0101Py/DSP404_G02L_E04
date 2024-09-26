namespace CajeroElectronico
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCuentaDestino = new System.Windows.Forms.Label();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCuentaDestino = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnConsultaSaldo = new System.Windows.Forms.Button();
            this.btnRetiroFondos = new System.Windows.Forms.Button();
            this.btnConsignaciones = new System.Windows.Forms.Button();
            this.btnTransferencias = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(197, 34);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(59, 16);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Location = new System.Drawing.Point(99, 112);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(100, 16);
            this.lblNumeroCuenta.TabIndex = 1;
            this.lblNumeroCuenta.Text = "Numero Cuenta";
            this.lblNumeroCuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(99, 153);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(44, 16);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto";
            // 
            // lblCuentaDestino
            // 
            this.lblCuentaDestino.AutoSize = true;
            this.lblCuentaDestino.Location = new System.Drawing.Point(99, 197);
            this.lblCuentaDestino.Name = "lblCuentaDestino";
            this.lblCuentaDestino.Size = new System.Drawing.Size(98, 16);
            this.lblCuentaDestino.TabIndex = 3;
            this.lblCuentaDestino.Text = "Cuenta Destino";
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(324, 109);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(135, 22);
            this.txtNumeroCuenta.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(324, 150);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(135, 22);
            this.txtMonto.TabIndex = 5;
            // 
            // txtCuentaDestino
            // 
            this.txtCuentaDestino.Location = new System.Drawing.Point(324, 191);
            this.txtCuentaDestino.Name = "txtCuentaDestino";
            this.txtCuentaDestino.Size = new System.Drawing.Size(135, 22);
            this.txtCuentaDestino.TabIndex = 6;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(528, 109);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 23);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnConsultaSaldo
            // 
            this.btnConsultaSaldo.Location = new System.Drawing.Point(528, 150);
            this.btnConsultaSaldo.Name = "btnConsultaSaldo";
            this.btnConsultaSaldo.Size = new System.Drawing.Size(114, 23);
            this.btnConsultaSaldo.TabIndex = 8;
            this.btnConsultaSaldo.Text = "Consulta Saldo";
            this.btnConsultaSaldo.UseVisualStyleBackColor = true;
            this.btnConsultaSaldo.Click += new System.EventHandler(this.btnConsultaSaldo_Click);
            // 
            // btnRetiroFondos
            // 
            this.btnRetiroFondos.Location = new System.Drawing.Point(528, 194);
            this.btnRetiroFondos.Name = "btnRetiroFondos";
            this.btnRetiroFondos.Size = new System.Drawing.Size(114, 23);
            this.btnRetiroFondos.TabIndex = 9;
            this.btnRetiroFondos.Text = "Retiro Fondos";
            this.btnRetiroFondos.UseVisualStyleBackColor = true;
            this.btnRetiroFondos.Click += new System.EventHandler(this.btnRetiroFondos_Click);
            // 
            // btnConsignaciones
            // 
            this.btnConsignaciones.Location = new System.Drawing.Point(692, 109);
            this.btnConsignaciones.Name = "btnConsignaciones";
            this.btnConsignaciones.Size = new System.Drawing.Size(112, 23);
            this.btnConsignaciones.TabIndex = 10;
            this.btnConsignaciones.Text = "Consignaciones";
            this.btnConsignaciones.UseVisualStyleBackColor = true;
            this.btnConsignaciones.Click += new System.EventHandler(this.btnConsignaciones_Click);
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Location = new System.Drawing.Point(692, 150);
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.Size = new System.Drawing.Size(112, 23);
            this.btnTransferencias.TabIndex = 11;
            this.btnTransferencias.Text = "Transferencias";
            this.btnTransferencias.UseVisualStyleBackColor = true;
            this.btnTransferencias.Click += new System.EventHandler(this.btnTransferencias_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(692, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 24);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTransferencias);
            this.Controls.Add(this.btnConsignaciones);
            this.Controls.Add(this.btnRetiroFondos);
            this.Controls.Add(this.btnConsultaSaldo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCuentaDestino);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.lblCuentaDestino);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNumeroCuenta);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCuentaDestino;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCuentaDestino;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnConsultaSaldo;
        private System.Windows.Forms.Button btnRetiroFondos;
        private System.Windows.Forms.Button btnConsignaciones;
        private System.Windows.Forms.Button btnTransferencias;
        private System.Windows.Forms.Button btnSalir;
    }
}

