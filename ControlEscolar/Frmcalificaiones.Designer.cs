namespace ControlEscolar
{
    partial class Frmcalificaiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcalificaiones));
            this.lblalumnos = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblcreditos = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtcreditos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbalumnos = new System.Windows.Forms.ComboBox();
            this.cmbprofesor = new System.Windows.Forms.ComboBox();
            this.cmbmateria = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvcalificaion = new System.Windows.Forms.DataGridView();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificaion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblalumnos
            // 
            this.lblalumnos.AutoSize = true;
            this.lblalumnos.Location = new System.Drawing.Point(23, 35);
            this.lblalumnos.Name = "lblalumnos";
            this.lblalumnos.Size = new System.Drawing.Size(71, 20);
            this.lblalumnos.TabIndex = 0;
            this.lblalumnos.Text = "Alumnos";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(23, 140);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(62, 20);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(23, 82);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(69, 20);
            this.lblProfesor.TabIndex = 1;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblcreditos
            // 
            this.lblcreditos.AutoSize = true;
            this.lblcreditos.Location = new System.Drawing.Point(23, 187);
            this.lblcreditos.Name = "lblcreditos";
            this.lblcreditos.Size = new System.Drawing.Size(68, 20);
            this.lblcreditos.TabIndex = 1;
            this.lblcreditos.Text = "Creditos";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(399, 259);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(387, 26);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // txtcreditos
            // 
            this.txtcreditos.Location = new System.Drawing.Point(111, 184);
            this.txtcreditos.Name = "txtcreditos";
            this.txtcreditos.Size = new System.Drawing.Size(199, 26);
            this.txtcreditos.TabIndex = 2;
            this.txtcreditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcreditos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // cmbalumnos
            // 
            this.cmbalumnos.FormattingEnabled = true;
            this.cmbalumnos.Location = new System.Drawing.Point(111, 26);
            this.cmbalumnos.Name = "cmbalumnos";
            this.cmbalumnos.Size = new System.Drawing.Size(199, 28);
            this.cmbalumnos.TabIndex = 3;
            this.cmbalumnos.SelectedIndexChanged += new System.EventHandler(this.cmbalumnos_SelectedIndexChanged);
            // 
            // cmbprofesor
            // 
            this.cmbprofesor.FormattingEnabled = true;
            this.cmbprofesor.Location = new System.Drawing.Point(111, 82);
            this.cmbprofesor.Name = "cmbprofesor";
            this.cmbprofesor.Size = new System.Drawing.Size(199, 28);
            this.cmbprofesor.TabIndex = 3;
            this.cmbprofesor.SelectedIndexChanged += new System.EventHandler(this.cmbprofesor_SelectedIndexChanged);
            // 
            // cmbmateria
            // 
            this.cmbmateria.FormattingEnabled = true;
            this.cmbmateria.Location = new System.Drawing.Point(111, 132);
            this.cmbmateria.Name = "cmbmateria";
            this.cmbmateria.Size = new System.Drawing.Size(199, 28);
            this.cmbmateria.TabIndex = 3;
            this.cmbmateria.SelectedIndexChanged += new System.EventHandler(this.cmbmateria_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrar.Location = new System.Drawing.Point(786, 503);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(130, 53);
            this.btnBorrar.TabIndex = 35;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(615, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 53);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Location = new System.Drawing.Point(416, 503);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 53);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(246, 503);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 53);
            this.btnNuevo.TabIndex = 32;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvcalificaion
            // 
            this.dgvcalificaion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcalificaion.Location = new System.Drawing.Point(89, 315);
            this.dgvcalificaion.Name = "dgvcalificaion";
            this.dgvcalificaion.RowTemplate.Height = 28;
            this.dgvcalificaion.Size = new System.Drawing.Size(1079, 153);
            this.dgvcalificaion.TabIndex = 36;
            this.dgvcalificaion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcalificaion_CellDoubleClick);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(937, 265);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 20);
            this.lblid.TabIndex = 37;
            this.lblid.Text = "0";
            // 
            // Frmcalificaiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 618);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dgvcalificaion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cmbmateria);
            this.Controls.Add(this.cmbprofesor);
            this.Controls.Add(this.cmbalumnos);
            this.Controls.Add(this.txtcreditos);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcreditos);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblalumnos);
            this.Name = "Frmcalificaiones";
            this.Text = "Frmcalificaiones";
            this.Load += new System.EventHandler(this.Frmcalificaiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificaion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalumnos;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblcreditos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtcreditos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbalumnos;
        private System.Windows.Forms.ComboBox cmbprofesor;
        private System.Windows.Forms.ComboBox cmbmateria;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvcalificaion;
        private System.Windows.Forms.Label lblid;
    }
}