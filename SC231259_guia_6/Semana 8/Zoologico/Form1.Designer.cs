namespace Zoologico
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblNomCom = new System.Windows.Forms.Label();
            this.lblNomCien = new System.Windows.Forms.Label();
            this.lblFam = new System.Windows.Forms.Label();
            this.lblHabitat = new System.Windows.Forms.Label();
            this.lblFechaRes = new System.Windows.Forms.Label();
            this.txtNomCom = new System.Windows.Forms.TextBox();
            this.txtNomCien = new System.Windows.Forms.TextBox();
            this.cboFamilia = new System.Windows.Forms.ComboBox();
            this.cboHabitat = new System.Windows.Forms.ComboBox();
            this.dtpFechaRes = new System.Windows.Forms.DateTimePicker();
            this.lblDesEmb = new System.Windows.Forms.Label();
            this.cboDesEmb = new System.Windows.Forms.ComboBox();
            this.lblCantMamas = new System.Windows.Forms.Label();
            this.nudCantMamas = new System.Windows.Forms.NumericUpDown();
            this.gboFoto = new System.Windows.Forms.GroupBox();
            this.picMamifero = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgreMamifero = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMosMami = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMamas)).BeginInit();
            this.gboFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMamifero)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAgreMamifero);
            this.tabPage1.Controls.Add(this.gboFoto);
            this.tabPage1.Controls.Add(this.nudCantMamas);
            this.tabPage1.Controls.Add(this.lblCantMamas);
            this.tabPage1.Controls.Add(this.cboDesEmb);
            this.tabPage1.Controls.Add(this.lblDesEmb);
            this.tabPage1.Controls.Add(this.dtpFechaRes);
            this.tabPage1.Controls.Add(this.cboHabitat);
            this.tabPage1.Controls.Add(this.cboFamilia);
            this.tabPage1.Controls.Add(this.txtNomCien);
            this.tabPage1.Controls.Add(this.txtNomCom);
            this.tabPage1.Controls.Add(this.lblFechaRes);
            this.tabPage1.Controls.Add(this.lblHabitat);
            this.tabPage1.Controls.Add(this.lblFam);
            this.tabPage1.Controls.Add(this.lblNomCien);
            this.tabPage1.Controls.Add(this.lblNomCom);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mamiferos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reptiles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Peces";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(767, 396);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Artropodos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblNomCom
            // 
            this.lblNomCom.AutoSize = true;
            this.lblNomCom.Location = new System.Drawing.Point(7, 24);
            this.lblNomCom.Name = "lblNomCom";
            this.lblNomCom.Size = new System.Drawing.Size(104, 16);
            this.lblNomCom.TabIndex = 0;
            this.lblNomCom.Text = "Nombre Comun:";
            // 
            // lblNomCien
            // 
            this.lblNomCien.AutoSize = true;
            this.lblNomCien.Location = new System.Drawing.Point(7, 58);
            this.lblNomCien.Name = "lblNomCien";
            this.lblNomCien.Size = new System.Drawing.Size(116, 16);
            this.lblNomCien.TabIndex = 1;
            this.lblNomCien.Text = "Nombre Cientifico:";
            // 
            // lblFam
            // 
            this.lblFam.AutoSize = true;
            this.lblFam.Location = new System.Drawing.Point(7, 93);
            this.lblFam.Name = "lblFam";
            this.lblFam.Size = new System.Drawing.Size(54, 16);
            this.lblFam.TabIndex = 2;
            this.lblFam.Text = "Familia:";
            // 
            // lblHabitat
            // 
            this.lblHabitat.AutoSize = true;
            this.lblHabitat.Location = new System.Drawing.Point(7, 135);
            this.lblHabitat.Name = "lblHabitat";
            this.lblHabitat.Size = new System.Drawing.Size(53, 16);
            this.lblHabitat.TabIndex = 3;
            this.lblHabitat.Text = "Habitat:";
            // 
            // lblFechaRes
            // 
            this.lblFechaRes.AutoSize = true;
            this.lblFechaRes.Location = new System.Drawing.Point(7, 174);
            this.lblFechaRes.Name = "lblFechaRes";
            this.lblFechaRes.Size = new System.Drawing.Size(121, 16);
            this.lblFechaRes.TabIndex = 4;
            this.lblFechaRes.Text = "Fecha de Registro:";
            // 
            // txtNomCom
            // 
            this.txtNomCom.Location = new System.Drawing.Point(162, 24);
            this.txtNomCom.Name = "txtNomCom";
            this.txtNomCom.Size = new System.Drawing.Size(121, 22);
            this.txtNomCom.TabIndex = 5;
            // 
            // txtNomCien
            // 
            this.txtNomCien.Location = new System.Drawing.Point(162, 58);
            this.txtNomCien.Name = "txtNomCien";
            this.txtNomCien.Size = new System.Drawing.Size(121, 22);
            this.txtNomCien.TabIndex = 6;
            // 
            // cboFamilia
            // 
            this.cboFamilia.FormattingEnabled = true;
            this.cboFamilia.Items.AddRange(new object[] {
            "Carnivoros",
            "Ungulados",
            "Primates",
            "Pajaros",
            "Gallinacea",
            "Insectos",
            "Aracnidos",
            "Crustaceos"});
            this.cboFamilia.Location = new System.Drawing.Point(162, 90);
            this.cboFamilia.Name = "cboFamilia";
            this.cboFamilia.Size = new System.Drawing.Size(121, 24);
            this.cboFamilia.TabIndex = 7;
            // 
            // cboHabitat
            // 
            this.cboHabitat.FormattingEnabled = true;
            this.cboHabitat.Items.AddRange(new object[] {
            "Selva",
            "Desierto",
            "Mar",
            "Rio",
            "Lagos"});
            this.cboHabitat.Location = new System.Drawing.Point(162, 135);
            this.cboHabitat.Name = "cboHabitat";
            this.cboHabitat.Size = new System.Drawing.Size(121, 24);
            this.cboHabitat.TabIndex = 8;
            // 
            // dtpFechaRes
            // 
            this.dtpFechaRes.Location = new System.Drawing.Point(162, 174);
            this.dtpFechaRes.Name = "dtpFechaRes";
            this.dtpFechaRes.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaRes.TabIndex = 9;
            // 
            // lblDesEmb
            // 
            this.lblDesEmb.AutoSize = true;
            this.lblDesEmb.Location = new System.Drawing.Point(6, 214);
            this.lblDesEmb.Name = "lblDesEmb";
            this.lblDesEmb.Size = new System.Drawing.Size(149, 16);
            this.lblDesEmb.TabIndex = 10;
            this.lblDesEmb.Text = "Desarrollo Embrionario:";
            // 
            // cboDesEmb
            // 
            this.cboDesEmb.FormattingEnabled = true;
            this.cboDesEmb.Items.AddRange(new object[] {
            "Monotremas",
            "Marsupiales",
            "Placentarios"});
            this.cboDesEmb.Location = new System.Drawing.Point(162, 214);
            this.cboDesEmb.Name = "cboDesEmb";
            this.cboDesEmb.Size = new System.Drawing.Size(121, 24);
            this.cboDesEmb.TabIndex = 11;
            // 
            // lblCantMamas
            // 
            this.lblCantMamas.AutoSize = true;
            this.lblCantMamas.Location = new System.Drawing.Point(7, 258);
            this.lblCantMamas.Name = "lblCantMamas";
            this.lblCantMamas.Size = new System.Drawing.Size(131, 16);
            this.lblCantMamas.TabIndex = 12;
            this.lblCantMamas.Text = "Cantidad de Mamas:";
            // 
            // nudCantMamas
            // 
            this.nudCantMamas.Location = new System.Drawing.Point(162, 258);
            this.nudCantMamas.Name = "nudCantMamas";
            this.nudCantMamas.Size = new System.Drawing.Size(120, 22);
            this.nudCantMamas.TabIndex = 13;
            // 
            // gboFoto
            // 
            this.gboFoto.Controls.Add(this.btnBuscar);
            this.gboFoto.Controls.Add(this.picMamifero);
            this.gboFoto.Location = new System.Drawing.Point(400, 24);
            this.gboFoto.Name = "gboFoto";
            this.gboFoto.Size = new System.Drawing.Size(307, 286);
            this.gboFoto.TabIndex = 14;
            this.gboFoto.TabStop = false;
            this.gboFoto.Text = "Foto";
            // 
            // picMamifero
            // 
            this.picMamifero.Location = new System.Drawing.Point(7, 22);
            this.picMamifero.Name = "picMamifero";
            this.picMamifero.Size = new System.Drawing.Size(281, 204);
            this.picMamifero.TabIndex = 0;
            this.picMamifero.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(186, 243);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 26);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgreMamifero
            // 
            this.btnAgreMamifero.Location = new System.Drawing.Point(303, 344);
            this.btnAgreMamifero.Name = "btnAgreMamifero";
            this.btnAgreMamifero.Size = new System.Drawing.Size(133, 33);
            this.btnAgreMamifero.TabIndex = 15;
            this.btnAgreMamifero.Text = "Agregar Mamifero";
            this.btnAgreMamifero.UseVisualStyleBackColor = true;
            this.btnAgreMamifero.Click += new System.EventHandler(this.btnAgreMamifero_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnMosMami);
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(767, 396);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ver Registros";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(4, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMosMami
            // 
            this.btnMosMami.Location = new System.Drawing.Point(4, 14);
            this.btnMosMami.Name = "btnMosMami";
            this.btnMosMami.Size = new System.Drawing.Size(104, 26);
            this.btnMosMami.TabIndex = 1;
            this.btnMosMami.Text = "Mamiferos";
            this.btnMosMami.UseVisualStyleBackColor = true;
            this.btnMosMami.Click += new System.EventHandler(this.btnMosMami_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Comun";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Cientifico";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Familia";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Habitat";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha de Registro";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Foto";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMamas)).EndInit();
            this.gboFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMamifero)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboFamilia;
        private System.Windows.Forms.TextBox txtNomCien;
        private System.Windows.Forms.TextBox txtNomCom;
        private System.Windows.Forms.Label lblFechaRes;
        private System.Windows.Forms.Label lblHabitat;
        private System.Windows.Forms.Label lblFam;
        private System.Windows.Forms.Label lblNomCien;
        private System.Windows.Forms.Label lblNomCom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gboFoto;
        private System.Windows.Forms.NumericUpDown nudCantMamas;
        private System.Windows.Forms.Label lblCantMamas;
        private System.Windows.Forms.ComboBox cboDesEmb;
        private System.Windows.Forms.Label lblDesEmb;
        private System.Windows.Forms.DateTimePicker dtpFechaRes;
        private System.Windows.Forms.ComboBox cboHabitat;
        private System.Windows.Forms.Button btnAgreMamifero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox picMamifero;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnMosMami;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

