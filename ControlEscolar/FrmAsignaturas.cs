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
    public partial class FrmAsignaturas : Form
    {
       
        private MateriaDosManejador _materiaDosManejador;
       
        public FrmAsignaturas()
        {
            InitializeComponent();
            
            _materiaDosManejador = new MateriaDosManejador();
        }

        private void lblsemestre_Click(object sender, EventArgs e)
        {

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
            txtidmateria.Enabled = activar;
            txtnombremateria.Enabled = activar;
            txthorast.Enabled = activar;
            txthorasp.Enabled = activar;
            txtsemestre.Enabled = activar;
            txtcarrera.Enabled = activar;

        }
        private void limpiarcuadros()
        {
            txtidmateria.Text = "";
            txtnombremateria.Text = "";
            txthorast.Text = "";
            txthorasp.Text = "";
            cmbanterior.Text = "";
            cmbsiguiente.Text = "";
            txtsemestre.Text = "";
            txtcarrera.Text = "";
         

        }
        private void BuscarAsignatura(string filtro)
        {
            dgvasignatura.DataSource = _materiaDosManejador.GetMateriaDos(filtro);

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

                GuardarAsignarua();
                limpiarcuadros();
                BuscarAsignatura("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void GuardarAsignarua()
        {
            _materiaDosManejador.Guardar(new MateriaDos
            {
                Id = Convert.ToInt32(lblid.Text),
                Idmaterias = txtidmateria.Text,
                Nombre = txtnombremateria.Text,
                Horast = Convert.ToInt32(txthorast.Text),
                Horasp = Convert.ToInt32(txthorasp.Text),
                Fkmateriaanterior = cmbanterior.Text,
                Fkmateriaquesigue = cmbsiguiente.Text,
                Semestre = Convert.ToInt32(txtsemestre.Text),
                Creditos = Convert.ToInt32(txtcarrera.Text),

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

                    eliminarasignatura();
                    BuscarAsignatura("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eliminarasignatura()
        {
            var id = dgvasignatura.CurrentRow.Cells["id"].Value;
            _materiaDosManejador.Eliminar(Convert.ToInt32(id));
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAsignatura(txtbuscar.Text);
        }

        private void dgvasignatura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarAsignatura();
            BuscarAsignatura("");
        }

        private void ModificarAsignatura()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblid.Text = dgvasignatura.CurrentRow.Cells["id"].Value.ToString();
            //txtidmateria.Text = dgvasignatura.CurrentRow.Cells["idmateriados"].Value.ToString();
            txtnombremateria.Text = dgvasignatura.CurrentRow.Cells["nombre"].Value.ToString();
            txthorast.Text = dgvasignatura.CurrentRow.Cells["horast"].Value.ToString();
            txthorasp.Text = dgvasignatura.CurrentRow.Cells["horasp"].Value.ToString();
            cmbanterior.Text = dgvasignatura.CurrentRow.Cells["fkmateriaanterior"].Value.ToString();
            cmbsiguiente.Text = dgvasignatura.CurrentRow.Cells["fkmateriaquesigue"].Value.ToString();
            txtsemestre.Text = dgvasignatura.CurrentRow.Cells["semestre"].Value.ToString();
            txtcarrera.Text = dgvasignatura.CurrentRow.Cells["creditos"].Value.ToString();

        }

        private void FrmAsignaturas_Load(object sender, EventArgs e)
        {
            BuscarAsignatura("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
            MateriaDosManejador _materiaDosManejador = new MateriaDosManejador();
            _materiaDosManejador.getanterior(cmbanterior);
            _materiaDosManejador.getanterior(cmbsiguiente);
        }
        private void materiaanterior(string filtro)
        {
            //cmbanterior.DataSource = _materiaDosManejador.GetMateriaDos(filtro);
            //cmbanterior.ValueMember = "id";
            //cmbanterior.DisplayMember = "idmateriados";
        }

        private void cmbanterior_SelectedIndexChanged(object sender, EventArgs e)
        {
            //materiaanterior("");
        }

        private void cmbsiguiente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void total(string horast, string horasp )
        {
            int calculo = 0;

            if(txthorast.Text !="" && txthorasp.Text != "")
            {
                calculo = int.Parse(horast) + int.Parse(horasp);
                txtcarrera.Text = calculo.ToString();
            }
        }

        private void txthorast_TextChanged(object sender, EventArgs e)
        {
            total(txthorast.Text, txthorasp.Text);
        }

        private void txthorasp_TextChanged(object sender, EventArgs e)
        {
            total(txthorast.Text, txthorasp.Text);
        }
    }
}
