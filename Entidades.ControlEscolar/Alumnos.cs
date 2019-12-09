using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Alumnos
    {
        private int _numcontrol;
        private string _nombre;
        private string _apellidopaterno;
        private string _apellidomaterno;
        private string _fecha;
        private string _domicilio;
        private string _email;
        private string _sexo;
        private string _fkestados;
        private string _fkmunicipios;
        private string _fkgrupo;

        public int Numcontrol { get => _numcontrol; set => _numcontrol = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
        public string Fecha { get => _fecha; set => _fecha = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Email { get => _email; set => _email = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Fkestados { get => _fkestados; set => _fkestados = value; }
        public string Fkmunicipios { get => _fkmunicipios; set => _fkmunicipios = value; }
        public string Fkgrupo { get => _fkgrupo; set => _fkgrupo = value; }
    }
}
