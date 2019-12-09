using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;
using System.Windows.Forms;
namespace AccesoDatos.ControlEscolar
{
    public class MateriasDOSAccesoDatos
    {
        ConexxionAccesoAdatos conexion;

        public MateriasDOSAccesoDatos()
        {
            conexion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);

        }
        public void Guardar(MateriaDos materia)
        {
            if (materia.Id == 0)
            {
                string consulta = string.Format("Insert into materiasdos values(null,'{0}', '{1}', {2}, {3},'{4}','{5}', {6}, {7} )",
                    materia.Idmaterias, materia.Nombre, materia.Horast, materia.Horasp, materia.Fkmateriaanterior, materia.Fkmateriaquesigue, materia.Semestre, materia.Creditos);
                conexion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update materiasdos set idmateriados  = '{0}',  nombre = '{1}', horast= {2}, horasp = {3}, fkmateriaanterior = '{4}', fkmateriaquesigue = '{5}', semestre = {6}, creditos = {7}  where id = {8}",
                     materia.Idmaterias, materia.Nombre, materia.Horast, materia.Horasp, materia.Fkmateriaanterior, materia.Fkmateriaquesigue, materia.Semestre, materia.Creditos, materia.Id);
                conexion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int idmaterias)
        {
            string consulta = string.Format("Delete from materiasdos where id = {0} ", idmaterias);
            conexion.EjecutarConsult(consulta);
        }
       
        public List<MateriaDos> getanterior(ComboBox cm)
        {
            var listmateriaanterior = new List<MateriaDos>();
            var ds = new DataSet();
            string consulta = "select idmateriados from materiasdos ";
            ds = conexion.ObtenerDatos(consulta, "materiasdos");
            cm.DataSource = ds.Tables[0];
            cm.DisplayMember = "idmateriados";
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var materiaanterior = new MateriaDos
                {

                    Idmaterias = row["idmateriados"].ToString(),
                   


                };
                listmateriaanterior.Add(materiaanterior);
            }
            return listmateriaanterior;
        }
        public List<MateriaDos> GetMateriaDos(string filtro)
        {

            var listmateriasdos = new List<MateriaDos>();
            var ds = new DataSet();
            string consulta = "select * from v_materiasdop where ClaveMateria like '%" + filtro + "%'";
            ds = conexion.ObtenerDatos(consulta, "v_materiasdop");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow Row in dt.Rows)
            {
                var materiados = new MateriaDos
                {
                    Id = Convert.ToInt32(Row["id"]),
                    Idmaterias = Row["ClaveMateria"].ToString(),
                    Nombre = Row["nombre"].ToString(),
                    Horast = Convert.ToInt32(Row["HorasTeoria"]),
                    Horasp = Convert.ToInt32(Row["HorasPractica"]),
                    Fkmateriaanterior = Row["MateriaAnterior"].ToString(),
                    Fkmateriaquesigue = Row["MateriaSiguiente"].ToString(),
                    Semestre = Convert.ToInt32(Row["Semestre"]),
                    Creditos = Convert.ToInt32(Row["creditos"]),
                    Total = Convert.ToInt32(Row["Total"]),


                };

                listmateriasdos.Add(materiados);

            }

            return listmateriasdos;

        }
        public List<MateriaDos> Getmateriados(ComboBox cm)
        {
            var listmateria = new List<MateriaDos>();
            var ds = new DataSet();
            string consulta = "select nombre from materiasdos ";
            ds = conexion.ObtenerDatos(consulta, "materiasdos");
            cm.DataSource = ds.Tables[0];
            cm.DisplayMember = "nombre";
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var materias = new MateriaDos
                {

                    Nombre = row["nombre"].ToString(),



                };
                listmateria.Add(materias);
            }
            return listmateria;
        }
        public List<MateriaDos> Getmate(string filtro)
        {
            var listmateria = new List<MateriaDos>();
            var ds = new DataSet();
            string consulta = "select * from materiasdos where nombre like '%" + filtro + "%'";
            ds = conexion.ObtenerDatos(consulta, "materiasdos");
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var materias = new MateriaDos
                {
                    Id = Convert.ToInt32(row["id"]),
                    Idmaterias = row["idmateriados"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Horast = Convert.ToInt32(row["horast"]),
                    Horasp = Convert.ToInt32(row["horasp"]),
                    Fkmateriaanterior = row["fkmateriaanterior"].ToString(),
                    Fkmateriaquesigue = row["fkmateriaquesigue"].ToString(),
                    Semestre = Convert.ToInt32(row["semestre"]),
                    Creditos = Convert.ToInt32(row["creditos"].ToString())


                };
                listmateria.Add(materias);
            }
            return listmateria;
        }
    }

}

