using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.ControlEscolar;
using Entidades.ControlEscolar;

namespace LogicaNegocio.ControlEscolar
{
    public class MunicipiosManejador
    {
        private MunicipioAccesoDatos _municipiosaccesodatos = new MunicipioAccesoDatos();
        public List<Municipios> GetMunicipios(ComboBox cm, ComboBox cm1)
        {
            var listMunicipios = _municipiosaccesodatos.GetMunicipios(cm, cm1);

            return listMunicipios;
        }

    }
}
