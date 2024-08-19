namespace WindowsFormsApp1
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.lstdesorden = new System.Windows.Forms.ListBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(128, 57);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(107, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingresar Numero";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(267, 51);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(511, 47);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 30);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(511, 93);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btOrdenar.TabIndex = 3;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // lstdesorden
            // 
            this.lstdesorden.FormattingEnabled = true;
            this.lstdesorden.ItemHeight = 16;
            this.lstdesorden.Location = new System.Drawing.Point(131, 155);
            this.lstdesorden.Name = "lstdesorden";
            this.lstdesorden.Size = new System.Drawing.Size(196, 116);
            this.lstdesorden.TabIndex = 4;
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.ItemHeight = 16;
            this.lstOrdenada.Location = new System.Drawing.Point(401, 155);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(185, 116);
            this.lstOrdenada.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.lstdesorden);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Ordenar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.ListBox lstdesorden;
        private System.Windows.Forms.ListBox lstOrdenada;
    }
}

