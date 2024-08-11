namespace ejercicio3
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
            this.lblpalabra = new System.Windows.Forms.Label();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.txtsignificado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(437, 133);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(43, 13);
            this.lblpalabra.TabIndex = 0;
            this.lblpalabra.Text = "Palabra";
            this.lblpalabra.Click += new System.EventHandler(this.lblpalabra_Click);
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(199, 158);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(123, 95);
            this.lstPalabras.TabIndex = 1;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // txtsignificado
            // 
            this.txtsignificado.Enabled = false;
            this.txtsignificado.Location = new System.Drawing.Point(333, 158);
            this.txtsignificado.Multiline = true;
            this.txtsignificado.Name = "txtsignificado";
            this.txtsignificado.Size = new System.Drawing.Size(253, 95);
            this.txtsignificado.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(486, 275);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtsignificado);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.lblpalabra);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.TextBox txtsignificado;
        private System.Windows.Forms.Button btnSalir;
    }
}

