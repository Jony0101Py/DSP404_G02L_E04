namespace EjercicioG2_3
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblMayorNeg = new System.Windows.Forms.Label();
            this.lblNPositivos = new System.Windows.Forms.Label();
            this.txtMayorNeg = new System.Windows.Forms.TextBox();
            this.txtNPositivos = new System.Windows.Forms.TextBox();
            this.lblPromNeg = new System.Windows.Forms.Label();
            this.txtPromNeg = new System.Windows.Forms.TextBox();
            this.lblPorPos = new System.Windows.Forms.Label();
            this.lblPorNeg = new System.Windows.Forms.Label();
            this.txtPorPos = new System.Windows.Forms.TextBox();
            this.txtPorNeg = new System.Windows.Forms.TextBox();
            this.txtPorCero = new System.Windows.Forms.TextBox();
            this.lblPorCero = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(13, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(210, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese un número (Entre 45 y -40):";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(395, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // lblMayorNeg
            // 
            this.lblMayorNeg.AutoSize = true;
            this.lblMayorNeg.Location = new System.Drawing.Point(16, 112);
            this.lblMayorNeg.Name = "lblMayorNeg";
            this.lblMayorNeg.Size = new System.Drawing.Size(151, 16);
            this.lblMayorNeg.TabIndex = 2;
            this.lblMayorNeg.Text = "Mayor número negativo:";
            // 
            // lblNPositivos
            // 
            this.lblNPositivos.AutoSize = true;
            this.lblNPositivos.Location = new System.Drawing.Point(16, 171);
            this.lblNPositivos.Name = "lblNPositivos";
            this.lblNPositivos.Size = new System.Drawing.Size(101, 16);
            this.lblNPositivos.TabIndex = 4;
            this.lblNPositivos.Text = "N° de Positivos:";
            this.lblNPositivos.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMayorNeg
            // 
            this.txtMayorNeg.Location = new System.Drawing.Point(395, 112);
            this.txtMayorNeg.Name = "txtMayorNeg";
            this.txtMayorNeg.Size = new System.Drawing.Size(100, 22);
            this.txtMayorNeg.TabIndex = 5;
            // 
            // txtNPositivos
            // 
            this.txtNPositivos.Location = new System.Drawing.Point(395, 171);
            this.txtNPositivos.Name = "txtNPositivos";
            this.txtNPositivos.Size = new System.Drawing.Size(100, 22);
            this.txtNPositivos.TabIndex = 6;
            // 
            // lblPromNeg
            // 
            this.lblPromNeg.AutoSize = true;
            this.lblPromNeg.Location = new System.Drawing.Point(16, 221);
            this.lblPromNeg.Name = "lblPromNeg";
            this.lblPromNeg.Size = new System.Drawing.Size(153, 16);
            this.lblPromNeg.TabIndex = 7;
            this.lblPromNeg.Text = "Promedio de Negativos:";
            this.lblPromNeg.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPromNeg
            // 
            this.txtPromNeg.Location = new System.Drawing.Point(395, 221);
            this.txtPromNeg.Name = "txtPromNeg";
            this.txtPromNeg.Size = new System.Drawing.Size(100, 22);
            this.txtPromNeg.TabIndex = 8;
            // 
            // lblPorPos
            // 
            this.lblPorPos.AutoSize = true;
            this.lblPorPos.Location = new System.Drawing.Point(16, 273);
            this.lblPorPos.Name = "lblPorPos";
            this.lblPorPos.Size = new System.Drawing.Size(99, 16);
            this.lblPorPos.TabIndex = 9;
            this.lblPorPos.Text = "% de Positivos:";
            // 
            // lblPorNeg
            // 
            this.lblPorNeg.AutoSize = true;
            this.lblPorNeg.Location = new System.Drawing.Point(16, 328);
            this.lblPorNeg.Name = "lblPorNeg";
            this.lblPorNeg.Size = new System.Drawing.Size(106, 16);
            this.lblPorNeg.TabIndex = 10;
            this.lblPorNeg.Text = "% de Negativos:";
            // 
            // txtPorPos
            // 
            this.txtPorPos.Location = new System.Drawing.Point(395, 273);
            this.txtPorPos.Name = "txtPorPos";
            this.txtPorPos.Size = new System.Drawing.Size(100, 22);
            this.txtPorPos.TabIndex = 11;
            // 
            // txtPorNeg
            // 
            this.txtPorNeg.Location = new System.Drawing.Point(395, 328);
            this.txtPorNeg.Name = "txtPorNeg";
            this.txtPorNeg.Size = new System.Drawing.Size(100, 22);
            this.txtPorNeg.TabIndex = 12;
            // 
            // txtPorCero
            // 
            this.txtPorCero.Location = new System.Drawing.Point(395, 373);
            this.txtPorCero.Name = "txtPorCero";
            this.txtPorCero.Size = new System.Drawing.Size(100, 22);
            this.txtPorCero.TabIndex = 13;
            // 
            // lblPorCero
            // 
            this.lblPorCero.AutoSize = true;
            this.lblPorCero.Location = new System.Drawing.Point(19, 378);
            this.lblPorCero.Name = "lblPorCero";
            this.lblPorCero.Size = new System.Drawing.Size(51, 16);
            this.lblPorCero.TabIndex = 14;
            this.lblPorCero.Text = "% de 0:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(395, 453);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 28);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(16, 54);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 16;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(395, 54);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 32);
            this.btnIngresar.TabIndex = 17;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 529);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPorCero);
            this.Controls.Add(this.txtPorCero);
            this.Controls.Add(this.txtPorNeg);
            this.Controls.Add(this.txtPorPos);
            this.Controls.Add(this.lblPorNeg);
            this.Controls.Add(this.lblPorPos);
            this.Controls.Add(this.txtPromNeg);
            this.Controls.Add(this.lblPromNeg);
            this.Controls.Add(this.txtNPositivos);
            this.Controls.Add(this.txtMayorNeg);
            this.Controls.Add(this.lblNPositivos);
            this.Controls.Add(this.lblMayorNeg);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblMayorNeg;
        private System.Windows.Forms.Label lblNPositivos;
        private System.Windows.Forms.TextBox txtMayorNeg;
        private System.Windows.Forms.TextBox txtNPositivos;
        private System.Windows.Forms.Label lblPromNeg;
        private System.Windows.Forms.TextBox txtPromNeg;
        private System.Windows.Forms.Label lblPorPos;
        private System.Windows.Forms.Label lblPorNeg;
        private System.Windows.Forms.TextBox txtPorPos;
        private System.Windows.Forms.TextBox txtPorNeg;
        private System.Windows.Forms.TextBox txtPorCero;
        private System.Windows.Forms.Label lblPorCero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIngresar;
    }
}

