namespace Ejercicio_3
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
            this.txttarea = new System.Windows.Forms.TextBox();
            this.dtplimite = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Listado = new System.Windows.Forms.ListBox();
            this.TareaCompletada = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCompletada = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrdenarPor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txttarea
            // 
            this.txttarea.Location = new System.Drawing.Point(92, 42);
            this.txttarea.Name = "txttarea";
            this.txttarea.Size = new System.Drawing.Size(234, 20);
            this.txttarea.TabIndex = 0;
            // 
            // dtplimite
            // 
            this.dtplimite.Location = new System.Drawing.Point(92, 68);
            this.dtplimite.Name = "dtplimite";
            this.dtplimite.Size = new System.Drawing.Size(234, 20);
            this.dtplimite.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(154, 94);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Tarea";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Listado
            // 
            this.Listado.FormattingEnabled = true;
            this.Listado.Location = new System.Drawing.Point(31, 221);
            this.Listado.Name = "Listado";
            this.Listado.Size = new System.Drawing.Size(304, 108);
            this.Listado.TabIndex = 3;
            // 
            // TareaCompletada
            // 
            this.TareaCompletada.FormattingEnabled = true;
            this.TareaCompletada.Location = new System.Drawing.Point(390, 199);
            this.TareaCompletada.Name = "TareaCompletada";
            this.TareaCompletada.Size = new System.Drawing.Size(148, 108);
            this.TareaCompletada.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(64, 362);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(185, 362);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar Tarea";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCompletada
            // 
            this.btnCompletada.Location = new System.Drawing.Point(413, 362);
            this.btnCompletada.Name = "btnCompletada";
            this.btnCompletada.Size = new System.Drawing.Size(115, 23);
            this.btnCompletada.TabIndex = 7;
            this.btnCompletada.Text = "Tarea Completada";
            this.btnCompletada.UseVisualStyleBackColor = true;
            this.btnCompletada.Click += new System.EventHandler(this.btnCompletada_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Location = new System.Drawing.Point(300, 362);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(109, 23);
            this.btnDesmarcar.TabIndex = 8;
            this.btnDesmarcar.Text = "Desmarcar Tarea";
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(260, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gestor de Tareas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tareas Pendientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tareas Completadas";
            // 
            // cmbFiltrarPor
            // 
            this.cmbFiltrarPor.Location = new System.Drawing.Point(214, 189);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltrarPor.TabIndex = 13;
            this.cmbFiltrarPor.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarPor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filtrar por:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ordenar por:";
            // 
            // cmbOrdenarPor
            // 
            this.cmbOrdenarPor.Location = new System.Drawing.Point(42, 189);
            this.cmbOrdenarPor.Name = "cmbOrdenarPor";
            this.cmbOrdenarPor.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenarPor.TabIndex = 16;
            this.cmbOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenarPor_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 492);
            this.Controls.Add(this.cmbOrdenarPor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFiltrarPor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.btnCompletada);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.TareaCompletada);
            this.Controls.Add(this.Listado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtplimite);
            this.Controls.Add(this.txttarea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttarea;
        private System.Windows.Forms.DateTimePicker dtplimite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox Listado;
        private System.Windows.Forms.ListBox TareaCompletada;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCompletada;
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrdenarPor;
    }
}

