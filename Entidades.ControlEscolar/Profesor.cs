using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class Profesor
    {
        private int _id;
        private string _numerocontrol;
        private string _nombre;
        private string _apellidopaterno;
        private string _apellidometarno;
        private string _direccion;
        private string _estado;
        private string _municipio;
        private int _numerocedula;
        private string titulo;
        private string fechadenacimiento;
        private string materia;
        private string grupo;
  

        public int Id { get => _id; set => _id = value; }
        public string Numerocontrol { get => _numerocontrol; set => _numerocontrol = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidometarno { get => _apellidometarno; set => _apellidometarno = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Municipio { get => _municipio; set => _municipio = value; }
        public int Numerocedula { get => _numerocedula; set => _numerocedula = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Grupo { get => grupo; set => grupo = value; }
    }
}
