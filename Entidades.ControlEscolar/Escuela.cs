using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
   public class Escuela
    {
        private int _idescuela;
        private string _nombreescuela;
        private string _rfc;
        private string _domicilio;
        private string _telefono;
        private string _correo;
        private string _paginaweb;
        private string _nombredirector;
        private string _logo;

        public int Idescuela { get => _idescuela; set => _idescuela = value; }
        public string Nombreescuela { get => _nombreescuela; set => _nombreescuela = value; }
        public string Rfc { get => _rfc; set => _rfc = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Paginaweb { get => _paginaweb; set => _paginaweb = value; }
        public string Nombredirector { get => _nombredirector; set => _nombredirector = value; }
        public string Logo { get => _logo; set => _logo = value; }
    }
}
