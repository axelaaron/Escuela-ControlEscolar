using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using LogicaNegocio.ControlEscolar;
using System.IO;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class Frmmaterias : Form
    {
        private MateriaManejador _materiasmanejador;
        private ProfesorManejador _profesormanejador;
        private OpenFileDialog _archivopdf;
        private string _ruta2;
        
        public Frmmaterias()
        {
            InitializeComponent();
            _materiasmanejador = new MateriaManejador();
            _profesormanejador = new ProfesorManejador();  
            _archivopdf = new OpenFileDialog();
            _ruta2 = Application.StartupPath + "\\pdf\\";
           
        }

        private void controlarbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            
        }
        private void controlarcuadros(bool activar)
        {
            cmbcodigo.Enabled = activar;
            txttitulo.Enabled = activar;
            txtnombre.Enabled = activar;


        }
        private void limpiarcuadros()
        {
            cmbcodigo.Text = "";
            txttitulo.Text = "";
            txtnombre.Text = "";
            LBL1.Text = "0";

        }
        private void Codigo(string filtro)
        {
            cmbcodigo.DataSource = _profesormanejador.GetProfesors(filtro);
            cmbcodigo.ValueMember = "id";
            cmbcodigo.DisplayMember = "nombre";
        }
        private void Frmmaterias_Load(object sender, EventArgs e)
        {
            BuscarEstudio("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }

        private void BuscarEstudio(string filtro)
        {
            dgvestudios.DataSource = _materiasmanejador.GetMaterias(filtro);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlarbotones(false, true, true, false);
            controlarcuadros(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardarestudio();
            BuscarEstudio("");
            GuardarArchivoPdf();
        }

        private void Guardarestudio()
        {
            _materiasmanejador.Guardar(new Materias
            {
                Idestudios = Convert.ToInt32(LBL1.Text),
                Fkprofesor = int.Parse(cmbcodigo.SelectedValue.ToString()),
                Titulo = txttitulo.Text,
                Nombre = txtnombre.Text,
                Nombrearchivo = txtjpg.Text,



            }
                 );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que deaseas eliminar este registo", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    EliminarArchivoPDF();
                   
                    eliminarestudio();
                    BuscarEstudio("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eliminarestudio()
        {
            var id = dgvestudios.CurrentRow.Cells["idestudios"].Value;
            _materiasmanejador.Eliminar(Convert.ToInt32(id));
        }

        private void dgvestudios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificarestudio();
            BuscarEstudio("");
        }
        public void Modificarestudio()
        {
            
            LBL1.Text = dgvestudios.CurrentRow.Cells["idestudios"].Value.ToString();
            cmbcodigo.Text = dgvestudios.CurrentRow.Cells["fkprofesor"].Value.ToString();
            lbltitulo.Text = dgvestudios.CurrentRow.Cells["tiutlo"].Value.ToString();
            lblnombre.Text = dgvestudios.CurrentRow.Cells["nombre"].Value.ToString();
            txtjpg.Text = dgvestudios.CurrentRow.Cells["nombredelarchivo"].Value.ToString();
            
        }

        private void cmbcodigo_Click(object sender, EventArgs e)
        {
            Codigo("");
        }


        private void cargarArchivopdf()
        {
            _archivopdf.Filter = "Archivo tipo (*.pdf)|*.pdf";
            _archivopdf.Title = "Cargar Archivo Pdf";
            _archivopdf.ShowDialog();
            if (_archivopdf.FileName != "")
            {
                var archivo = new FileInfo(_archivopdf.FileName);
                txtjpg.Text = archivo.Name;
            }
        }
        private void GuardarArchivoPdf()
        {
            if (_archivopdf.FileName != null)
            {
                if (_archivopdf.FileName != "")
                {
                    var archivo = new FileInfo(_archivopdf.FileName);
                    if (Directory.Exists(_ruta2))
                    {

                        var optenerArchivos2 = Directory.GetFiles(_ruta2, "*.pdf");
                        FileInfo archivoAnterior2;
                        if (optenerArchivos2.Length != 0)
                        {

                            archivoAnterior2 = new FileInfo(optenerArchivos2[0]);
                            if (archivoAnterior2.Exists)
                            {
                               
                                archivo.CopyTo(_ruta2 + archivo.Name);
                            }
                        }
                        else
                        {
                            archivo.CopyTo(_ruta2 + archivo.Name);
                        }

                    }
                    else
                    {
                        Directory.CreateDirectory(_ruta2);
                        archivo.CopyTo(_ruta2 + archivo.Name);
                    }
                }
            }
        }



       
        private void EliminarArchivoPDF()
        {

            string _ruta = @"C:\Users\zocre\Desktop\5semestre\Taller de Base De Datos\ControlEscolar\ControlEscolar\bin\Debug\pdf\"+txtjpg.Text+"";
            if (MessageBox.Show("Estas Seguro De Eliminar Archivo Pdf", "Eliminar PDF ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                /*
                var optenerArchivos2 = Directory.GetFiles(_ruta2, "*.pdf");
                FileInfo archivoAnterior2;
                if (optenerArchivos2.Length != 0)
                {

                    archivoAnterior2 = new FileInfo(optenerArchivos2[0]);
                    if (archivoAnterior2.Exists)
                    {
                        archivoAnterior2.Delete();

                    }
                }
                */
                if (File.Exists(_ruta))
                {
                    File.Delete(_ruta);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarArchivopdf();
        }

        private void btnguardarar_Click(object sender, EventArgs e)
        {
            GuardarArchivoPdf();
            MessageBox.Show("Archivo Guardado");
        }
        public void cargardatos()
        {
            LBL1.Text = dgvestudios.CurrentRow.Cells["idestudios"].Value.ToString();
            cmbcodigo.Text = dgvestudios.CurrentRow.Cells["fkprofesor"].Value.ToString();
          //  txttitulo.Text = dgvestudios.CurrentRow.Cells["tiutlo"].Value.ToString();
            txtjpg.Text = dgvestudios.CurrentRow.Cells["Nombrearchivo"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvestudios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargardatos();
        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
