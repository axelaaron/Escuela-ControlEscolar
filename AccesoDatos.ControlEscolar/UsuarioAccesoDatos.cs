using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;

namespace AccesoDatos.ControlEscolar
{
    public class UsuarioAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;
        public UsuarioAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public void Guardar(Usuario usuario)
        {
            if (usuario.Idusuario == 0)
            {
                string consulta = string.Format("Insert into usuario values(null,'{0}','{1}','{2}','{3}')",
                    usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Contrasenia);
                conexxion.EjecutarConsult(consulta);
            }
            else
            {
                //update
                string consulta = string.Format("Update usuario set nombre = '{0}',apellidopaterno = '{1}', apellidomaterno = '{2}', contrasenia = '{3}' where idusuario = {4}",
                     usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Contrasenia, usuario.Idusuario);
                conexxion.EjecutarConsult(consulta);
            }
        }
        public void Eliminar(int IdUsuario)
        {
            //eliminar
            string consulta = string.Format("Delete from usuario where idusuario = {0}", IdUsuario);
            conexxion.EjecutarConsult(consulta);
        }
        public List<Usuario> GetUsuarios(string filtro)
        {
            //List<Usuario> listUsuario = new ListUsuarios();
            var listUsuario = new List<Usuario>();
            var ds = new DataSet();
            string consulta = "Select * from usuario where nombre like '%"+filtro+"%'";
            ds = conexxion.ObtenerDatos(consulta, "usuario");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var usuario = new Usuario
                {
                    Idusuario = Convert.ToInt32(row["Idusuario"]),
                    Nombre = row["Nombre"].ToString(),
                    ApellidoPaterno = row["ApellidoPaterno"].ToString(),
                    ApellidoMaterno = row["ApellidoMaterno"].ToString(),
                    Contrasenia = row["Contrasenia"].ToString(),

                };

                listUsuario.Add(usuario);


            }
            //Hardcodear
        
            
          
            //Llenar Lista
            return listUsuario;
        }
    }
}
