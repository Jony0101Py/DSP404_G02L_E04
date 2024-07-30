namespace WindowsFormsApp1
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
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.lbidg_info = new System.Windows.Forms.Label();
            this.lbtipo_info = new System.Windows.Forms.Label();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.gbInformacion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.txtEdad);
            this.gbInformacion.Controls.Add(this.txtinfo);
            this.gbInformacion.Controls.Add(this.cbtipoinfo);
            this.gbInformacion.Controls.Add(this.lbledad);
            this.gbInformacion.Controls.Add(this.lbidg_info);
            this.gbInformacion.Controls.Add(this.lbtipo_info);
            this.gbInformacion.Location = new System.Drawing.Point(27, 53);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(349, 131);
            this.gbInformacion.TabIndex = 0;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Informacion";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(166, 98);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(166, 65);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(100, 22);
            this.txtinfo.TabIndex = 4;
            this.txtinfo.TextChanged += new System.EventHandler(this.txtinfo_TextChanged);
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(166, 31);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(137, 24);
            this.cbtipoinfo.TabIndex = 3;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(20, 101);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(40, 16);
            this.lbledad.TabIndex = 2;
            this.lbledad.Text = "Edad";
            // 
            // lbidg_info
            // 
            this.lbidg_info.AutoSize = true;
            this.lbidg_info.Location = new System.Drawing.Point(20, 65);
            this.lbidg_info.Name = "lbidg_info";
            this.lbidg_info.Size = new System.Drawing.Size(128, 16);
            this.lbidg_info.TabIndex = 1;
            this.lbidg_info.Text = "Digite la Informacion";
            // 
            // lbtipo_info
            // 
            this.lbtipo_info.AutoSize = true;
            this.lbtipo_info.Location = new System.Drawing.Point(20, 31);
            this.lbtipo_info.Name = "lbtipo_info";
            this.lbtipo_info.Size = new System.Drawing.Size(126, 16);
            this.lbtipo_info.TabIndex = 0;
            this.lbtipo_info.Text = "Tipo de Informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.button5);
            this.gbMatriz.Controls.Add(this.btPromedio);
            this.gbMatriz.Controls.Add(this.btLimpiar);
            this.gbMatriz.Controls.Add(this.btMostrar);
            this.gbMatriz.Controls.Add(this.btAgregar);
            this.gbMatriz.Location = new System.Drawing.Point(408, 53);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(259, 131);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.Location = new System.Drawing.Point(162, 62);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(75, 23);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = true;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(31, 65);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(125, 23);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar Matriz";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(126, 21);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(111, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(31, 21);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.dgDatos);
            this.gbMantenimiento.Location = new System.Drawing.Point(27, 225);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(640, 190);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimiento";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(23, 21);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersWidth = 51;
            this.dgDatos.RowTemplate.Height = 24;
            this.dgDatos.Size = new System.Drawing.Size(595, 150);
            this.dgDatos.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacion);
            this.Name = "Form2";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbidg_info;
        private System.Windows.Forms.Label lbtipo_info;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.DataGridView dgDatos;
    }
}