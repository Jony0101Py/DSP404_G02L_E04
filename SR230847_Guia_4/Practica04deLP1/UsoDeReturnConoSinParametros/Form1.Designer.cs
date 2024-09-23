namespace UsoDeReturnConoSinParametros
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtpwd = new TextBox();
            txtusuario = new TextBox();
            btnAceptar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpwd);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Location = new Point(90, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Private";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txtpwd
            // 
            txtpwd.Location = new Point(145, 51);
            txtpwd.Name = "txtpwd";
            txtpwd.Size = new Size(124, 23);
            txtpwd.TabIndex = 1;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(145, 22);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(124, 23);
            txtusuario.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkGray;
            btnAceptar.Location = new Point(188, 309);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.waos;
            pictureBox1.Location = new Point(124, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 175);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 354);
            Controls.Add(pictureBox1);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Login";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtpwd;
        private TextBox txtusuario;
        private Button btnAceptar;
        private PictureBox pictureBox1;
    }
}
