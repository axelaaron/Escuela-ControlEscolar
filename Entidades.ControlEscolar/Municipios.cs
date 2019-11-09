using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Municipios
    {
        private int _codigomunicipio;
        private string _nombre;
        private string _fkcodigo;

        public int Codigomunicipio { get => _codigomunicipio; set => _codigomunicipio = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Fkcodigo { get => _fkcodigo; set => _fkcodigo = value; }
    }
}
