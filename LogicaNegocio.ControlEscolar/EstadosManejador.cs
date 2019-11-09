using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.ControlEscolar;
using Entidades.ControlEscolar;

namespace LogicaNegocio.ControlEscolar
{
    public class EstadosManejador
    {
        private EstadoAccesoDatos _estadosaccesoadatos = new EstadoAccesoDatos();
        public List<Estados> GetEstados(ComboBox cm)
        {
            var listAlumno = _estadosaccesoadatos.GetEstados(cm);
            
            return listAlumno;
        }
    }
}
