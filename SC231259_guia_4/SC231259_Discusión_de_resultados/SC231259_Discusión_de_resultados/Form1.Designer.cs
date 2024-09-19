namespace SC231259_Discusión_de_resultados
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCrear_Click = new System.Windows.Forms.Button();
            this.btnInsertar_Click = new System.Windows.Forms.Button();
            this.btnRemover_Click = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(57, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 251);
            this.listBox1.TabIndex = 0;
            // 
            // btnCrear_Click
            // 
            this.btnCrear_Click.Location = new System.Drawing.Point(356, 108);
            this.btnCrear_Click.Name = "btnCrear_Click";
            this.btnCrear_Click.Size = new System.Drawing.Size(122, 41);
            this.btnCrear_Click.TabIndex = 1;
            this.btnCrear_Click.Text = "Crear lista vacía";
            this.btnCrear_Click.UseVisualStyleBackColor = true;
            this.btnCrear_Click.Click += new System.EventHandler(this.btnCrear_Click_Click);
            // 
            // btnInsertar_Click
            // 
            this.btnInsertar_Click.Location = new System.Drawing.Point(356, 164);
            this.btnInsertar_Click.Name = "btnInsertar_Click";
            this.btnInsertar_Click.Size = new System.Drawing.Size(122, 39);
            this.btnInsertar_Click.TabIndex = 2;
            this.btnInsertar_Click.Text = "Insertar elemento";
            this.btnInsertar_Click.UseVisualStyleBackColor = true;
            this.btnInsertar_Click.Click += new System.EventHandler(this.btnInsertar_Click_Click);
            // 
            // btnRemover_Click
            // 
            this.btnRemover_Click.Location = new System.Drawing.Point(356, 217);
            this.btnRemover_Click.Name = "btnRemover_Click";
            this.btnRemover_Click.Size = new System.Drawing.Size(122, 43);
            this.btnRemover_Click.TabIndex = 3;
            this.btnRemover_Click.Text = "Remover elemento";
            this.btnRemover_Click.UseVisualStyleBackColor = true;
            this.btnRemover_Click.Click += new System.EventHandler(this.btnRemover_Click_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(158, 75);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(95, 20);
            this.txtElemento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese un número:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(356, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ir a Ejercicio 2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnRemover_Click);
            this.Controls.Add(this.btnInsertar_Click);
            this.Controls.Add(this.btnCrear_Click);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCrear_Click;
        private System.Windows.Forms.Button btnInsertar_Click;
        private System.Windows.Forms.Button btnRemover_Click;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

