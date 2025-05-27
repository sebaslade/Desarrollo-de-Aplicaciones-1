using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar dependencias
using ProyVentas_BE;
using ProyVentas_ADO;

namespace ProyVentas_BL
{
    public class FacturaBL
    {
        FacturaADO objFacturaADO = new FacturaADO();

        public List<FacturaBE> ListarFacturasClienteFechas(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            return objFacturaADO.ListarFacturasClienteFechas(strCodigo, fecIni, fecFin);
        }

        public List<FacturaBE> ListarFacturasClienteFechasSP(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            return objFacturaADO.ListarFacturasClienteFechasSP(strCodigo, fecIni, fecFin);
        }

        public List<FacturaBE> ListarFacturas_Paginacion(String strCod_cli, String strCod_ven, String strEstado, Int16 intNumPag)
        {
            return objFacturaADO.ListarFacturas_Paginacion(strCod_cli, strCod_ven, strEstado, intNumPag);
        }

        public Int16 NumPag_ListarFacturas_Paginacion(String strCod_cli, String strCod_ven, String strEstado)
        {
            return objFacturaADO.NumPag_ListarFacturas_Paginacion(strCod_cli, strCod_ven, strEstado);
        }

        public List<FacturacionAnual> ListarFacturacionAnual()
        {
            return objFacturaADO.ListarFacturacionAnual();
        }
    }
}
