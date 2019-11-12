namespace ControlEscolar
{
    partial class FrmAsignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignaturas));
            this.lblmateria = new System.Windows.Forms.Label();
            this.lblhorast = new System.Windows.Forms.Label();
            this.lblhorasp = new System.Windows.Forms.Label();
            this.lblcreditos = new System.Windows.Forms.Label();
            this.txtnombremateria = new System.Windows.Forms.TextBox();
            this.txthorast = new System.Windows.Forms.TextBox();
            this.txthorasp = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtsemestre = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvasignatura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblidmateria = new System.Windows.Forms.Label();
            this.txtidmateria = new System.Windows.Forms.TextBox();
            this.cmbanterior = new System.Windows.Forms.ComboBox();
            this.cmbsiguiente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasignatura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmateria
            // 
            this.lblmateria.AutoSize = true;
            this.lblmateria.Location = new System.Drawing.Point(25, 55);
            this.lblmateria.Name = "lblmateria";
            this.lblmateria.Size = new System.Drawing.Size(122, 20);
            this.lblmateria.TabIndex = 0;
            this.lblmateria.Text = "Nombre Materia";
            // 
            // lblhorast
            // 
            this.lblhorast.AutoSize = true;
            this.lblhorast.Location = new System.Drawing.Point(25, 96);
            this.lblhorast.Name = "lblhorast";
            this.lblhorast.Size = new System.Drawing.Size(135, 20);
            this.lblhorast.TabIndex = 1;
            this.lblhorast.Text = "Horas Trabajadas";
            // 
            // lblhorasp
            // 
            this.lblhorasp.AutoSize = true;
            this.lblhorasp.Location = new System.Drawing.Point(24, 136);
            this.lblhorasp.Name = "lblhorasp";
            this.lblhorasp.Size = new System.Drawing.Size(113, 20);
            this.lblhorasp.TabIndex = 2;
            this.lblhorasp.Text = "Horas Practica";
            // 
            // lblcreditos
            // 
            this.lblcreditos.AutoSize = true;
            this.lblcreditos.Location = new System.Drawing.Point(498, 125);
            this.lblcreditos.Name = "lblcreditos";
            this.lblcreditos.Size = new System.Drawing.Size(68, 20);
            this.lblcreditos.TabIndex = 3;
            this.lblcreditos.Text = "Creditos";
            // 
            // txtnombremateria
            // 
            this.txtnombremateria.Location = new System.Drawing.Point(206, 52);
            this.txtnombremateria.Name = "txtnombremateria";
            this.txtnombremateria.Size = new System.Drawing.Size(246, 26);
            this.txtnombremateria.TabIndex = 5;
            // 
            // txthorast
            // 
            this.txthorast.Location = new System.Drawing.Point(206, 93);
            this.txthorast.Name = "txthorast";
            this.txthorast.Size = new System.Drawing.Size(246, 26);
            this.txthorast.TabIndex = 5;
            this.txthorast.TextChanged += new System.EventHandler(this.txthorast_TextChanged);
            // 
            // txthorasp
            // 
            this.txthorasp.Location = new System.Drawing.Point(206, 136);
            this.txthorasp.Name = "txthorasp";
            this.txthorasp.Size = new System.Drawing.Size(246, 26);
            this.txthorasp.TabIndex = 5;
            this.txthorasp.TextChanged += new System.EventHandler(this.txthorasp_TextChanged);
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(649, 125);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(182, 26);
            this.txtcarrera.TabIndex = 5;
            // 
            // txtsemestre
            // 
            this.txtsemestre.Location = new System.Drawing.Point(206, 185);
            this.txtsemestre.Name = "txtsemestre";
            this.txtsemestre.Size = new System.Drawing.Size(246, 26);
            this.txtsemestre.TabIndex = 5;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(289, 258);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(514, 26);
            this.txtbuscar.TabIndex = 6;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(469, 224);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(59, 20);
            this.lblbuscar.TabIndex = 4;
            this.lblbuscar.Text = "Buscar";
            this.lblbuscar.Click += new System.EventHandler(this.lblsemestre_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(661, 543);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(70, 53);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(550, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 53);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(433, 543);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 53);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(322, 543);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 53);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvasignatura
            // 
            this.dgvasignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvasignatura.Location = new System.Drawing.Point(28, 303);
            this.dgvasignatura.Name = "dgvasignatura";
            this.dgvasignatura.RowTemplate.Height = 28;
            this.dgvasignatura.Size = new System.Drawing.Size(1179, 201);
            this.dgvasignatura.TabIndex = 36;
            this.dgvasignatura.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvasignatura_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Semestre";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(834, 261);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 20);
            this.lblid.TabIndex = 38;
            this.lblid.Text = "0";
            // 
            // lblidmateria
            // 
            this.lblidmateria.AutoSize = true;
            this.lblidmateria.Location = new System.Drawing.Point(25, 9);
            this.lblidmateria.Name = "lblidmateria";
            this.lblidmateria.Size = new System.Drawing.Size(83, 20);
            this.lblidmateria.TabIndex = 39;
            this.lblidmateria.Text = "ID materia";
            // 
            // txtidmateria
            // 
            this.txtidmateria.Location = new System.Drawing.Point(206, 9);
            this.txtidmateria.Name = "txtidmateria";
            this.txtidmateria.Size = new System.Drawing.Size(246, 26);
            this.txtidmateria.TabIndex = 40;
            // 
            // cmbanterior
            // 
            this.cmbanterior.FormattingEnabled = true;
            this.cmbanterior.Location = new System.Drawing.Point(649, 18);
            this.cmbanterior.Name = "cmbanterior";
            this.cmbanterior.Size = new System.Drawing.Size(182, 28);
            this.cmbanterior.TabIndex = 41;
            this.cmbanterior.SelectedIndexChanged += new System.EventHandler(this.cmbanterior_SelectedIndexChanged);
            // 
            // cmbsiguiente
            // 
            this.cmbsiguiente.FormattingEnabled = true;
            this.cmbsiguiente.Location = new System.Drawing.Point(649, 70);
            this.cmbsiguiente.Name = "cmbsiguiente";
            this.cmbsiguiente.Size = new System.Drawing.Size(182, 28);
            this.cmbsiguiente.TabIndex = 42;
            this.cmbsiguiente.SelectedIndexChanged += new System.EventHandler(this.cmbsiguiente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Materia Anterior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Materia Siguiente";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(223, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 36);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1252, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbsiguiente);
            this.Controls.Add(this.cmbanterior);
            this.Controls.Add(this.txtidmateria);
            this.Controls.Add(this.lblidmateria);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvasignatura);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtsemestre);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txthorasp);
            this.Controls.Add(this.txthorast);
            this.Controls.Add(this.txtnombremateria);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lblcreditos);
            this.Controls.Add(this.lblhorasp);
            this.Controls.Add(this.lblhorast);
            this.Controls.Add(this.lblmateria);
            this.Name = "FrmAsignaturas";
            this.Text = "FrmAsignaturas";
            this.Load += new System.EventHandler(this.FrmAsignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvasignatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmateria;
        private System.Windows.Forms.Label lblhorast;
        private System.Windows.Forms.Label lblhorasp;
        private System.Windows.Forms.Label lblcreditos;
        private System.Windows.Forms.TextBox txtnombremateria;
        private System.Windows.Forms.TextBox txthorast;
        private System.Windows.Forms.TextBox txthorasp;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtsemestre;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvasignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblidmateria;
        private System.Windows.Forms.TextBox txtidmateria;
        private System.Windows.Forms.ComboBox cmbanterior;
        private System.Windows.Forms.ComboBox cmbsiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}