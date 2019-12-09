namespace ControlEscolar
{
    partial class Frmmaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmaterias));
            this.LBL1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblcodi = new System.Windows.Forms.Label();
            this.cmbcodigo = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.dgvestudios = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtjpg = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudios)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(42, 9);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(18, 20);
            this.LBL1.TabIndex = 36;
            this.LBL1.Text = "0";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(137, 275);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(59, 20);
            this.lblBuscar.TabIndex = 35;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(297, 270);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(309, 26);
            this.txtbuscar.TabIndex = 34;
            // 
            // lblcodi
            // 
            this.lblcodi.AutoSize = true;
            this.lblcodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodi.Location = new System.Drawing.Point(12, 77);
            this.lblcodi.Name = "lblcodi";
            this.lblcodi.Size = new System.Drawing.Size(59, 20);
            this.lblcodi.TabIndex = 33;
            this.lblcodi.Text = "Codigo";
            // 
            // cmbcodigo
            // 
            this.cmbcodigo.FormattingEnabled = true;
            this.cmbcodigo.Location = new System.Drawing.Point(187, 77);
            this.cmbcodigo.Name = "cmbcodigo";
            this.cmbcodigo.Size = new System.Drawing.Size(180, 28);
            this.cmbcodigo.TabIndex = 32;
            this.cmbcodigo.SelectedIndexChanged += new System.EventHandler(this.cmbcodigo_SelectedIndexChanged);
            this.cmbcodigo.Click += new System.EventHandler(this.cmbcodigo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrar.Location = new System.Drawing.Point(589, 552);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(130, 53);
            this.btnBorrar.TabIndex = 31;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Location = new System.Drawing.Point(418, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 53);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Location = new System.Drawing.Point(219, 552);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 53);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btncargar
            // 
            this.btncargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncargar.BackgroundImage")));
            this.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncargar.Location = new System.Drawing.Point(49, 552);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(130, 53);
            this.btncargar.TabIndex = 28;
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvestudios
            // 
            this.dgvestudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestudios.Location = new System.Drawing.Point(16, 316);
            this.dgvestudios.Name = "dgvestudios";
            this.dgvestudios.RowTemplate.Height = 28;
            this.dgvestudios.Size = new System.Drawing.Size(735, 214);
            this.dgvestudios.TabIndex = 27;
            this.dgvestudios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestudios_CellContentClick);
            this.dgvestudios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestudios_CellDoubleClick);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(17, 216);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 20);
            this.lblnombre.TabIndex = 26;
            this.lblnombre.Text = "Nombre";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(17, 134);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(43, 20);
            this.lbltitulo.TabIndex = 25;
            this.lbltitulo.Text = "titulo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(187, 210);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 26);
            this.txtnombre.TabIndex = 24;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(187, 134);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(180, 26);
            this.txttitulo.TabIndex = 23;
            this.txttitulo.TextChanged += new System.EventHandler(this.txttitulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cargar Archivos ";
            // 
            // txtjpg
            // 
            this.txtjpg.Location = new System.Drawing.Point(453, 91);
            this.txtjpg.Name = "txtjpg";
            this.txtjpg.Size = new System.Drawing.Size(240, 26);
            this.txtjpg.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 58);
            this.button1.TabIndex = 45;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmmaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(773, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtjpg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblcodi);
            this.Controls.Add(this.cmbcodigo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.dgvestudios);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frmmaterias";
            this.Text = "Frmmaterias";
            this.Load += new System.EventHandler(this.Frmmaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblcodi;
        private System.Windows.Forms.ComboBox cmbcodigo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.DataGridView dgvestudios;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjpg;
        private System.Windows.Forms.Button button1;
    }
}