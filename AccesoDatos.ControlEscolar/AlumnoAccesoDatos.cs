using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;

namespace AccesoDatos.ControlEscolar
{
    public class AlumnoAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public AlumnoAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public void guardar(Alumnos alumnos)
        {
            if (alumnos.Numcontrol == 0)
            {
                string consulta = string.Format("Insert into alumnos values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",alumnos.Nombre,alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fecha, alumnos.Domicilio, alumnos.Email, alumnos.Sexo, alumnos.Fkestados, alumnos.Fkmunicipios );
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update alumnos set nombre = '{0}', apellidopaterno ='{1}', apellidomaterno = '{2}', fechadenacimiento = '{3}', domicilio = '{4}', email = '{5}', sexo = '{6}', fkestados = '{7}', fkmunicipios = '{8}' where numcontrol = {9}", alumnos.Nombre, alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fecha, alumnos.Domicilio, alumnos.Email, alumnos.Sexo, alumnos.Fkestados, alumnos.Fkmunicipios, alumnos.Numcontrol);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int numcontrol)
        {
            string consulta = string.Format("Delete from alumnos where numcontrol = {0}", numcontrol);
            conexxion.EjecutarConsult(consulta);
        }
        public List<Alumnos> GetAlumnos(string filtro)
        {
            var listAlumnos = new List<Alumnos>();
            var ds = new DataSet();
            string consulta = "Select * from alumnos where nombre like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "alumnos");

            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow  row in dt.Rows)
            {
                var alumno = new Alumnos
                {
                    Numcontrol = Convert.ToInt32(row["numcontrol"]),
                    Nombre = row["nombre"].ToString(),
                    Apellidopaterno = row["apellidopaterno"].ToString(),
                    Apellidomaterno = row["apellidomaterno"].ToString(),
                    Fecha = row["fechadenacimiento"].ToString(),
                    Domicilio = row["domicilio"].ToString(),
                    Email = row["email"].ToString(),
                    Sexo = row["sexo"].ToString(),
                    Fkestados = row["fkestados"].ToString(),
                    Fkmunicipios = row["fkmunicipios"].ToString()



                };
                listAlumnos.Add(alumno);
            }
            return listAlumnos;
        }
      }

    }

