namespace ControlEscolar
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidopaterno = new System.Windows.Forms.Label();
            this.lblapellidomaterno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcontrasenia = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidop = new System.Windows.Forms.TextBox();
            this.txtapellidom = new System.Windows.Forms.TextBox();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(44, 257);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowTemplate.Height = 28;
            this.dtgUsuarios.Size = new System.Drawing.Size(617, 211);
            this.dtgUsuarios.TabIndex = 0;
            this.dtgUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellDoubleClick);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(57, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellidopaterno
            // 
            this.lblapellidopaterno.AutoSize = true;
            this.lblapellidopaterno.Location = new System.Drawing.Point(48, 73);
            this.lblapellidopaterno.Name = "lblapellidopaterno";
            this.lblapellidopaterno.Size = new System.Drawing.Size(125, 20);
            this.lblapellidopaterno.TabIndex = 2;
            this.lblapellidopaterno.Text = "Apellido Paterno";
            // 
            // lblapellidomaterno
            // 
            this.lblapellidomaterno.AutoSize = true;
            this.lblapellidomaterno.Location = new System.Drawing.Point(48, 136);
            this.lblapellidomaterno.Name = "lblapellidomaterno";
            this.lblapellidomaterno.Size = new System.Drawing.Size(128, 20);
            this.lblapellidomaterno.TabIndex = 3;
            this.lblapellidomaterno.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-205, -67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label3";
            // 
            // lblcontrasenia
            // 
            this.lblcontrasenia.AutoSize = true;
            this.lblcontrasenia.Location = new System.Drawing.Point(48, 202);
            this.lblcontrasenia.Name = "lblcontrasenia";
            this.lblcontrasenia.Size = new System.Drawing.Size(95, 20);
            this.lblcontrasenia.TabIndex = 4;
            this.lblcontrasenia.Text = "Contrasenia";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(44, 32);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(347, 26);
            this.txtnombre.TabIndex = 5;
            // 
            // txtapellidop
            // 
            this.txtapellidop.Location = new System.Drawing.Point(49, 96);
            this.txtapellidop.Name = "txtapellidop";
            this.txtapellidop.Size = new System.Drawing.Size(342, 26);
            this.txtapellidop.TabIndex = 6;
            // 
            // txtapellidom
            // 
            this.txtapellidom.Location = new System.Drawing.Point(52, 159);
            this.txtapellidom.Name = "txtapellidom";
            this.txtapellidom.Size = new System.Drawing.Size(339, 26);
            this.txtapellidom.TabIndex = 7;
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Location = new System.Drawing.Point(52, 225);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(339, 26);
            this.txtcontrasenia.TabIndex = 8;
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Location = new System.Drawing.Point(225, 474);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(94, 58);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(73, 474);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(103, 58);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Location = new System.Drawing.Point(354, 474);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(95, 58);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Location = new System.Drawing.Point(507, 474);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 58);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(755, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 20);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "0";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(528, 51);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(253, 26);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(645, 19);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(59, 20);
            this.lblbuscar.TabIndex = 13;
            this.lblbuscar.Text = "Buscar";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 544);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcontrasenia);
            this.Controls.Add(this.txtapellidom);
            this.Controls.Add(this.txtapellidop);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcontrasenia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblapellidomaterno);
            this.Controls.Add(this.lblapellidopaterno);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.dtgUsuarios);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidopaterno;
        private System.Windows.Forms.Label lblapellidomaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcontrasenia;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidop;
        private System.Windows.Forms.TextBox txtapellidom;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
    }
}

