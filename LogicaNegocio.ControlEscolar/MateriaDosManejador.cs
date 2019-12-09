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
    public class MateriaDosManejador
    {
        private MateriasDOSAccesoDatos MateriasDOSAccesoDatos = new MateriasDOSAccesoDatos();


        public void Guardar(MateriaDos asignatura)
        {
            MateriasDOSAccesoDatos.Guardar(asignatura);

        }
        public void Eliminar(int idmateria)
        {
            MateriasDOSAccesoDatos.Eliminar(idmateria);
        }
        public List<MateriaDos> GetMateriaDos(string filtro)
        {

            var listasignatura = MateriasDOSAccesoDatos.GetMateriaDos(filtro);


            return listasignatura;

        }
        public List<MateriaDos> getanterior(ComboBox cm)
        {

            var listasignatura = MateriasDOSAccesoDatos.getanterior(cm);


            return listasignatura;

        }
        public List<MateriaDos> Getmateriados(ComboBox cm)
        {
            var listgp = MateriasDOSAccesoDatos.Getmateriados(cm);

            return listgp;
        }
        public List<MateriaDos> Getmate(string filtro)
        {
            var listgpos = MateriasDOSAccesoDatos.Getmate(filtro);

            return listgpos;
        }

    }
}
