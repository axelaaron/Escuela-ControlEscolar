using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;


namespace AccesoDatos.ControlEscolar
{
    public class EscuelaAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public EscuelaAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }

        public void guardar(Escuela escuela)
        {
            if (escuela.Idescuela == 0)
            {
                string consulta = string.Format("Insert into escuela values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", escuela.Nombreescuela, escuela.Rfc, escuela.Domicilio, escuela.Telefono, escuela.Correo, escuela.Paginaweb, escuela.Nombredirector, escuela.Logo);
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                string consulta = string.Format("Update escuela set nombreescuela = '{0}', rfc ='{1}',  domicilio = '{2}', telefono = '{3}', correo = '{4}', paginaweb = '{5}', nombredirector = '{6}', logo = '{7}'  where idescuela = {8}", escuela.Nombreescuela, escuela.Rfc, escuela.Domicilio, escuela.Telefono, escuela.Correo, escuela.Paginaweb, escuela.Nombredirector, escuela.Logo, escuela.Idescuela);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int numcontrol)
        {
            string consulta = string.Format("Delete from escuela where idescuela = {0}", numcontrol);
            conexxion.EjecutarConsult(consulta);
        }
        public List<Escuela> GetEscuelas(string filtro)
        {
            var listescuela = new List<Escuela>();
            var ds = new DataSet();
            string consulta = "Select * from escuela where nombreescuela like '%" + filtro + "%'";
            ds = conexxion.ObtenerDatos(consulta, "escuela");
            var dt = new DataTable();
            dt = ds.Tables[0];


            foreach (DataRow row in dt.Rows)
            {
                var escuela = new Escuela
                {
                    Idescuela = Convert.ToInt32(row["idescuela"]),
                    Nombreescuela = row["nombreescuela"].ToString(),
                    Rfc = row["rfc"].ToString(),
                    Domicilio = row["domicilio"].ToString(),
                    Telefono = row["telefono"].ToString(),
                    Correo = row["correo"].ToString(),
                    Paginaweb = row["paginaweb"].ToString(),
                    Nombredirector = row["nombredirector"].ToString(),
                    Logo = row["logo"].ToString()



                };
                listescuela.Add(escuela);
            }
            return listescuela;
        }
    }
}
