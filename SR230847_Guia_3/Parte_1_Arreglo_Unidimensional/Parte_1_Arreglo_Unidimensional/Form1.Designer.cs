namespace Parte_1_Arreglo_Unidimensional
{
    partial class Form1
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
            lblnumero = new Label();
            txtNum = new TextBox();
            btnAgregar = new Button();
            btnOrdenar = new Button();
            lstdesorden = new ListBox();
            lstOrdenada = new ListBox();
            SuspendLayout();
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(21, 15);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(99, 15);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Ingresar Numero:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(126, 12);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(118, 23);
            txtNum.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Lime;
            btnAgregar.Location = new Point(285, 15);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Yellow;
            btnOrdenar.Location = new Point(285, 63);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(75, 23);
            btnOrdenar.TabIndex = 3;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lstdesorden
            // 
            lstdesorden.FormattingEnabled = true;
            lstdesorden.ItemHeight = 15;
            lstdesorden.Location = new Point(12, 126);
            lstdesorden.Name = "lstdesorden";
            lstdesorden.Size = new Size(146, 154);
            lstdesorden.TabIndex = 4;
            // 
            // lstOrdenada
            // 
            lstOrdenada.FormattingEnabled = true;
            lstOrdenada.ItemHeight = 15;
            lstOrdenada.Location = new Point(214, 126);
            lstOrdenada.Name = "lstOrdenada";
            lstOrdenada.Size = new Size(146, 154);
            lstOrdenada.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(388, 287);
            Controls.Add(lstOrdenada);
            Controls.Add(lstdesorden);
            Controls.Add(btnOrdenar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNum);
            Controls.Add(lblnumero);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Ordenar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnumero;
        private TextBox txtNum;
        private Button btnAgregar;
        private Button btnOrdenar;
        private ListBox lstdesorden;
        private ListBox lstOrdenada;
    }
}
