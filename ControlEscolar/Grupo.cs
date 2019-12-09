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
    public partial class Grupo : Form
    {
        private GrupoManejador _gp;
        private AlumnoManejador alumnoManejador;
        public Grupo()
        {
            InitializeComponent();
            _gp = new GrupoManejador();
            alumnoManejador = new AlumnoManejador();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            Buscargrupo("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
            GrupoManejador _grupomanejador = new GrupoManejador();
            _grupomanejador.GetGrupos2(cmbgrupo);

            alumnoManejador.GetAlumnos(cmbalumnos);


        }
        private void controlarbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
          
        }
        private void controlarcuadros(bool activar)
        {
           txtgrupo.Enabled = activar;
            

        }
        private void limpiarcuadros()
        {
           txtgrupo.Text = "";
            
     

        }
        private void Buscargrupo(string filtro)
        {
            dataGridView1.DataSource = _gp.GetAlumnos2(filtro);
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlarbotones(true, true, true, true);
            controlarcuadros(true);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlarcuadros(false);
            try
            {

                Guardargrupo();
                limpiarcuadros();
                Buscargrupo(" ");
                Buscargrupo("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void Guardargrupo()
        {
            _gp.Guardar(new Grupos
            {
                Idgrupo = Convert.ToInt32(lblid.Text),
                Grupo = txtgrupo.Text,
                

            }
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();

        }

        

        private void eliminaragrupo()
        {

            var id = dataGridView1.CurrentRow.Cells["idgrupo"].Value;
            _gp.Eliminar(Convert.ToInt32(id));
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modificargrupo();
            Buscargrupo("");
        }

        private void Modificargrupo()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);
            lblid.Text = dataGridView1.CurrentRow.Cells["idgrupo"].Value.ToString();
            txtgrupo.Text = dataGridView1.CurrentRow.Cells["grupo"].Value.ToString();
        }

        private void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscargrupo(cmbgrupo.Text);
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }
    }
}
