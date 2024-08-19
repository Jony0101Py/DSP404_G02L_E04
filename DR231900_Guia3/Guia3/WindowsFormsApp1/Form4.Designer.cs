namespace WindowsFormsApp1
{
    partial class ListaDeNombres
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.btnAñadirNombre = new System.Windows.Forms.Button();
            this.btnBorrarNombre = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(126, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 16;
            this.lstNombres.Location = new System.Drawing.Point(126, 112);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(120, 180);
            this.lstNombres.TabIndex = 1;
            // 
            // btnAñadirNombre
            // 
            this.btnAñadirNombre.Location = new System.Drawing.Point(349, 53);
            this.btnAñadirNombre.Name = "btnAñadirNombre";
            this.btnAñadirNombre.Size = new System.Drawing.Size(123, 23);
            this.btnAñadirNombre.TabIndex = 2;
            this.btnAñadirNombre.Text = "Añadir Nombre";
            this.btnAñadirNombre.UseVisualStyleBackColor = true;
            this.btnAñadirNombre.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBorrarNombre
            // 
            this.btnBorrarNombre.Location = new System.Drawing.Point(494, 53);
            this.btnBorrarNombre.Name = "btnBorrarNombre";
            this.btnBorrarNombre.Size = new System.Drawing.Size(114, 23);
            this.btnBorrarNombre.TabIndex = 3;
            this.btnBorrarNombre.Text = "Borrar Nombre";
            this.btnBorrarNombre.UseVisualStyleBackColor = true;
            this.btnBorrarNombre.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(349, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Nombre";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModifi_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(494, 92);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ListaDeNombres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrarNombre);
            this.Controls.Add(this.btnAñadirNombre);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtName);
            this.Name = "ListaDeNombres";
            this.Text = "ListaDeNombres";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Button btnAñadirNombre;
        private System.Windows.Forms.Button btnBorrarNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
    }
}