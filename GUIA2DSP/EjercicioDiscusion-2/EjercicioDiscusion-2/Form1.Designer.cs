namespace EjercicioDiscusion_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblDesviacionTipica = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Número1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(147, 44);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(54, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(243, 44);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(54, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(337, 44);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(54, 20);
            this.txtNum3.TabIndex = 2;
            // 
            // txtNum4
            // 
            this.txtNum4.Location = new System.Drawing.Point(433, 44);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(54, 20);
            this.txtNum4.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(281, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(236, 155);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(16, 13);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "...";
            // 
            // lblDesviacionTipica
            // 
            this.lblDesviacionTipica.AutoSize = true;
            this.lblDesviacionTipica.Location = new System.Drawing.Point(331, 155);
            this.lblDesviacionTipica.Name = "lblDesviacionTipica";
            this.lblDesviacionTipica.Size = new System.Drawing.Size(16, 13);
            this.lblDesviacionTipica.TabIndex = 6;
            this.lblDesviacionTipica.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número1,
            this.Número2,
            this.Número3,
            this.Número4});
            this.dataGridView1.Location = new System.Drawing.Point(110, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 116);
            this.dataGridView1.TabIndex = 7;
            // 
            // Número1
            // 
            this.Número1.HeaderText = "Número1";
            this.Número1.Name = "Número1";
            // 
            // Número2
            // 
            this.Número2.HeaderText = "Número2";
            this.Número2.Name = "Número2";
            // 
            // Número3
            // 
            this.Número3.HeaderText = "Número3";
            this.Número3.Name = "Número3";
            // 
            // Número4
            // 
            this.Número4.HeaderText = "Número4";
            this.Número4.Name = "Número4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 79);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDesviacionTipica);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblDesviacionTipica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

