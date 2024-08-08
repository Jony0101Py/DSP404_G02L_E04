namespace WindowsFormsApp1
{
    partial class Form3
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
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.lblpalabra = new System.Windows.Forms.Label();
            this.txtsignificado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.ItemHeight = 16;
            this.lstPalabras.Location = new System.Drawing.Point(168, 115);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(120, 196);
            this.lstPalabras.TabIndex = 0;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // lblpalabra
            // 
            this.lblpalabra.AutoSize = true;
            this.lblpalabra.Location = new System.Drawing.Point(341, 115);
            this.lblpalabra.Name = "lblpalabra";
            this.lblpalabra.Size = new System.Drawing.Size(55, 16);
            this.lblpalabra.TabIndex = 1;
            this.lblpalabra.Text = "Palabra";
            // 
            // txtsignificado
            // 
            this.txtsignificado.Location = new System.Drawing.Point(344, 169);
            this.txtsignificado.Name = "txtsignificado";
            this.txtsignificado.Size = new System.Drawing.Size(100, 22);
            this.txtsignificado.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(205, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 26);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtsignificado);
            this.Controls.Add(this.lblpalabra);
            this.Controls.Add(this.lstPalabras);
            this.Name = "Form3";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label lblpalabra;
        private System.Windows.Forms.TextBox txtsignificado;
        private System.Windows.Forms.Button btnSalir;
    }
}