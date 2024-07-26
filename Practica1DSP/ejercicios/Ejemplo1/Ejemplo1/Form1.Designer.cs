namespace Ejemplo1
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
            this.btnContar = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirForm2 = new System.Windows.Forms.Button();
            this.btnAbrirForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(202, 73);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 0;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(513, 73);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(92, 23);
            this.btnReinicio.TabIndex = 1;
            this.btnReinicio.Text = "Reiniciar conteo";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(513, 216);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(93, 23);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Salir programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAbrirForm2
            // 
            this.btnAbrirForm2.Location = new System.Drawing.Point(513, 245);
            this.btnAbrirForm2.Name = "btnAbrirForm2";
            this.btnAbrirForm2.Size = new System.Drawing.Size(92, 23);
            this.btnAbrirForm2.TabIndex = 4;
            this.btnAbrirForm2.Text = "Form 2";
            this.btnAbrirForm2.UseVisualStyleBackColor = true;
            this.btnAbrirForm2.Click += new System.EventHandler(this.btnAbrirForm2_Click);
            // 
            // btnAbrirForm3
            // 
            this.btnAbrirForm3.Location = new System.Drawing.Point(513, 274);
            this.btnAbrirForm3.Name = "btnAbrirForm3";
            this.btnAbrirForm3.Size = new System.Drawing.Size(92, 23);
            this.btnAbrirForm3.TabIndex = 5;
            this.btnAbrirForm3.Text = "Form 3";
            this.btnAbrirForm3.UseVisualStyleBackColor = true;
            this.btnAbrirForm3.Click += new System.EventHandler(this.btnAbrirForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirForm3);
            this.Controls.Add(this.btnAbrirForm2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnContar);
            this.Name = "Form1";
            this.Text = "Pruebas de ámbito de variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrirForm2;
        private System.Windows.Forms.Button btnAbrirForm3;
    }
}

