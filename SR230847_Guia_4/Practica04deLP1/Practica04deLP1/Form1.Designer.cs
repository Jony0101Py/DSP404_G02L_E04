namespace Practica04deLP1
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
            lbltema = new Label();
            nupBase = new NumericUpDown();
            btnCalculo = new Button();
            btnSalir = new Button();
            grbResult = new GroupBox();
            lstTabla2 = new ListBox();
            lstTabla1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nupBase).BeginInit();
            grbResult.SuspendLayout();
            SuspendLayout();
            // 
            // lbltema
            // 
            lbltema.AutoSize = true;
            lbltema.Location = new Point(18, 24);
            lbltema.Name = "lbltema";
            lbltema.Size = new Size(90, 15);
            lbltema.TabIndex = 0;
            lbltema.Text = "Ingrese numero";
            // 
            // nupBase
            // 
            nupBase.DecimalPlaces = 1;
            nupBase.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupBase.Location = new Point(15, 45);
            nupBase.Maximum = new decimal(new int[] { 69, 0, 0, 65536 });
            nupBase.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupBase.Name = "nupBase";
            nupBase.Size = new Size(120, 23);
            nupBase.TabIndex = 1;
            nupBase.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(18, 113);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(117, 27);
            btnCalculo.TabIndex = 2;
            btnCalculo.Text = "Ver tablas";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(18, 177);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Finalizar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // grbResult
            // 
            grbResult.Controls.Add(lstTabla2);
            grbResult.Controls.Add(lstTabla1);
            grbResult.Location = new Point(188, 24);
            grbResult.Name = "grbResult";
            grbResult.Size = new Size(297, 310);
            grbResult.TabIndex = 4;
            grbResult.TabStop = false;
            grbResult.Text = "Resultados";
            // 
            // lstTabla2
            // 
            lstTabla2.FormattingEnabled = true;
            lstTabla2.ItemHeight = 15;
            lstTabla2.Location = new Point(158, 23);
            lstTabla2.Name = "lstTabla2";
            lstTabla2.Size = new Size(133, 274);
            lstTabla2.TabIndex = 1;
            // 
            // lstTabla1
            // 
            lstTabla1.FormattingEnabled = true;
            lstTabla1.ItemHeight = 15;
            lstTabla1.Location = new Point(10, 23);
            lstTabla1.Name = "lstTabla1";
            lstTabla1.Size = new Size(133, 274);
            lstTabla1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(497, 384);
            Controls.Add(grbResult);
            Controls.Add(btnSalir);
            Controls.Add(btnCalculo);
            Controls.Add(nupBase);
            Controls.Add(lbltema);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupBase).EndInit();
            grbResult.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltema;
        private NumericUpDown nupBase;
        private Button btnCalculo;
        private Button btnSalir;
        private GroupBox grbResult;
        private ListBox lstTabla2;
        private ListBox lstTabla1;
    }
}
