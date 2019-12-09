using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Grupos
    {
        private int _idgrupo;
        private string _grupo;

        public int Idgrupo { get => _idgrupo; set => _idgrupo = value; }
        public string Grupo { get => _grupo; set => _grupo = value; }
    }
}
