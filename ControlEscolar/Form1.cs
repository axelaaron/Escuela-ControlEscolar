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

namespace ControlEscolar
{
    public partial class frmUsuario : Form
    {

        private UsuarioManejador _usuarioManejador;
        private Usuario _usuario;

        public frmUsuario()
        {
            InitializeComponent();
            _usuarioManejador = new UsuarioManejador();
            _usuario = new Usuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarUsuarios("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }
        private void controlarbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnnuevo.Enabled = nuevo;
            btnguardar.Enabled = guardar;
            btncancelar.Enabled = cancelar;
            btneliminar.Enabled = eliminar;
        }
        private void controlarcuadros(bool activar)
        {
            txtnombre.Enabled = activar;
            txtapellidop.Enabled = activar;
            txtapellidom.Enabled = activar;
            txtcontrasenia.Enabled = activar;
        }
        private void limpiarcuadros()
        {
            txtnombre.Text = "";
            txtapellidop.Text = "";
            txtapellidom.Text = "";
            txtcontrasenia.Text = "";
        }
        private void BuscarUsuarios(string filtro)
        {
            dtgUsuarios.DataSource = _usuarioManejador.GetUsuarios(filtro);

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            controlarbotones(false, true, true, false);
            controlarcuadros(true);
            txtnombre.Focus();
        }

        private bool validarusuario()
        {
            var tuple = _usuarioManejador.ValidarUsuario(_usuario);

            var valido = tuple.Item1;
            var mensaje = tuple.Item2;
            if (!valido)
            {
                MessageBox.Show(mensaje, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valido;
                
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            cargarusuario();

            if (validarusuario())
            {
                controlarbotones(true, false, false, true);
                controlarcuadros(false);
                try
                {
                    
                    guardarusuario();
                    limpiarcuadros();
                    BuscarUsuarios("");
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message);
                } 
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }
        private void cargarusuario()
        {
            _usuario.Idusuario = Convert.ToInt32(lblID.Text);
            _usuario.Nombre = txtnombre.Text;
            _usuario.ApellidoPaterno = txtapellidop.Text;
            _usuario.ApellidoMaterno = txtapellidom.Text;
            _usuario.Contrasenia = txtcontrasenia.Text;

        }
        private void guardarusuario()
        {
            _usuarioManejador.Guardar(_usuario);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que deaseas eliminar este registo","Eliminar Registro",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                try
                {
                    eliminarusuario();
                    BuscarUsuarios("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
          
        }
        private void eliminarusuario()
        {
            var Idusuario = dtgUsuarios.CurrentRow.Cells["Idusuario"].Value;
            _usuarioManejador.Eliminar(Convert.ToInt32(Idusuario));
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios(txtbuscar.Text);
        }

        private void dtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ModificarUsuario();
                BuscarUsuarios("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ModificarUsuario()

        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblID.Text = dtgUsuarios.CurrentRow.Cells["Idusuario"].Value.ToString();
            txtnombre.Text = dtgUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtapellidop.Text = dtgUsuarios.CurrentRow.Cells["ApellidoPaterno"].Value.ToString();
            txtapellidom.Text = dtgUsuarios.CurrentRow.Cells["ApellidoMaterno"].Value.ToString();
            txtcontrasenia.Text = dtgUsuarios.CurrentRow.Cells["Contrasenia"].Value.ToString();

        }
    }
}
