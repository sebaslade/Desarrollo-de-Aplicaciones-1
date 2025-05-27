using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agregar dependencias
using ProyVentas_BE;
using ProyVentas_ADO;

namespace ProyVentas_BL
{
    public class ClienteBL
    {
        ClienteADO objClienteADO = new ClienteADO();
        
        public Single CalcularDeudaCliente(String strCodigo)
        {
            return objClienteADO.CalcularDeudaCliente(strCodigo);
        }

        public ClienteBE ConsultarCliente(String strCodigo) 
        {
            return objClienteADO.ConsultarCliente(strCodigo);
        }

        public List<ClienteBE> ListarCliente()
        {
            return objClienteADO.ListarCliente();
        }
    }
}
