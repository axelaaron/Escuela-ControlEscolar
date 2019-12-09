using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;

namespace LogicaNegocio.ControlEscolar
{
    public class CalificacionesManejador
    {
        private CalificacionesAccesoDatos _CalificacionesAccesoDatos = new CalificacionesAccesoDatos();
        public void Guardar(Calificaciones calificaciones)
        {
            _CalificacionesAccesoDatos.guardar(calificaciones);
        }
        public void Eliminar(int numcontrol)
        {
            _CalificacionesAccesoDatos.Eliminar(numcontrol);
        }
        public List<Calificaciones> GetCalificaciones(string filtro)
        {
            var listcalificaciones = _CalificacionesAccesoDatos.GetCalificaciones(filtro);

            return listcalificaciones;
        }
    }
}
