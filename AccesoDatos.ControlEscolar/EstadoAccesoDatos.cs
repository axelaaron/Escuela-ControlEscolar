using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolar;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.ControlEscolar
{
    public class EstadoAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public EstadoAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public List<Estados> GetEstados(ComboBox cm)
        {
            var listEstados = new List<Estados>();
            var ds = new DataSet();
            string consulta = "select codigo from estados ";
            ds = conexxion.ObtenerDatos(consulta, "estados");
            cm.DataSource = ds.Tables[0];
            cm.DisplayMember = "codigo";
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var estados = new Estados
                {
                    
                    Codigo = row["codigo"].ToString(),
                   // Nombre = row["nombre"].ToString(),
                  

                };
                listEstados.Add(estados);
            }
            return listEstados;
        }
    }
}
