using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeonComputing_ADO;
using System.Data;

namespace LeonComputing_BL
{
    public class ExpositorBL
    {
        ExpositorADO objExpositorADO = new ExpositorADO();

        public DataTable ListarExpositor()
        {
            return objExpositorADO.ListarExpositor();
        }
    }
}
