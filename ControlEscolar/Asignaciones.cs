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
    public partial class Asignaciones : Form
    {
        private AsignacionManejador _asignacionManejador;
        private GrupoManejador _grupoManejador;
        private MateriaDosManejador _materiaDosManejador;
        private ProfesorManejador _profesormanejador;
        public Asignaciones()
        {
            InitializeComponent();
            _grupoManejador = new GrupoManejador();
            _materiaDosManejador = new MateriaDosManejador();
            _profesormanejador = new ProfesorManejador();
            _asignacionManejador = new AsignacionManejador();
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
            cmbprofesor.Enabled = activar;
            cmbmaterias.Enabled = activar;
            cmbgrupos.Enabled = activar;
            
        }
        private void limpiarcuadros()
        {
            lblid.Text = "0";
            cmbprofesor.Text = "";
            cmbmaterias.Text = "";
            cmbgrupos.Text = "";
           


        }

        private void Asignaciones_Load(object sender, EventArgs e)
        {
            Buscarasignacion("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();

            ProfesorManejador _profesorManejador = new ProfesorManejador();
            _profesorManejador.GetProfesors2(cmbprofesor);

            MateriaDosManejador _materiaDosManejador = new MateriaDosManejador();
            _materiaDosManejador.Getmateriados(cmbmaterias);
            GrupoManejador _grupomanejador = new GrupoManejador();
            _grupomanejador.GetGrupos2(cmbgrupos);
        }

        private void Buscarasignacion(string filtro)
        {
            dgvasignacion.DataSource = _asignacionManejador.GetAsignacions(filtro);
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
                guardarasignacion();
                limpiarcuadros();
                Buscarasignacion("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void guardarasignacion()
        {
            _asignacionManejador.Guardar(new Asignacion
            {
                Idasignacion = Convert.ToInt32(lblid.Text),
                Profesor1 = cmbprofesor.Text,
                Materia1 = cmbmaterias.Text,
                Grupo1 = cmbgrupos.Text

            });
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
                    eliminarasignacion();
                    Buscarasignacion("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eliminarasignacion()
        {
            var ida = dgvasignacion.CurrentRow.Cells["idasignacion"].Value;
            _asignacionManejador.Eliminar(Convert.ToInt32(ida));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Buscarasignacion(txtbuscar.Text);
        }

        private void dgvasignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificarasignacion();
                Buscarasignacion("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Modificarasignacion()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblid.Text = dgvasignacion.CurrentRow.Cells["idasignacion"].Value.ToString();
            cmbprofesor.Text = dgvasignacion.CurrentRow.Cells["fkprofesro"].Value.ToString();
            cmbmaterias.Text = dgvasignacion.CurrentRow.Cells["fkmateria"].Value.ToString();
            cmbgrupos.Text = dgvasignacion.CurrentRow.Cells["fkgrupo"].Value.ToString();
        }

    }
}
