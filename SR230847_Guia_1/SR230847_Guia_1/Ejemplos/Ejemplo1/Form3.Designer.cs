namespace Ejemplo1
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
            this.lblApe1 = new System.Windows.Forms.Label();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCum = new System.Windows.Forms.Label();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCum = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Location = new System.Drawing.Point(23, 31);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(65, 13);
            this.lblApe1.TabIndex = 0;
            this.lblApe1.Text = "1er Apellido:";
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Location = new System.Drawing.Point(23, 72);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(68, 13);
            this.lblApe2.TabIndex = 1;
            this.lblApe2.Text = "2do Apellido:";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(23, 114);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nombres";
            // 
            // lblCum
            // 
            this.lblCum.AutoSize = true;
            this.lblCum.Location = new System.Drawing.Point(23, 146);
            this.lblCum.Name = "lblCum";
            this.lblCum.Size = new System.Drawing.Size(73, 13);
            this.lblCum.TabIndex = 3;
            this.lblCum.Text = "Valor de CUM";
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(95, 31);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(362, 20);
            this.txtApe1.TabIndex = 4;
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(95, 72);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(362, 20);
            this.txtApe2.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(95, 111);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(362, 20);
            this.txtNom.TabIndex = 6;
            // 
            // txtCum
            // 
            this.txtCum.Location = new System.Drawing.Point(102, 146);
            this.txtCum.Name = "txtCum";
            this.txtCum.Size = new System.Drawing.Size(355, 20);
            this.txtCum.TabIndex = 7;
            this.txtCum.Text = "0.0";
            // 
            // txtResul
            // 
            this.txtResul.Enabled = false;
            this.txtResul.Location = new System.Drawing.Point(26, 181);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(431, 20);
            this.txtResul.TabIndex = 8;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(61, 235);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(113, 34);
            this.btnAnalisis.TabIndex = 9;
            this.btnAnalisis.Text = "Calcular UV";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(306, 235);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(113, 34);
            this.btnFin.TabIndex = 10;
            this.btnFin.Text = "Salir del Programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 297);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtCum);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.lblCum);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.lblApe1);
            this.Name = "Form3";
            this.Text = "Calculo de UV a cursar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCum;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCum;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}