using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Calificaciones
    {
        private int idcalificacion;
        private string nombre;
        private string apellidopaterno;
        private string apellidomaterno;
        private string materia;
        private double parcialuno;
        private double parcialdos;
        private double parcialtres;
        private double parcialcuatro;

        public int Idcalificacion { get => idcalificacion; set => idcalificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidopaterno { get => apellidopaterno; set => apellidopaterno = value; }
        public string Apellidomaterno { get => apellidomaterno; set => apellidomaterno = value; }
        public string Materia { get => materia; set => materia = value; }
        public double Parcialuno { get => parcialuno; set => parcialuno = value; }
        public double Parcialdos { get => parcialdos; set => parcialdos = value; }
        public double Parcialtres { get => parcialtres; set => parcialtres = value; }
        public double Parcialcuatro { get => parcialcuatro; set => parcialcuatro = value; }
    }
}
