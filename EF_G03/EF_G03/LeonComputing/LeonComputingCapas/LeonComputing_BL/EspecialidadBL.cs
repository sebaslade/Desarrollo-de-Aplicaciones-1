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
    public class EspecialidadBL
    {
        EspecialidadADO objEspecialidadADO = new EspecialidadADO();
        public DataTable ListarEspecialidades()
        {
            return objEspecialidadADO.ListarEspecialidades();
        }
    }
}
