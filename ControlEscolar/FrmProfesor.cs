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

using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class FrmProfesor : Form
    {
        private ProfesorManejador _profesormanejador;
        public FrmProfesor()
        {
            InitializeComponent();
            _profesormanejador = new ProfesorManejador();
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
            txtnumcont.Enabled = activar;
            txtnom.Enabled = activar;
            txtap.Enabled = activar;
            txtam.Enabled = activar;
            txtdire.Enabled = activar;
            txtnumced.Enabled = activar;
            txttitulo.Enabled = activar;
            
        }
        private void limpiarcuadros()
        {
            lblid.Text = "0";
            txtnumcont.Text = "";
           
            txtnom.Text = "";
            txtap.Text = "";
            txtam.Text = "";
            txtdire.Text = "";
            txtnumced.Text = "";
            txttitulo.Text = "";
            dtpfecha.Text = "";

        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            Buscarprofesor("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
            EstadosManejador _estadosmanejador = new EstadosManejador();
            _estadosmanejador.GetEstados(cmbestados);
        }

        /*public void getID(string filtro)
        {
            cmbid.DataSource = _profesormanejador.idprofesor(filtro);
            cmbid.DisplayMember = "Nextincremento";

            if(cmbid.Text =="")
            {
                lblid2.Text = "D" +  cmbanio.Text + 1;
            }
            else
            {
                lblid2.Text = "D" + cmbanio.Text + 1 + cmbid.Text;
            }
        }*/
        private void Buscarprofesor(string filtro)
        {
            dgvProfesor.DataSource = _profesormanejador.GetProfesors(filtro);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlarbotones(false, true, true, false);
            controlarcuadros(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            try
            {
                guardarprofesor();
                limpiarcuadros();
                Buscarprofesor("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }
        private void guardarprofesor()
        {
            _profesormanejador.Guardar(new Profesor
            {
                Id = Convert.ToInt32(lblid.Text),
                Idprofesor = Convert.ToInt32(lblid2.Text),
                Numerocontrol = txtnumcont.Text,
                Nombre = txtnom.Text,
                Apellidopaterno = txtap.Text,
                Apellidometarno = txtam.Text,
                Direccion = txtdire.Text,
                Estado = cmbestados.Text,
                Municipio = cmbciudades.Text,
                Numerocedula = Convert.ToInt32(txtnumced.Text),
                Titulo = txttitulo.Text,
                Fechadenacimiento = dtp1.Text

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
            if (MessageBox.Show("Estas Seguro que deaseas eliminar este registo", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                { 
               
                    eliminarprofesor();
                    Buscarprofesor("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void eliminarprofesor()
        {
            var id = dgvProfesor.CurrentRow.Cells["id"].Value;
            _profesormanejador.Eliminar(Convert.ToInt32(id));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Buscarprofesor(textBox8.Text);
        }

        private void dgvProfesor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Buscarprofesor("");
            Modificarprofe();


        }

        private void Modificarprofe()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblid.Text = dgvProfesor.CurrentRow.Cells["id"].Value.ToString();
            //lblid2.Text = dgvProfesor.CurrentRow.Cells["idincrementable"].Value.ToString();
            txtnumcont.Text = dgvProfesor.CurrentRow.Cells["numerocontrol"].Value.ToString();
            txtnom.Text = dgvProfesor.CurrentRow.Cells["nombre"].Value.ToString();
            txtap.Text = dgvProfesor.CurrentRow.Cells["apellidop"].Value.ToString();
            txtam.Text = dgvProfesor.CurrentRow.Cells["apellidom"].Value.ToString();
            txtdire.Text = dgvProfesor.CurrentRow.Cells["definicion"].Value.ToString();
            cmbestados.Text = dgvProfesor.CurrentRow.Cells["fkestados"].Value.ToString();
            cmbciudades.Text = dgvProfesor.CurrentRow.Cells["ffkmunicipios"].Value.ToString();
            txtnumced.Text = dgvProfesor.CurrentRow.Cells["numerocedula"].Value.ToString();
            txttitulo.Text = dgvProfesor.CurrentRow.Cells["titulo"].Value.ToString();
            //dtpfecha.Text = dgvProfesor.CurrentRow.Cells["fechanaci"].Value.ToString();
           


        }

        private void cmbmunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbestados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MunicipiosManejador _municipiosmanejador = new MunicipiosManejador();
            _municipiosmanejador.GetMunicipios(cmbciudades, cmbestados);
        }

        private void btnestudios_Click(object sender, EventArgs e)
        {
            Frmmaterias ma = new Frmmaterias();
            ma.ShowDialog();
        }

        private void cmbanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getID(cmbanio.Text);
        }
        public void iDD()
        {
            try
            {
                string anio = dtp1.Value.ToString("yyyy");
                string max = (from DataGridViewRow row in dgvProfesor.Rows
                              where row.Cells[1].FormattedValue.ToString().Contains(anio)
                              select (row.Cells[1].FormattedValue)).Max().ToString().Substring(5);
                int n = int.Parse(max) + 1;
                if (int.Parse(max) < 10)
                {
                    txtnumcont.Text = "D" + dtp1.Value.ToString("yyyy") + "0" + n.ToString();
                }
                else
                {
                    txtnumcont.Text = "D" + dtp1.Value.ToString("yyyy") + (int.Parse(max) + 1).ToString();
                }

            }
            catch (Exception)
            {

                txtnumcont.Text = "D" + dtp1.Value.ToString("yyyy") + "1";
             
            }
           
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            iDD();
        }

        

        private void txtnumcont_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
