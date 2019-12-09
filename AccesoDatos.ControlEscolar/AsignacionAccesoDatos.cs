using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;


namespace AccesoDatos.ControlEscolar
{
    public class AsignacionAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public AsignacionAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public void guardar(Asignacion asignacion)
        {
            if (asignacion.Idasignacion == 0)
            {
                string consulta = string.Format("Insert into asignacion values(null,'{0}','{1}','{2}')", asignacion.Profesor1, asignacion.Materia1, asignacion.Grupo1);
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update asignacion set fkprofesro = '{0}', fkmateria ='{1}', fkgrupo = '{2}' where numcontrol = {3}", asignacion.Profesor1, asignacion.Materia1, asignacion.Grupo1, asignacion.Idasignacion);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int numcontrol)
        {
            string consulta = string.Format("Delete from asignacion where idasignacion = {0}", numcontrol);
            conexxion.EjecutarConsult(consulta);
        }
        public List<Asignacion> GetAsignacions(string filtro)
        {
            var listas = new List<Asignacion>();
            var ds = new DataSet();
            string consulta = "Select * from asignacion where fkprofesro like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "asignacion");

            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow row in dt.Rows)
            {
                var asig = new Asignacion
                {
                    Idasignacion = Convert.ToInt32(row["idasignacion"]),
                    Profesor1 = row["fkprofesro"].ToString(),
                    Materia1 = row["fkmateria"].ToString(),
                    Grupo1 = row["fkgrupo"].ToString(),
                   





                };
                listas.Add(asig);
            }
            return listas;
        }


    }
}
