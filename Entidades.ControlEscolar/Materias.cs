using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Materias
    {
        private int _idestudios;
        private int _fkprofesor;
        private string _titulo;
        private string _nombre;
        private string _nombrearchivo;

        public int Idestudios { get => _idestudios; set => _idestudios = value; }
        public int Fkprofesor { get => _fkprofesor; set => _fkprofesor = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Nombrearchivo { get => _nombrearchivo; set => _nombrearchivo = value; }
    }
}
