using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar
{
    public partial class frmpantallaescolar : Form
    {
        public frmpantallaescolar()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario u = new frmUsuario();
            u.ShowDialog();

                
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos a = new frmAlumnos();
            a.ShowDialog();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesor p = new FrmProfesor();
            p.ShowDialog();
        }
        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmescuela el = new frmescuela();
            el.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAsignaturas AS = new FrmAsignaturas();
            AS.ShowDialog();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frmcalificaiones cal = new Frmcalificaiones();
            //cal.ShowDialog();
        }
    }
}
