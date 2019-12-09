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
using Microsoft.Office.Interop.Excel;


namespace ControlEscolar
{
    public partial class FrmCalificaciones : Form
    {
        private CalificacionesManejador _calificacionesManejador;
        private GrupoManejador _gp;
        private MateriaDosManejador _materiaDosManejador;
        public FrmCalificaciones()
        {
            InitializeComponent();
            _calificacionesManejador = new CalificacionesManejador();
            _gp = new GrupoManejador();
            _materiaDosManejador = new MateriaDosManejador();
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
            txtnombre.Enabled = activar;
            txtapellidop.Enabled = activar;
            txtapellidom.Enabled = activar;
            cmbmateria.Enabled = activar;
            txtparcialuno.Enabled = activar;
            txtparcial2.Enabled = activar;
            txtparcial3.Enabled = activar;
            txtparcial4.Enabled = activar;


        }
        private void limpiarcuadros()
        {
            lblID.Text = "0";
            txtnombre.Text = "";
            txtapellidop.Text = "";
            txtapellidom.Text = "";
            cmbmateria.Text = "";
            txtparcialuno.Text = "";
            txtparcial2.Text = "";
            txtparcial3.Text = "";
            txtparcial4.Text = "";




        }

        private void FrmCalificaciones_Load(object sender, EventArgs e)
        {
            Buscarcalificacion("");
            controlarbotones(true, false, false, true);
            controlarcuadros(false);
            limpiarcuadros();

            _materiaDosManejador.Getmateriados(cmbmateria);
            _gp.GetGrupos2(cbmgrupo);
        }
        private void Buscarcalificacion(string text)
        {
            dgvcalificaciones.DataSource = _calificacionesManejador.GetCalificaciones(text);
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
                guardarcalificacion();
                limpiarcuadros();
                Buscarcalificacion("");
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }
        }

        private void guardarcalificacion()
        {
            _calificacionesManejador.Guardar(new Calificaciones
            {
                Idcalificacion = Convert.ToInt32(lblid2.Text),
                Nombre = txtnombre.Text,
                Apellidopaterno = txtapellidop.Text,
                Apellidomaterno = txtapellidom.Text,
                Materia = cmbmateria.Text,
                Parcialuno = Convert.ToDouble(txtparcialuno.Text),
                Parcialdos = Convert.ToDouble(txtparcial2.Text),
                Parcialtres = Convert.ToDouble(txtparcial3.Text),
                Parcialcuatro = Convert.ToDouble(txtparcial4.Text),



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
                    eliminarcalificacion();
                    Buscarcalificacion("");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void eliminarcalificacion()
        {
            var ida = dgvcalificaciones.CurrentRow.Cells["idcalificaciones"].Value;
            _calificacionesManejador.Eliminar(Convert.ToInt32(ida));
        }

        private void dgvcalificaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modificarcalificacion();
                Buscarcalificacion("");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Modificarcalificacion()
        {
            controlarcuadros(true);
            controlarbotones(false, true, true, false);

            lblid2.Text = dgvcalificaciones.CurrentRow.Cells["idcalificaciones"].Value.ToString();
            txtparcialuno.Text = dgvcalificaciones.CurrentRow.Cells["parcialuno"].Value.ToString();
            txtparcial2.Text = dgvcalificaciones.CurrentRow.Cells["parcialdos"].Value.ToString();
            txtparcial3.Text = dgvcalificaciones.CurrentRow.Cells["parcialtres"].Value.ToString();
            txtparcial4.Text = dgvcalificaciones.CurrentRow.Cells["parcialcuatro"].Value.ToString();
        }
        private void Encontraralumno(string text)
        {
            dtgalumnos.DataSource = _gp.GetAlumnos2(text);
        }

        private void cbmgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Encontraralumno(cbmgrupo.Text);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportarDataGridviewExcel(dgvcalificaciones);
        }
        private void exportarDataGridviewExcel(object dtgcal)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Workbook libros_trabajo;
                    Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                    for (int i = 0; i < dgvcalificaciones.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvcalificaciones.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dgvcalificaciones.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("Reporte terminado", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fallo la creacion de archivo, intenta de nuevo con otro nombre");
            }

        }

        private void dtgalumnos_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = dtgalumnos.CurrentRow.Cells["Numcontrol"].Value.ToString();
            dgvcalificaciones.DataSource = _calificacionesManejador.GetCalificaciones(lblID.Text);
            //groupBox1.Visible = true;
            var id = dtgalumnos.CurrentRow.Cells["Numcontrol"].Value.ToString();
            var nombre = dtgalumnos.CurrentRow.Cells["Nombre"].Value.ToString();
            var apellidop = dtgalumnos.CurrentRow.Cells["Apellidopaterno"].Value.ToString();
            var apellidom = dtgalumnos.CurrentRow.Cells["Apellidomaterno"].Value.ToString();
            lblID.Text = id;
            txtnombre.Text = nombre;
            txtapellidop.Text = apellidop;
            txtapellidom.Text = apellidom;
        }
    }
}
