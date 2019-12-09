using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Windows.Forms;

namespace LogicaNegocio.ControlEscolar
{
    public class GrupoManejador
    {
        private GrupoAccesoDatos grupoAccesoDatos = new GrupoAccesoDatos();


        public void Guardar(Grupos grupos)
        {
            grupoAccesoDatos.guardar(grupos);

        }
        public void Eliminar(int idmateria)
        {
            grupoAccesoDatos.Eliminar(idmateria);
        }
        public List<Grupos> GetGrupos(string filtro)
        {

            var listgp = grupoAccesoDatos.GetGrupos (filtro);


            return listgp;

        }
        public List<Grupos> GetGrupos2(ComboBox cm)
        {
            var listgp = grupoAccesoDatos.GetGrupos2(cm);

            return listgp;
        }
        public List<Alumnos> GetAlumnos2(string filtro)
        {
            var listAlumno = grupoAccesoDatos.GetAlumnos2(filtro);

            return listAlumno;
        }



    }
}

