﻿using System;
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
    public partial class frmAlumnos : Form
    {
        private AlumnoManejador _alumnoManejador;
        private GrupoManejador _grupoManejador;
        public frmAlumnos()
        {
            InitializeComponent();
            _alumnoManejador = new AlumnoManejador();
            _grupoManejador = new GrupoManejador();
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
            txtnom.Enabled = activar;
            txtap.Enabled = activar;
            txtam.Enabled = activar;
            dtpfecha.Enabled = activar;
            txtdom.Enabled = activar;
            txtemail.Enabled = activar;
            txtsexo.Enabled = activar;
        }
        private void limpiarcuadros()
        {
            lblnum.Text = "0";
            txtnom.Text = "";
            txtap.Text = "";
            txtam.Text = "";
            dtpfecha.Text = "";
            txtdom.Text = "";
            txtemail.Text = "";
            txtsexo.Text = "";
            

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            Buscaralumno("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
            EstadosManejador _estadosmanejador = new EstadosManejador();
            _estadosmanejador.GetEstados(cmbestados);

            GrupoManejador _grupomanejador = new GrupoManejador();
            _grupomanejador.GetGrupos2(cmbgrupo);
        }
        private void Buscaralumno(string filtro)
        {
            dgvalumnos.DataSource = _alumnoManejador.GetAlumnos2(filtro);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            controlarbotones(false, true, true, false);
            controlarcuadros(true);
            txtnom.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            try
            {
                guardaralumno();
                limpiarcuadros();
                Buscaralumno("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }
        private void guardaralumno()
        {
            _alumnoManejador.Guardar(new Alumnos
            {
                Numcontrol = Convert.ToInt32(lblnum.Text),
                Nombre = txtnom.Text,
                Apellidopaterno = txtap.Text,
                Apellidomaterno = txtam.Text,
                Fecha = dtpfecha.Text,
                Domicilio = txtdom.Text,
                Email = txtemail.Text,
                Sexo = txtsexo.Text,
                Fkestados = cmbestados.Text,
                Fkmunicipios = cmbciudades.Text,
                Fkgrupo = cmbgrupo.SelectedValue.ToString()



            }

                );
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro que deaseas eliminar este registo", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    eliminaralumno();
                    Buscaralumno("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void eliminaralumno()
        {
            var ida = dgvalumnos.CurrentRow.Cells["numcontrol"].Value;
            _alumnoManejador.Eliminar(Convert.ToInt32(ida));
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Buscaralumno(txtbuscar.Text);
        }

        private void dgvalumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificaralumno();
                Buscaralumno("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Modificaralumno()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblnum.Text = dgvalumnos.CurrentRow.Cells["numcontrol"].Value.ToString();
            txtnom.Text = dgvalumnos.CurrentRow.Cells["nombre"].Value.ToString();
            txtap.Text = dgvalumnos.CurrentRow.Cells["apellidopaterno"].Value.ToString();
            txtam.Text = dgvalumnos.CurrentRow.Cells["apellidomaterno"].Value.ToString();
            //dtpfecha.Text = dgvalumnos.CurrentRow.Cells["fechadenacimiento"].Value.ToString();
            txtdom.Text = dgvalumnos.CurrentRow.Cells["domicilio"].Value.ToString();
            txtemail.Text = dgvalumnos.CurrentRow.Cells["email"].Value.ToString();
            txtsexo.Text = dgvalumnos.CurrentRow.Cells["sexo"].Value.ToString();
            cmbestados.Text = dgvalumnos.CurrentRow.Cells["fkestados"].Value.ToString();
            cmbciudades.Text = dgvalumnos.CurrentRow.Cells["fkmunicipios"].Value.ToString();
            cmbgrupo.Text = dgvalumnos.CurrentRow.Cells["fkgrupo"].Value.ToString();

        }

        private void cbmestados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MunicipiosManejador _municipiosmanejador = new MunicipiosManejador();
            _municipiosmanejador.GetMunicipios(cmbciudades, cmbestados);
        }

        private void cmbciudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngrupo_Click(object sender, EventArgs e)
        {
            
        }
        public void codigo(string filtro)
        {
            cmbgrupo.DataSource = _grupoManejador.GetGrupos(filtro);
            cmbgrupo.ValueMember = "idgrupo";
            cmbgrupo.DisplayMember = "grupo";
        }

        private void cmbgrupo_Click(object sender, EventArgs e)
        {
            codigo("");
        }

        private void cmbgrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            //codigo("");
        }
    }
}
