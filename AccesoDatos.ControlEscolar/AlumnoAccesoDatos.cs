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
                string consulta = string.Format("Insert into alumnos values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}')",alumnos.Nombre,alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fecha, alumnos.Domicilio, alumnos.Email, alumnos.Sexo, alumnos.Fkestados, alumnos.Fkmunicipios, alumnos.Fkgrupo );
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update alumnos set nombre = '{0}', apellidopaterno ='{1}', apellidomaterno = '{2}', fechadenacimiento = '{3}', domicilio = '{4}', email = '{5}', sexo = '{6}', fkestados = '{7}', fkmunicipios = '{8}', fkgrupo = {9} where numcontrol = {10}", alumnos.Nombre, alumnos.Apellidopaterno, alumnos.Apellidomaterno, alumnos.Fecha, alumnos.Domicilio, alumnos.Email, alumnos.Sexo, alumnos.Fkestados, alumnos.Fkmunicipios, alumnos.Fkgrupo, alumnos.Numcontrol);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int numcontrol)
        {
            string consulta = string.Format("Delete from alumnos where numcontrol = {0}", numcontrol);
            conexxion.EjecutarConsult(consulta);
        }
       /* public List<Alumnos> GetAlumnos(string filtro)
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
                    Fkmunicipios = row["fkmunicipios"].ToString(),
                    Fkgrupo = row["fkgrupo"].ToString(),





                };
                listAlumnos.Add(alumno);
            }
            return listAlumnos;
        }
        */
        public List<Alumnos> GetAlumnos2(string filtro)
        {
            var listAlumnos = new List<Alumnos>();
            var ds = new DataSet();
            string consulta = "Select * from v_alumnos where Nombre_del_alumno like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "v_alumnos");

            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow row in dt.Rows)
            {
                var alumno = new Alumnos
                {

                    Numcontrol = Convert.ToInt32(row["numcontrol"]),
                    Nombre = row["Nombre_del_alumno"].ToString(),
                    Apellidopaterno = row["Apellido_paterno"].ToString(),
                    Apellidomaterno = row["Apellido_materno"].ToString(),
                    Fecha = row["Fecha_de_nacimiento"].ToString(),
                    Domicilio = row["Domicilio"].ToString(),
                    Email = row["Email"].ToString(),
                    Sexo = row["Sexo"].ToString(),
                    Fkestados = row["Estado"].ToString(),
                    Fkmunicipios = row["Municipio"].ToString(),
                    Fkgrupo = row["Grupo"].ToString(),





                };
                listAlumnos.Add(alumno);
            }
            return listAlumnos;
        }
        public List<Alumnos> GetAlumno(ComboBox cm)
        {
            var listalumno = new List<Alumnos>();
            var ds = new DataSet();
            string consulta = "select nombre from alumnos ";
            ds = conexxion.ObtenerDatos(consulta, "alumnos");
            cm.DataSource = ds.Tables[0];
            cm.DisplayMember = "nombre";
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var alumnos = new Alumnos
                {

                    
                    Nombre = row["nombre"].ToString(),


                };
                listalumno.Add(alumnos);
            }
            return listalumno;
        }

    }

    }

