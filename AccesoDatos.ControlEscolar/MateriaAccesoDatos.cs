using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;

namespace AccesoDatos.ControlEscolar
{
    public class MateriaAccesoDatos
    {
        ConexxionAccesoAdatos conexion;

        public MateriaAccesoDatos()
        {
            conexion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);

        }

        public void Guardar(Materias estudio)
        {
            if (estudio.Idestudios == 0)
            {
                string consulta = string.Format("Insert into estudios values(null,{0},'{1}','{2}','{3}')",
                    estudio.Fkprofesor, estudio.Titulo, estudio.Nombre, estudio.Nombrearchivo);
                conexion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update estudios set fkprofesor = {0}, tiutlo = '{1}', nombre= '{2}', nombredelarchivo = '{3}' where idestudios= {4}",
                   estudio.Fkprofesor, estudio.Titulo, estudio.Nombre, estudio.Nombrearchivo, estudio.Idestudios);
                conexion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int id)
        {
            string consulta = string.Format("Delete from estudios where idestudios = {0} ", id);
            conexion.EjecutarConsult(consulta);
        }
        public List<Materias> GetMaterias(string filtro)
        {
           
            var listestudios = new List<Materias>();
            var ds = new DataSet();
            string consulta = "select * from estudios where tiutlo like '%" + filtro + "%'";
            ds = conexion.ObtenerDatos(consulta, "estudios");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow Row in dt.Rows)
            {
                var estudios = new Materias
                {
                    Idestudios = Convert.ToInt32(Row["idestudios"]),
                    Fkprofesor = Convert.ToInt32(Row["fkprofesor"]),
                    Titulo = Row["tiutlo"].ToString(),
                    Nombre = Row["nombre"].ToString(),
                    Nombrearchivo = Row["nombredelarchivo"].ToString(),

                };

                listestudios.Add(estudios);

            }

            return listestudios;

        }
        public List<Materias> GetMateria(string filtro)
        {

            var listestudios1 = new List<Materias>();
            var ds = new DataSet();
            string consulta = "select nombre from profesores";
            ds = conexion.ObtenerDatos(consulta, "estudios");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow Row in dt.Rows)
            {
                var estudios = new Materias
                {
                   
                    Nombre = Row["nombre"].ToString(),

                };

                listestudios1.Add(estudios);

            }

            return listestudios1;

        }
    }
}
