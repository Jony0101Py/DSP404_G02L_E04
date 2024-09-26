namespace Practica04deLP1
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
            this.lbltema = new System.Windows.Forms.Label();
            this.nupBase = new System.Windows.Forms.DomainUpDown();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.nupBasse = new System.Windows.Forms.NumericUpDown();
            this.grbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBasse)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Location = new System.Drawing.Point(31, 68);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(121, 20);
            this.lbltema.TabIndex = 0;
            this.lbltema.Text = "Ingrese numero";
            // 
            // nupBase
            // 
            this.nupBase.Location = new System.Drawing.Point(294, 422);
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(120, 26);
            this.nupBase.TabIndex = 1;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(35, 191);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(190, 57);
            this.btnCalculo.TabIndex = 2;
            this.btnCalculo.Text = "ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(35, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(190, 57);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Location = new System.Drawing.Point(294, 38);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(380, 378);
            this.grbResult.TabIndex = 4;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.ItemHeight = 20;
            this.lstTabla1.Location = new System.Drawing.Point(20, 30);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(164, 324);
            this.lstTabla1.TabIndex = 0;
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.ItemHeight = 20;
            this.lstTabla2.Location = new System.Drawing.Point(190, 30);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(172, 324);
            this.lstTabla2.TabIndex = 1;
            // 
            // nupBasse
            // 
            this.nupBasse.Location = new System.Drawing.Point(35, 104);
            this.nupBasse.MaximumSize = new System.Drawing.Size(12, 0);
            this.nupBasse.MinimumSize = new System.Drawing.Size(90, 0);
            this.nupBasse.Name = "nupBasse";
            this.nupBasse.Size = new System.Drawing.Size(90, 26);
            this.nupBasse.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nupBasse);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.lbltema);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupBasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.DomainUpDown nupBase;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.ListBox lstTabla1;
        private System.Windows.Forms.NumericUpDown nupBasse;
    }
}

