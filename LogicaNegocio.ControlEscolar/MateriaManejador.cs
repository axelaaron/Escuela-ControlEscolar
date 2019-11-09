using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;


namespace LogicaNegocio.ControlEscolar
{
    public class MateriaManejador
    {
        private  MateriaAccesoDatos _estudiosAccesoDatos = new MateriaAccesoDatos();


        public void Guardar(Materias estudio)
        {
            _estudiosAccesoDatos.Guardar(estudio);

        }
        public void Eliminar(int id)
        {
            _estudiosAccesoDatos.Eliminar(id);
        }
        public List<Materias> GetMaterias(string filtro)
        {
            
            var listestudios = _estudiosAccesoDatos.GetMaterias(filtro);


            return listestudios;

        }
    }
}
