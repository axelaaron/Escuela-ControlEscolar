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
    public class GrupoAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public GrupoAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public void guardar(Grupos grupo)
        {
            if (grupo.Idgrupo == 0)
            {
                string consulta = string.Format("Insert into grupos values(null,'{0}')", grupo.Grupo);
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update grupos set grupo = '{0}' idgrupo = {1}", grupo.Grupo, grupo.Idgrupo);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int numcontrol)
        {
            string consulta = string.Format("Delete from grupos where idgrupo = {0}", numcontrol);
            conexxion.EjecutarConsult(consulta);
        }
        public List<Grupos> GetGrupos(string filtro)
        {
            var listgp = new List<Grupos>();
            var ds = new DataSet();
            string consulta = "Select * from grupos where grupo like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "grupos");

            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow row in dt.Rows)
            {
                var gp = new Grupos
                {
                    Idgrupo = Convert.ToInt32(row["idgrupo"]),
                    Grupo = row["grupo"].ToString(),
                    



                };
                listgp.Add(gp);
            }
            return listgp;
        }
        public List<Alumnos> GetAlumnos2(string filtro)
        {
            var listAlumnos = new List<Alumnos>();
            var ds = new DataSet();
            string consulta = "Select * from v_alumnos where grupo like '%" + filtro + "%'";
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
        public List<Grupos> GetGrupos2(ComboBox cm)
        {
            var listGRUPO = new List<Grupos>();
            var ds = new DataSet();
            string consulta = "select grupo from grupos ";
            ds = conexxion.ObtenerDatos(consulta, "grupos");
            cm.DataSource = ds.Tables[0];
            cm.DisplayMember = "Grupo";
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var gp = new Grupos
                {

                    Grupo = row["grupo"].ToString(),
                    


                };
                listGRUPO.Add(gp);
            }
            return  listGRUPO;
        }
    }
}

