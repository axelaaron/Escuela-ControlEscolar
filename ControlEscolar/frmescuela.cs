using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ControlEscolar;
using LogicaNegocio.ControlEscolar;
using System.IO;
namespace ControlEscolar
{
    public partial class frmescuela : Form
    {
        private EscuelaManejador _EscuelaManejador;
        private OpenFileDialog _imagenJpg;
        private OpenFileDialog _imagenPng;
        private string _ruta;
        //private Escuela _escuela;
        public frmescuela()
        {
            InitializeComponent();
            _EscuelaManejador = new EscuelaManejador();
            _imagenJpg = new OpenFileDialog();
            _imagenPng = new OpenFileDialog();
            _ruta = Application.StartupPath + "\\Logo\\";
        }

        
        private void controlarbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
        }
        private void controlarcuadros(bool activar)
        {
            txtnombreescuela.Enabled = activar;
            txtrfc.Enabled = activar;
            txtdomicilio.Enabled = activar;
            txttelefono.Enabled = activar;
            txtcorreo.Enabled = activar;
            txtnombredirector.Enabled = activar;
            txtpaginaweb.Enabled = activar;
           
        }
        private void limpiarcuadros()
        {
            lblnum.Text = "0";
            txtnombreescuela.Text = "";
            txtrfc.Text = "";
            txtdomicilio.Text = "";
            txttelefono.Text = "";
            txtcorreo.Text = "";
            txtnombredirector.Text = "";
            txtpaginaweb.Text = "";
            

        }

        private void frmescuela_Load(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
            Buscarescuela("");
            dgvescuela.Visible = false;
        }
        private void Buscarescuela(string filtro)
        {
            dgvescuela.DataSource = _EscuelaManejador.GetEscuelas(filtro);
        }
        private void guardarusuario()
        {
            //_EscuelaManejador.Guardar(_escuela);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modificarescuela();
            controlarbotones(false, true, true, true);
            controlarcuadros(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            
            try
            {
                
                guardarescuela();
                limpiarcuadros();
                Buscarescuela("");
                GuardrImagenJpg();
           
                
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
           
          
        }

        private void guardarescuela()
        {
            _EscuelaManejador.Guardar(new Escuela
            {
                Idescuela = Convert.ToInt32(lblnum.Text),
                Nombreescuela = txtnombreescuela.Text,
                Rfc = txtrfc.Text,
                Domicilio = txtdomicilio.Text,
                Telefono = txttelefono.Text,
                Correo = txtcorreo.Text,
                Paginaweb = txtpaginaweb.Text,
                Nombredirector = txtnombredirector.Text,
                Logo = txtimg.Text,
                


            }

               );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Buscarescuela("");
            if (MessageBox.Show("Estas Seguro que deaseas eliminar este registo", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminarescuela();
                    Buscarescuela("");
                    Eliminarlogo();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eliminarescuela()
        {
            var ida = dgvescuela.CurrentRow.Cells["idescuela"].Value;
            _EscuelaManejador.Eliminar(Convert.ToInt32(ida));
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscarescuela(txtbuscar.Text);
        }

        private void dgvescuela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                modificarescuela();
                Buscarescuela("");
           
        }

        private void modificarescuela()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblnum.Text = dgvescuela.CurrentRow.Cells["idescuela"].Value.ToString();
            txtnombreescuela.Text = dgvescuela.CurrentRow.Cells["nombreescuela"].Value.ToString();
            txtrfc.Text = dgvescuela.CurrentRow.Cells["rfc"].Value.ToString();
            txtdomicilio.Text = dgvescuela.CurrentRow.Cells["domicilio"].Value.ToString();
            txttelefono.Text = dgvescuela.CurrentRow.Cells["telefono"].Value.ToString();
            txtcorreo.Text = dgvescuela.CurrentRow.Cells["correo"].Value.ToString();
            txtpaginaweb.Text = dgvescuela.CurrentRow.Cells["paginaweb"].Value.ToString();
            txtnombredirector.Text = dgvescuela.CurrentRow.Cells["nombredirector"].Value.ToString();
            txtimg.Text = dgvescuela.CurrentRow.Cells["logo"].Value.ToString();

            var logo = dgvescuela.CurrentRow.Cells["logo"].Value.ToString();
            string direccion = _ruta + logo;

            pictureBox1.ImageLocation = direccion;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
       
        private void CargarImaenJpg()
        {
            _imagenJpg.Filter = "Imagen tipo (*.jpg)|*.jpg|Imagen tipo (*.png)|*.png";
            _imagenJpg.Title = "Cargar Imagen";
            _imagenJpg.ShowDialog();

            pictureBox1.ImageLocation = _imagenJpg.FileName;


            if (_imagenJpg.FileName != "")
            {
                var archivo = new FileInfo(_imagenJpg.FileName);
                txtimg.Text = archivo.Name;
                pictureBox1.Text = archivo.Name;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (archivo.Length > 5000000)
                {
                    MessageBox.Show("Advertencia Tu Logo Sobre Pasa los 5mb");
                }
                else
                {
                    MessageBox.Show("imagen Cargada Exitosamente");
                }
            }

        }
       
        public void cargacion()
        {
            _imagenJpg.Filter = "Imagen tipo (*.jpg)|*.jpg | Imagen tipo  (*.png) | *.png";
        }
        
        private void GuardrImagenJpg()
        {
            cargacion();
            try
            {
                if (_imagenJpg.FileName != null)
                {

                    if (_imagenJpg.FileName != "")
                    {
                        var archivo = new FileInfo(_imagenJpg.FileName);
                        if (Directory.Exists(_ruta))
                        {
                            if (Directory.Exists(_ruta) == false)
                            {
                                var optenerArchivos = Directory.GetFiles(_ruta, _imagenJpg.Filter);
                                FileInfo archivoAnterior;
                                if (optenerArchivos.Length != 0)
                                {
                                    archivoAnterior = new FileInfo(optenerArchivos[0]);
                                    if (archivoAnterior.Exists)
                                    {
                                        archivoAnterior.Delete();
                                        archivo.CopyTo(_ruta + archivo.Name);
                                    }

                                }
                                else
                                {
                                    archivo.CopyTo(_ruta + archivo.Name);

                                }
                            }
                            else
                            {
                                Directory.CreateDirectory(_ruta);
                                archivo.CopyTo(_ruta + archivo.Name);
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {

                
            }
            
        }

        private void EliminarImagenJpg()
        {
            txtimg.Text = "";
            pictureBox1.Image = null;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarImaenJpg();
            
            
        }

        private void btnGuardarLogo_Click(object sender, EventArgs e)
        {
            GuardrImagenJpg();
            MessageBox.Show("Logo Guardado Con Exito");
            
        }

        private void btnEliminarLogo_Click(object sender, EventArgs e)
        {
            EliminarImagenJpg();

        }
        public void Eliminarlogo()
        {
            string _ruta = @"C:\Users\zocre\Desktop\tec\5 semestre\Taller de Base De Datos\ControlEscolar\ControlEscolar\bin\Debug\Logo" + txtimg.Text + "";
            if (MessageBox.Show("Estas Seguro De Eliminar Logo", "Eliminar Logo ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

    }
}
