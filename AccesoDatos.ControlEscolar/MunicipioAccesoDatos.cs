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
    public class MunicipioAccesoDatos
    {
        ConexxionAccesoAdatos conexxion;

        public MunicipioAccesoDatos()
        {
            conexxion = new ConexxionAccesoAdatos("localhost", "root", "", "practica", 3306);
        }
        public List<Municipios> GetMunicipios(ComboBox cm, ComboBox cm2)
        {
            var listMunicipios = new List<Municipios>();
            var ds = new DataSet();
            string consulta = "select nombre from municipios where fkcodigo = '" + cm2.Text+"' ";
            ds = conexxion.ObtenerDatos(consulta, "municipios");
            cm.DataSource = ds.Tables[0];
            cm.DisplayMember = "nombre";
            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var municipios = new Municipios
                {

                    
                    Nombre = row["nombre"].ToString(),


                };
                listMunicipios.Add(municipios);
            }
            return listMunicipios;
        }

    }
}
