using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;

namespace LogicaNegocio.ControlEscolar
{
    public class AlumnoManejador
    {
        private AlumnoAccesoDatos _alumnoAccesoDatos = new AlumnoAccesoDatos();
        public void Guardar(Alumnos alumnos)
        {
            _alumnoAccesoDatos.guardar(alumnos);
        }
        public void Eliminar(int numcontrol)
        {
            _alumnoAccesoDatos.Eliminar(numcontrol);
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            var listAlumno = _alumnoAccesoDatos.GetAlumnos(filtro);

            return listAlumno;
        }
    }
   
}
