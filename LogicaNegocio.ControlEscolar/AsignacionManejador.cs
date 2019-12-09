using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
namespace LogicaNegocio.ControlEscolar
{
    public class AsignacionManejador
    {
        private AsignacionAccesoDatos asignacionAccesoDatos = new AsignacionAccesoDatos();
        public void Guardar(Asignacion asg)
        {
            asignacionAccesoDatos.guardar(asg);
        }
        public void Eliminar(int numcontrol)
        {
            asignacionAccesoDatos.Eliminar(numcontrol);
        }
        public List<Asignacion> GetAsignacions(string filtro)
        {
            var listas = asignacionAccesoDatos.GetAsignacions(filtro);

            return listas;
        }
    }
}
