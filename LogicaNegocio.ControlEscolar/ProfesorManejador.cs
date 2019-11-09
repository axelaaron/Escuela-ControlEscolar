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
    public class ProfesorManejador
    {
        private ProfesorAccesoDatos _profesoraccesodatos = new ProfesorAccesoDatos();
        public void Guardar(Profesor profesor)
        {
            _profesoraccesodatos.Guardar(profesor);

        }
        public void Eliminar (int numcontrol)
        {
            _profesoraccesodatos.Eliminar(numcontrol);
        }
        public List<Profesor> GetProfesors(string filtro)
        {
            var listprofe = _profesoraccesodatos.GetProfesors(filtro);
            return listprofe;
        }

        public DataTable idprofesor(string filtro)
        {
            var dt = _profesoraccesodatos.idprofesor(filtro);
            return dt;
        }



    }
}
