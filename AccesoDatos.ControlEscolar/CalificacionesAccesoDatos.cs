using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;


namespace AccesoDatos.ControlEscolar
{
    public class CalificacionesAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public CalificacionesAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public void guardar(Calificaciones calificaciones)
        {
            if (calificaciones.Idcalificacion == 0)
            {
                string consulta = string.Format("Insert into calificaciones values(null,'{0}','{1}','{2}','{3}', {4}, {5}, {6}, {7})", calificaciones.Nombre, calificaciones.Apellidopaterno, calificaciones.Apellidomaterno, calificaciones.Materia, calificaciones.Parcialuno, calificaciones.Parcialdos, calificaciones.Parcialtres, calificaciones.Parcialcuatro);
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update calificaciones set nombre = '{0}', apellidopaterno ='{1}', apellidomaterno = '{2}', materias = '{3}', parcialuno = {4}, parcialdos = {5}, parcialtres = {6}, parcialcuatro = {7} where numcontrol = {8}", calificaciones.Nombre, calificaciones.Apellidopaterno, calificaciones.Apellidomaterno, calificaciones.Materia, calificaciones.Parcialuno, calificaciones.Parcialdos, calificaciones.Parcialtres, calificaciones.Parcialcuatro, calificaciones.Idcalificacion);
                conexxion.EjecutarConsult(consulta);
            }

        }
        public void Eliminar(int numcontrol)
        {
            string consulta = string.Format("Delete from calificaciones where idcalificaciones = {0}", numcontrol);
            conexxion.EjecutarConsult(consulta);
        }
        public List<Calificaciones> GetCalificaciones(string filtro)
        {
            var listcalificaciones = new List<Calificaciones>();
            var ds = new DataSet();
            string consulta = "Select * from calificaciones where nombre like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "calificaciones");

            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow row in dt.Rows)
            {
                var calificaciones = new Calificaciones
                {

                    Idcalificacion = Convert.ToInt32(row["idcalificaciones"]),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidopaterno"].ToString(),
                    Apellidomaterno = row["apellidomaterno"].ToString(),
                    Materia = row["materias"].ToString(),
                    Parcialuno = Convert.ToDouble(row["parcialuno"]),
                    Parcialdos = Convert.ToDouble(row["parcialdos"]),
                    Parcialtres = Convert.ToDouble(row["parcialtres"]),
                    Parcialcuatro = Convert.ToDouble(row["parcialcuatro"]),






                };
                listcalificaciones.Add(calificaciones);
            }
            return listcalificaciones;
        }
    }
}
