using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using AccesoDatos.ControlEscolar;
using System.Text.RegularExpressions;

namespace LogicaNegocio.ControlEscolar
{
    public class UsuarioManejador
    {
        private UsuarioAccesoDatos _usuarioAccesoDatos = new UsuarioAccesoDatos();
        private bool NombreValido(string nombre)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");

            var match = regex.Match(nombre);

            if (match.Success)
            {
                return true;

            }

            return false;
        }
        public Tuple<bool, string> ValidarUsuario(Usuario usuario)
        {
            string mensaje = "";
            bool valido = true;

            if (usuario.Nombre.Length == 0)
            {
                mensaje = mensaje + "EL nombre de usuario es necesario  \n";
                valido = false;
            }
            else if (usuario.Nombre.Length > 20)
            {
                mensaje = mensaje + "El nombre de usuario solo permite un maximo de 20 caracteres";
                valido = false;


            }
            else if (!NombreValido(usuario.Nombre))
            {
                mensaje = mensaje + "Escibe un formato valido para el nombre de usuario";
                valido = false;

            }
            if (usuario.ApellidoPaterno.Length == 0)
            {
                mensaje = mensaje + "EL apelldio paterno de usuario es necesario  \n";
                valido = false;
            }
            else if (usuario.Nombre.Length > 20)
            {
                mensaje = mensaje + "El nombre de apellido paterno solo permite un maximo de 20 caracteres";
                valido = false;


            }

            return Tuple.Create(valido, mensaje);

        }

        public void Guardar(Usuario usuario)
        {
            _usuarioAccesoDatos.Guardar(usuario);
        }
        public void Eliminar(int IdUsuario)
        {
            _usuarioAccesoDatos.Eliminar(IdUsuario);
        }
        public List<Usuario> GetUsuarios(string filtro)
        {
            //List<Usuario> listUsuario = new ListUsuarios();
            var listUsuario = _usuarioAccesoDatos.GetUsuarios(filtro);

            //Llenar Lista
            return listUsuario;
        }
    }
}
