namespace Operaciones_matematicas
{
    partial class Form3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbOperaciones = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResul = new Label();
            nudN1 = new NumericUpDown();
            nudN2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudN1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).BeginInit();
            SuspendLayout();
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(400, 124);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(137, 23);
            cmbOperaciones.TabIndex = 0;
            cmbOperaciones.SelectedIndexChanged += cmbOperaciones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 65);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero Uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 127);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Numero Dos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 65);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 3;
            label3.Text = "Operaciones Disponibles";
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Location = new Point(164, 193);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(38, 15);
            lblResul.TabIndex = 4;
            lblResul.Text = "label4";
            // 
            // nudN1
            // 
            nudN1.Location = new Point(117, 66);
            nudN1.Name = "nudN1";
            nudN1.Size = new Size(148, 23);
            nudN1.TabIndex = 5;
            // 
            // nudN2
            // 
            nudN2.Location = new Point(117, 125);
            nudN2.Name = "nudN2";
            nudN2.Size = new Size(148, 23);
            nudN2.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(569, 266);
            Controls.Add(nudN2);
            Controls.Add(nudN1);
            Controls.Add(lblResul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOperaciones);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)nudN1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperaciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResul;
        private NumericUpDown nudN1;
        private NumericUpDown nudN2;
    }
}
