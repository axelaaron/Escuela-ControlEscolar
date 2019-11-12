using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Calificaciones
    {
        private int _idcalificaiones;
        private int _fknumcontrol;
        private int _fkidasignatura;
        private int _fkidmateria;
        private int _creditos;

        public int Idcalificaiones { get => _idcalificaiones; set => _idcalificaiones = value; }
        public int Fknumcontrol { get => _fknumcontrol; set => _fknumcontrol = value; }
        public int Fkidasignatura { get => _fkidasignatura; set => _fkidasignatura = value; }
        public int Fkidmateria { get => _fkidmateria; set => _fkidmateria = value; }
        public int Creditos { get => _creditos; set => _creditos = value; }
    }
}
