namespace ControlEscolar
{
    partial class FrmProfesor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesor));
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.lblam = new System.Windows.Forms.Label();
            this.txtam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumced = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtdire = new System.Windows.Forms.TextBox();
            this.lblnumcedula = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cmbestados = new System.Windows.Forms.ComboBox();
            this.cmbciudades = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblmunicipio = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dgvProfesor = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnestudios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumcont = new System.Windows.Forms.TextBox();
            this.lblid2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(52, 32);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(255, 26);
            this.txtnom.TabIndex = 2;
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(51, 90);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(255, 26);
            this.txtap.TabIndex = 3;
            // 
            // lblam
            // 
            this.lblam.AutoSize = true;
            this.lblam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblam.Location = new System.Drawing.Point(48, 128);
            this.lblam.Name = "lblam";
            this.lblam.Size = new System.Drawing.Size(128, 20);
            this.lblam.TabIndex = 46;
            this.lblam.Text = "Apellido Materno";
            // 
            // txtam
            // 
            this.txtam.Location = new System.Drawing.Point(52, 163);
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(256, 26);
            this.txtam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 46;
            // 
            // txtnumced
            // 
            this.txtnumced.Location = new System.Drawing.Point(341, 90);
            this.txtnumced.Name = "txtnumced";
            this.txtnumced.Size = new System.Drawing.Size(243, 26);
            this.txtnumced.TabIndex = 6;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(337, 9);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(75, 20);
            this.lbldireccion.TabIndex = 46;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtdire
            // 
            this.txtdire.Location = new System.Drawing.Point(341, 32);
            this.txtdire.Name = "txtdire";
            this.txtdire.Size = new System.Drawing.Size(243, 26);
            this.txtdire.TabIndex = 5;
            // 
            // lblnumcedula
            // 
            this.lblnumcedula.AutoSize = true;
            this.lblnumcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcedula.Location = new System.Drawing.Point(337, 67);
            this.lblnumcedula.Name = "lblnumcedula";
            this.lblnumcedula.Size = new System.Drawing.Size(119, 20);
            this.lblnumcedula.TabIndex = 46;
            this.lblnumcedula.Text = "Numero Cedula";
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(341, 163);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(243, 26);
            this.txttitulo.TabIndex = 7;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(348, 131);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(47, 20);
            this.lbltitulo.TabIndex = 46;
            this.lbltitulo.Text = "Titulo";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(415, 301);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(59, 20);
            this.lblbuscar.TabIndex = 46;
            this.lblbuscar.Text = "Buscar";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(550, 307);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(342, 26);
            this.textBox8.TabIndex = 47;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // cmbestados
            // 
            this.cmbestados.FormattingEnabled = true;
            this.cmbestados.Location = new System.Drawing.Point(447, 238);
            this.cmbestados.Name = "cmbestados";
            this.cmbestados.Size = new System.Drawing.Size(121, 28);
            this.cmbestados.TabIndex = 8;
            this.cmbestados.SelectedIndexChanged += new System.EventHandler(this.cmbestados_SelectedIndexChanged);
            // 
            // cmbciudades
            // 
            this.cmbciudades.FormattingEnabled = true;
            this.cmbciudades.Location = new System.Drawing.Point(743, 238);
            this.cmbciudades.Name = "cmbciudades";
            this.cmbciudades.Size = new System.Drawing.Size(121, 28);
            this.cmbciudades.TabIndex = 9;
            this.cmbciudades.SelectedIndexChanged += new System.EventHandler(this.cmbmunicipios_SelectedIndexChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(348, 246);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(60, 20);
            this.lblestado.TabIndex = 50;
            this.lblestado.Text = "Estado";
            // 
            // lblmunicipio
            // 
            this.lblmunicipio.AutoSize = true;
            this.lblmunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmunicipio.Location = new System.Drawing.Point(615, 246);
            this.lblmunicipio.Name = "lblmunicipio";
            this.lblmunicipio.Size = new System.Drawing.Size(75, 20);
            this.lblmunicipio.TabIndex = 50;
            this.lblmunicipio.Text = "Municipio";
            // 
            // dtpfecha
            // 
            this.dtpfecha.AutoSize = true;
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(675, 39);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(159, 20);
            this.dtpfecha.TabIndex = 50;
            this.dtpfecha.Text = "Fecha de Nacimiento";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(188, 310);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 20);
            this.lblid.TabIndex = 50;
            this.lblid.Text = "0";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(644, 62);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 26);
            this.dtp1.TabIndex = 51;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // dgvProfesor
            // 
            this.dgvProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfesor.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProfesor.Location = new System.Drawing.Point(73, 353);
            this.dgvProfesor.Name = "dgvProfesor";
            this.dgvProfesor.RowTemplate.Height = 28;
            this.dgvProfesor.Size = new System.Drawing.Size(1075, 198);
            this.dgvProfesor.TabIndex = 52;
            this.dgvProfesor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesor_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(291, 593);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 71);
            this.btnNuevo.TabIndex = 53;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Location = new System.Drawing.Point(447, 593);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 71);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(619, 593);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 71);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Location = new System.Drawing.Point(756, 593);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 71);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnestudios
            // 
            this.btnestudios.Location = new System.Drawing.Point(962, 225);
            this.btnestudios.Name = "btnestudios";
            this.btnestudios.Size = new System.Drawing.Size(118, 47);
            this.btnestudios.TabIndex = 55;
            this.btnestudios.Text = "Estudios";
            this.btnestudios.UseVisualStyleBackColor = true;
            this.btnestudios.Click += new System.EventHandler(this.btnestudios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtnumcont
            // 
            this.txtnumcont.Location = new System.Drawing.Point(641, 125);
            this.txtnumcont.Name = "txtnumcont";
            this.txtnumcont.Size = new System.Drawing.Size(251, 26);
            this.txtnumcont.TabIndex = 1;
            this.txtnumcont.TextChanged += new System.EventHandler(this.txtnumcont_TextChanged);
            // 
            // lblid2
            // 
            this.lblid2.AutoSize = true;
            this.lblid2.Location = new System.Drawing.Point(265, 310);
            this.lblid2.Name = "lblid2";
            this.lblid2.Size = new System.Drawing.Size(18, 20);
            this.lblid2.TabIndex = 56;
            this.lblid2.Text = "0";
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1259, 720);
            this.Controls.Add(this.lblid2);
            this.Controls.Add(this.btnestudios);
            this.Controls.Add(this.txtnumcont);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProfesor);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblmunicipio);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.cmbciudades);
            this.Controls.Add(this.cmbestados);
            this.Controls.Add(this.txtdire);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txttitulo);
            this.Controls.Add(this.txtnumced);
            this.Controls.Add(this.txtam);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblnumcedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmProfesor";
            this.Text = "FrmProfesor";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.Label lblam;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumced;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtdire;
        private System.Windows.Forms.Label lblnumcedula;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox cmbestados;
        private System.Windows.Forms.ComboBox cmbciudades;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblmunicipio;
        private System.Windows.Forms.Label dtpfecha;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dgvProfesor;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnestudios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumcont;
        private System.Windows.Forms.Label lblid2;
    }
}