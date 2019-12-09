namespace ControlEscolar
{
    partial class Asignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asignaciones));
            this.lblprofesores = new System.Windows.Forms.Label();
            this.lblmaterias = new System.Windows.Forms.Label();
            this.lblGrupos = new System.Windows.Forms.Label();
            this.dgvasignacion = new System.Windows.Forms.DataGridView();
            this.cmbprofesor = new System.Windows.Forms.ComboBox();
            this.cmbmaterias = new System.Windows.Forms.ComboBox();
            this.cmbgrupos = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvasignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprofesores
            // 
            this.lblprofesores.AutoSize = true;
            this.lblprofesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofesores.Location = new System.Drawing.Point(97, 36);
            this.lblprofesores.Name = "lblprofesores";
            this.lblprofesores.Size = new System.Drawing.Size(93, 25);
            this.lblprofesores.TabIndex = 0;
            this.lblprofesores.Text = "Profesor";
            // 
            // lblmaterias
            // 
            this.lblmaterias.AutoSize = true;
            this.lblmaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaterias.Location = new System.Drawing.Point(96, 88);
            this.lblmaterias.Name = "lblmaterias";
            this.lblmaterias.Size = new System.Drawing.Size(95, 25);
            this.lblmaterias.TabIndex = 1;
            this.lblmaterias.Text = "Materias";
            // 
            // lblGrupos
            // 
            this.lblGrupos.AutoSize = true;
            this.lblGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupos.Location = new System.Drawing.Point(98, 145);
            this.lblGrupos.Name = "lblGrupos";
            this.lblGrupos.Size = new System.Drawing.Size(82, 25);
            this.lblGrupos.TabIndex = 2;
            this.lblGrupos.Text = "Grupos";
            // 
            // dgvasignacion
            // 
            this.dgvasignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvasignacion.Location = new System.Drawing.Point(40, 275);
            this.dgvasignacion.Name = "dgvasignacion";
            this.dgvasignacion.RowTemplate.Height = 28;
            this.dgvasignacion.Size = new System.Drawing.Size(603, 150);
            this.dgvasignacion.TabIndex = 3;
            this.dgvasignacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvasignacion_CellDoubleClick);
            // 
            // cmbprofesor
            // 
            this.cmbprofesor.FormattingEnabled = true;
            this.cmbprofesor.Location = new System.Drawing.Point(221, 37);
            this.cmbprofesor.Name = "cmbprofesor";
            this.cmbprofesor.Size = new System.Drawing.Size(340, 28);
            this.cmbprofesor.TabIndex = 4;
            // 
            // cmbmaterias
            // 
            this.cmbmaterias.FormattingEnabled = true;
            this.cmbmaterias.Location = new System.Drawing.Point(221, 88);
            this.cmbmaterias.Name = "cmbmaterias";
            this.cmbmaterias.Size = new System.Drawing.Size(340, 28);
            this.cmbmaterias.TabIndex = 5;
            // 
            // cmbgrupos
            // 
            this.cmbgrupos.FormattingEnabled = true;
            this.cmbgrupos.Location = new System.Drawing.Point(221, 142);
            this.cmbgrupos.Name = "cmbgrupos";
            this.cmbgrupos.Size = new System.Drawing.Size(340, 28);
            this.cmbgrupos.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(541, 447);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(70, 53);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(355, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 53);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(221, 447);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 53);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(77, 447);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 53);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(245, 227);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(244, 26);
            this.txtbuscar.TabIndex = 44;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(152, 227);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(59, 20);
            this.lblbuscar.TabIndex = 45;
            this.lblbuscar.Text = "Buscar";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(117, 227);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 20);
            this.lblid.TabIndex = 46;
            this.lblid.Text = "0";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(507, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 43);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cmbgrupos);
            this.Controls.Add(this.cmbmaterias);
            this.Controls.Add(this.cmbprofesor);
            this.Controls.Add(this.dgvasignacion);
            this.Controls.Add(this.lblGrupos);
            this.Controls.Add(this.lblmaterias);
            this.Controls.Add(this.lblprofesores);
            this.Name = "Asignaciones";
            this.Text = "Asignaciones";
            this.Load += new System.EventHandler(this.Asignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvasignacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprofesores;
        private System.Windows.Forms.Label lblmaterias;
        private System.Windows.Forms.Label lblGrupos;
        private System.Windows.Forms.DataGridView dgvasignacion;
        private System.Windows.Forms.ComboBox cmbprofesor;
        private System.Windows.Forms.ComboBox cmbmaterias;
        private System.Windows.Forms.ComboBox cmbgrupos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button button1;
    }
}