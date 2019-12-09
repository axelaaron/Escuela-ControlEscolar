using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Asignacion
    {
        private int _idasignacion;
        private string Profesor;
        private string Materia;
        private string Grupo;

        public int Idasignacion { get => _idasignacion; set => _idasignacion = value; }
        public string Profesor1 { get => Profesor; set => Profesor = value; }
        public string Materia1 { get => Materia; set => Materia = value; }
        public string Grupo1 { get => Grupo; set => Grupo = value; }
    }
}
