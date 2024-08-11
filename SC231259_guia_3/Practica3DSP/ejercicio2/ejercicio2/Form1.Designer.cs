namespace ejercicio2
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
            this.gbInformacon = new System.Windows.Forms.GroupBox();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lbedad = new System.Windows.Forms.Label();
            this.Lbdig_info = new System.Windows.Forms.Label();
            this.Lbtipo_info = new System.Windows.Forms.Label();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gbInformacon.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.gbMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformacon
            // 
            this.gbInformacon.Controls.Add(this.cbtipoinfo);
            this.gbInformacon.Controls.Add(this.txtEdad);
            this.gbInformacon.Controls.Add(this.txtInfo);
            this.gbInformacon.Controls.Add(this.lbedad);
            this.gbInformacon.Controls.Add(this.Lbdig_info);
            this.gbInformacon.Controls.Add(this.Lbtipo_info);
            this.gbInformacon.Location = new System.Drawing.Point(38, 68);
            this.gbInformacon.Name = "gbInformacon";
            this.gbInformacon.Size = new System.Drawing.Size(329, 132);
            this.gbInformacon.TabIndex = 0;
            this.gbInformacon.TabStop = false;
            this.gbInformacon.Text = "Informacion";
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(141, 30);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(121, 21);
            this.cbtipoinfo.TabIndex = 6;
            this.cbtipoinfo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(141, 94);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(60, 20);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(141, 61);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(122, 20);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfo_KeyPress);
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(24, 99);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad";
            // 
            // Lbdig_info
            // 
            this.Lbdig_info.AutoSize = true;
            this.Lbdig_info.Location = new System.Drawing.Point(24, 64);
            this.Lbdig_info.Name = "Lbdig_info";
            this.Lbdig_info.Size = new System.Drawing.Size(103, 13);
            this.Lbdig_info.TabIndex = 1;
            this.Lbdig_info.Text = "Digite la Informacion";
            // 
            // Lbtipo_info
            // 
            this.Lbtipo_info.AutoSize = true;
            this.Lbtipo_info.Location = new System.Drawing.Point(24, 30);
            this.Lbtipo_info.Name = "Lbtipo_info";
            this.Lbtipo_info.Size = new System.Drawing.Size(101, 13);
            this.Lbtipo_info.TabIndex = 0;
            this.Lbtipo_info.Text = "Tipo de Informacion";
            this.Lbtipo_info.Click += new System.EventHandler(this.Lbtipo_info_Click);
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.dgdatos);
            this.gbMatriz.Location = new System.Drawing.Point(98, 221);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(572, 168);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(17, 19);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(537, 133);
            this.dgdatos.TabIndex = 0;
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.btSalir);
            this.gbMantenimiento.Controls.Add(this.btPromedio);
            this.gbMantenimiento.Controls.Add(this.btLimpiar);
            this.gbMantenimiento.Controls.Add(this.btMostrar);
            this.gbMantenimiento.Controls.Add(this.btAgregar);
            this.gbMantenimiento.Location = new System.Drawing.Point(388, 69);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(333, 131);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(86, 93);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = " Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.BackColor = System.Drawing.Color.Lime;
            this.btPromedio.Location = new System.Drawing.Point(189, 57);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(75, 23);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = false;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.SandyBrown;
            this.btLimpiar.Location = new System.Drawing.Point(86, 58);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(84, 23);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar Matriz";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.BackColor = System.Drawing.Color.Moccasin;
            this.btMostrar.Location = new System.Drawing.Point(189, 29);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(93, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = false;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.Red;
            this.btAgregar.Location = new System.Drawing.Point(86, 29);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacon);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.gbInformacon.ResumeLayout(false);
            this.gbInformacon.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.gbMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacon;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label Lbdig_info;
        private System.Windows.Forms.Label Lbtipo_info;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAgregar;
    }
}

