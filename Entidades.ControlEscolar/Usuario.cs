using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.ControlEscolar
{
   public class Usuario
   {
        private int _idusuario;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _contrasenia;

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
    }
}
