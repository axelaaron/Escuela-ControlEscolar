using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolar
{
    public class MateriaDos
    {
        private int _id;
        private string _idmaterias;
        private string _nombre;
        private int _horast;
        private int _horasp;
        private string _fkmateriaanterior;
        private string _fkmateriaquesigue;
        private int _semestre;
        private int _creditos;
        private int _total;
        public int Id { get => _id; set => _id = value; }
        public string Idmaterias { get => _idmaterias; set => _idmaterias = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Horast { get => _horast; set => _horast = value; }
        public int Horasp { get => _horasp; set => _horasp = value; }
        public string Fkmateriaanterior { get => _fkmateriaanterior; set => _fkmateriaanterior = value; }
        public string Fkmateriaquesigue { get => _fkmateriaquesigue; set => _fkmateriaquesigue = value; }
        public int Semestre { get => _semestre; set => _semestre = value; }
        public int Creditos { get => _creditos; set => _creditos = value; }
        public int Total { get => _total; set => _total = value; }
    }
}
