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
    public partial class Frmcalificaiones : Form
    {
        private ProfesorManejador _profesormanejador;
        private MateriaManejador _materiaManejador;
        private AlumnoManejador _alumnoManejador;
        //private CalificacionesManejador _calificacionesManejador;
        public Frmcalificaiones()
        {
            InitializeComponent();
            _profesormanejador = new ProfesorManejador();
            _materiaManejador = new MateriaManejador();
            _alumnoManejador = new AlumnoManejador();
           // _calificacionesManejador = new CalificacionesManejador();

        }

        private void controlarbotones(bool nuevo, bool guardar, bool cancelar, bool eliminar)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnBorrar.Enabled = eliminar;
        }
        private void controlarcuadros(bool activar)
        {
            cmbalumnos.Enabled = activar;
            cmbprofesor.Enabled = activar;
            cmbmateria.Enabled = activar;
            txtcreditos.Enabled = activar;
           

        }
        private void limpiarcuadros()
        {

            cmbmateria.Text = "";
            cmbprofesor.Text = "";
            cmbprofesor.Text = "";
            txtcreditos.Text = "";

        }
        private void BuscarCalificacion(string filtro)
        {
            //dgvcalificaion.DataSource = _calificacionesManejador.GetCalificaciones(filtro);
        }

        private void Frmcalificaiones_Load(object sender, EventArgs e)
        {
            BuscarCalificacion("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            controlarbotones(false, true, true, true);
            controlarcuadros(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            try
            {
                GuardarCalifiacion();
                limpiarcuadros();
                BuscarCalificacion("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void GuardarCalifiacion()
        {
           /* _calificacionesManejador.Guardar(new Calificaciones
            {
                Idcalificaiones = Convert.ToInt32(lblid.Text),
                Fknumcontrol = Convert.ToInt32(cmbalumnos.Text),
                Fkidasignatura = Convert.ToInt32(cmbprofesor.Text),
                Fkidmateria = Convert.ToInt32(cmbmateria.Text),
                Creditos = Convert.ToInt32(lblid.Text),
                

            }

             );
             */
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

                    eliminacalifiicacion ();
                    BuscarCalificacion("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eliminacalifiicacion()
        {
            var id = dgvcalificaion.CurrentRow.Cells["idcalificaiones"].Value;
            //_calificacionesManejador.Eliminar(Convert.ToInt32(id));
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarCalificacion(txtbuscar.Text);
        }

        private void dgvcalificaion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarCalificacion("");
            ModificarCalifiacion(); 
        }

        private void ModificarCalifiacion()
        {
            lblid.Text = dgvcalificaion.CurrentRow.Cells["idcalificaiones"].Value.ToString();
            cmbalumnos.Text = dgvcalificaion.CurrentRow.Cells["fknumcontrol"].Value.ToString();
            cmbprofesor.Text = dgvcalificaion.CurrentRow.Cells["fkidasignatura"].Value.ToString();
            cmbmateria.Text = dgvcalificaion.CurrentRow.Cells["fkidmateria"].Value.ToString();
            txtbuscar.Text = dgvcalificaion.CurrentRow.Cells["creditos"].Value.ToString();
        }

        private void ExtraccionMaestro(string filtro)   
        {
            cmbprofesor.DataSource = _profesormanejador.GetProfesors(filtro); 
            cmbprofesor.ValueMember = "id"; 
            cmbprofesor.DisplayMember = "nombre"; 
        }
        private void ExtraccionAlumno(string filtro)   
        {
            cmbalumnos.DataSource = _alumnoManejador.GetAlumnos(filtro);
            cmbalumnos.ValueMember = "numcontrol";
            cmbalumnos.DisplayMember = "nombre";
        }
        private void ExtraccionMateria(string filtro)   
        {
            cmbmateria.DataSource = _materiaManejador.GetMaterias(filtro); 
            cmbmateria.ValueMember = "idmateria"; 
            cmbmateria.DisplayMember = "nombremateria"; 
        }

        private void cmbalumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtraccionAlumno("");
        }

        private void cmbprofesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtraccionMaestro("");
        }

        private void cmbmateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtraccionMateria("");
        }

        private void txtcreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
