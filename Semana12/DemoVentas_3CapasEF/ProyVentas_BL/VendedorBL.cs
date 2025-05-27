using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agregar dependencias
using ProyVentas_ADO;
using ProyVentas_BE;

namespace ProyVentas_BL
{
    public class VendedorBL
    {
        VendedorADO objVendedorADO = new VendedorADO();

        public List<VendedorBE> ListarVendedor()
        {
            return objVendedorADO.ListarVendedor();
        }

        public List<VendedorBE> ListarVendedorSP()
        {
            return objVendedorADO.ListarVendedorSP();
        }

        public List<VendedorBE> ListarNombresVendedor()
        {
            return objVendedorADO.ListarNombresVendedor();
        }
    }
}
