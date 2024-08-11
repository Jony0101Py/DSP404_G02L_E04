namespace EjerciciosDiscusiónDeResultados
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelDimension = new System.Windows.Forms.Label();
            this.textBoxDimension = new System.Windows.Forms.TextBox();
            this.buttonGenerateMatrix = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonTranspose = new System.Windows.Forms.Button();
            this.dataGridViewTranspose = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranspose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDimension
            // 
            this.labelDimension.AutoSize = true;
            this.labelDimension.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimension.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDimension.Location = new System.Drawing.Point(263, 29);
            this.labelDimension.Name = "labelDimension";
            this.labelDimension.Size = new System.Drawing.Size(278, 20);
            this.labelDimension.TabIndex = 0;
            this.labelDimension.Text = "Ingrese la dimensión de la matriz:";
            this.labelDimension.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDimension
            // 
            this.textBoxDimension.Location = new System.Drawing.Point(209, 62);
            this.textBoxDimension.Name = "textBoxDimension";
            this.textBoxDimension.Size = new System.Drawing.Size(386, 20);
            this.textBoxDimension.TabIndex = 1;
            // 
            // buttonGenerateMatrix
            // 
            this.buttonGenerateMatrix.Location = new System.Drawing.Point(209, 116);
            this.buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            this.buttonGenerateMatrix.Size = new System.Drawing.Size(118, 23);
            this.buttonGenerateMatrix.TabIndex = 2;
            this.buttonGenerateMatrix.Text = "Generar Matriz";
            this.buttonGenerateMatrix.UseVisualStyleBackColor = true;
            this.buttonGenerateMatrix.Click += new System.EventHandler(this.buttonGenerateMatrix_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(144, 157);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMatrix.TabIndex = 3;
            // 
            // buttonTranspose
            // 
            this.buttonTranspose.Location = new System.Drawing.Point(475, 115);
            this.buttonTranspose.Name = "buttonTranspose";
            this.buttonTranspose.Size = new System.Drawing.Size(120, 23);
            this.buttonTranspose.TabIndex = 4;
            this.buttonTranspose.Text = "Calcular Transpuesta";
            this.buttonTranspose.UseVisualStyleBackColor = true;
            this.buttonTranspose.Click += new System.EventHandler(this.buttonTranspose_Click);
            // 
            // dataGridViewTranspose
            // 
            this.dataGridViewTranspose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTranspose.Location = new System.Drawing.Point(411, 157);
            this.dataGridViewTranspose.Name = "dataGridViewTranspose";
            this.dataGridViewTranspose.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTranspose.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-124, -109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 679);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(363, 341);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridViewTranspose);
            this.Controls.Add(this.buttonTranspose);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.buttonGenerateMatrix);
            this.Controls.Add(this.textBoxDimension);
            this.Controls.Add(this.labelDimension);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTranspose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDimension;
        private System.Windows.Forms.TextBox textBoxDimension;
        private System.Windows.Forms.Button buttonGenerateMatrix;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonTranspose;
        private System.Windows.Forms.DataGridView dataGridViewTranspose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}