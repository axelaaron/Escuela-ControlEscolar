using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Data;
namespace LogicaNegocio.ControlEscolar
{
    public class EscuelaManejador
    {
        private EscuelaAccesoDatos _EscuelaAccesoDatos = new EscuelaAccesoDatos();
        public void Guardar(Escuela escuela)
        {
            _EscuelaAccesoDatos.guardar(escuela);
        }
        public void Eliminar(int numcontrol)
        {
            _EscuelaAccesoDatos.Eliminar(numcontrol);
        }
        public List<Escuela> GetEscuelas(string filtro)
        {
            var listes = _EscuelaAccesoDatos.GetEscuelas(filtro);
            return listes;
        }
    }
}
