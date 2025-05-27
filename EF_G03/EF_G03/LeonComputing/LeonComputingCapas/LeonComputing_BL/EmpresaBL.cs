using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeonComputing_ADO;
namespace LeonComputing_BL
{
    public  class EmpresaBL
    {
        EmpresaADO objEmpresaADO = new EmpresaADO();

        public DataTable ListarEmpresa()
        {
            return objEmpresaADO.ListarEmpresa();
        }
    }
}
