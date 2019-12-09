namespace ControlEscolar
{
    partial class frmAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblap = new System.Windows.Forms.Label();
            this.lblam = new System.Windows.Forms.Label();
            this.lbldom = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtam = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.txtdom = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dgvalumnos = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lblestados = new System.Windows.Forms.Label();
            this.lblMunic = new System.Windows.Forms.Label();
            this.cmbestados = new System.Windows.Forms.ComboBox();
            this.cmbciudades = new System.Windows.Forms.ComboBox();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(44, 24);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblap
            // 
            this.lblap.AutoSize = true;
            this.lblap.Location = new System.Drawing.Point(44, 79);
            this.lblap.Name = "lblap";
            this.lblap.Size = new System.Drawing.Size(125, 20);
            this.lblap.TabIndex = 0;
            this.lblap.Text = "Apellido Paterno";
            // 
            // lblam
            // 
            this.lblam.AutoSize = true;
            this.lblam.Location = new System.Drawing.Point(44, 148);
            this.lblam.Name = "lblam";
            this.lblam.Size = new System.Drawing.Size(124, 20);
            this.lblam.TabIndex = 0;
            this.lblam.Text = "ApellidoMaterno";
            // 
            // lbldom
            // 
            this.lbldom.AutoSize = true;
            this.lbldom.Location = new System.Drawing.Point(466, 24);
            this.lbldom.Name = "lbldom";
            this.lbldom.Size = new System.Drawing.Size(72, 20);
            this.lbldom.TabIndex = 0;
            this.lbldom.Text = "Domicilio";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(469, 148);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(45, 20);
            this.lblsex.TabIndex = 0;
            this.lblsex.Text = "Sexo";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(466, 79);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 20);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(455, 270);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(159, 20);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha de Nacimiento";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(168, 344);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(18, 20);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "0";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(51, 47);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(371, 26);
            this.txtnom.TabIndex = 1;
            // 
            // txtam
            // 
            this.txtam.Location = new System.Drawing.Point(51, 171);
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(371, 26);
            this.txtam.TabIndex = 1;
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(48, 102);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(374, 26);
            this.txtap.TabIndex = 1;
            // 
            // txtdom
            // 
            this.txtdom.Location = new System.Drawing.Point(459, 47);
            this.txtdom.Name = "txtdom";
            this.txtdom.Size = new System.Drawing.Size(431, 26);
            this.txtdom.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(459, 102);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(431, 26);
            this.txtemail.TabIndex = 1;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(459, 171);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(431, 26);
            this.txtsexo.TabIndex = 1;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(333, 344);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(421, 26);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(259, 350);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(59, 20);
            this.lblbuscar.TabIndex = 0;
            this.lblbuscar.Text = "Buscar";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1247, -183);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(255, 26);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Buscar";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(637, 270);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(253, 26);
            this.dtpfecha.TabIndex = 2;
            // 
            // dgvalumnos
            // 
            this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalumnos.Location = new System.Drawing.Point(51, 397);
            this.dgvalumnos.Name = "dgvalumnos";
            this.dgvalumnos.RowTemplate.Height = 28;
            this.dgvalumnos.Size = new System.Drawing.Size(853, 157);
            this.dgvalumnos.TabIndex = 3;
            this.dgvalumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalumnos_CellDoubleClick);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Location = new System.Drawing.Point(711, 560);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 71);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Location = new System.Drawing.Point(558, 560);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 71);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnnuevo.Location = new System.Drawing.Point(242, 560);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(139, 71);
            this.btnnuevo.TabIndex = 14;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Location = new System.Drawing.Point(417, 560);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(121, 71);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblestados
            // 
            this.lblestados.AutoSize = true;
            this.lblestados.Location = new System.Drawing.Point(47, 229);
            this.lblestados.Name = "lblestados";
            this.lblestados.Size = new System.Drawing.Size(68, 20);
            this.lblestados.TabIndex = 15;
            this.lblestados.Text = "Estados";
            // 
            // lblMunic
            // 
            this.lblMunic.AutoSize = true;
            this.lblMunic.Location = new System.Drawing.Point(455, 224);
            this.lblMunic.Name = "lblMunic";
            this.lblMunic.Size = new System.Drawing.Size(75, 20);
            this.lblMunic.TabIndex = 15;
            this.lblMunic.Text = "Municipio";
            // 
            // cmbestados
            // 
            this.cmbestados.FormattingEnabled = true;
            this.cmbestados.Location = new System.Drawing.Point(121, 221);
            this.cmbestados.Name = "cmbestados";
            this.cmbestados.Size = new System.Drawing.Size(301, 28);
            this.cmbestados.TabIndex = 16;
            this.cmbestados.SelectedIndexChanged += new System.EventHandler(this.cbmestados_SelectedIndexChanged);
            // 
            // cmbciudades
            // 
            this.cmbciudades.FormattingEnabled = true;
            this.cmbciudades.Location = new System.Drawing.Point(563, 221);
            this.cmbciudades.Name = "cmbciudades";
            this.cmbciudades.Size = new System.Drawing.Size(327, 28);
            this.cmbciudades.TabIndex = 17;
            this.cmbciudades.SelectedIndexChanged += new System.EventHandler(this.cmbciudades_SelectedIndexChanged);
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(183, 268);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(239, 28);
            this.cmbgrupo.TabIndex = 18;
            this.cmbgrupo.SelectedValueChanged += new System.EventHandler(this.cmbgrupo_SelectedValueChanged);
            this.cmbgrupo.Click += new System.EventHandler(this.cmbgrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Grupo";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 656);
            this.Controls.Add(this.cmbgrupo);
            this.Controls.Add(this.cmbciudades);
            this.Controls.Add(this.cmbestados);
            this.Controls.Add(this.lblMunic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblestados);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dgvalumnos);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdom);
            this.Controls.Add(this.txtam);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.lbldom);
            this.Controls.Add(this.lblam);
            this.Controls.Add(this.lblap);
            this.Controls.Add(this.lblnombre);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblap;
        private System.Windows.Forms.Label lblam;
        private System.Windows.Forms.Label lbldom;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.TextBox txtdom;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.DataGridView dgvalumnos;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label lblestados;
        private System.Windows.Forms.Label lblMunic;
        private System.Windows.Forms.ComboBox cmbestados;
        private System.Windows.Forms.ComboBox cmbciudades;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.Label label1;
    }
}