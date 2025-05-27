using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LeonComputing_ADO;
using LeonComputing_BE;

namespace LeonComputing_BL
{
    public class AsociadoBL
    {
        AsociadoADO objAsociadoADO = new AsociadoADO();

        public Boolean InsertarAsociado(AsociadoBE objAsociadoBE)
        {
            return objAsociadoADO.InsertarAsociado(objAsociadoBE);
        }

        public Boolean ActualizarAsociado(AsociadoBE objAsociadoBE)
        {
            return objAsociadoADO.ActualizarAsociado(objAsociadoBE);
        }

        public AsociadoBE ConsultarAsociado(String strcod)
        {
            return objAsociadoADO.ConsultarAsociado(strcod);
        }

        public DataTable ListarAsociado()
        {
            return objAsociadoADO.ListarAsociado();
        }
    }
}
