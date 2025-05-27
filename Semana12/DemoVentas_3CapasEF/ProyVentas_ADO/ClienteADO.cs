using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregar...
using ProyVentas_BE;

namespace ProyVentas_ADO
{
    public class ClienteADO
    {
        public Single CalcularDeudaCliente(String strCodigo)
        {
            try
            {
                // instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();
                Single sngDeuda = 0;
                // Con LINQ obtenemos la deuda del cliente...
                int factPendientes = MisVentas.Tb_Factura.Where(miFactura => miFactura.Cod_cli == strCodigo && 
                    miFactura.Est_fac == 1).Count();

                if(factPendientes == 0)
                {
                    sngDeuda = 0;
                }
                else
                {
                    sngDeuda = Convert.ToSingle((
                        from miFactura in MisVentas.Tb_Factura 
                        join detalles in MisVentas.Tb_Detalle_Factura on miFactura.Num_fac equals detalles.Num_fac 
                        where miFactura.Cod_cli == strCodigo && miFactura.Est_fac == 1 
                        select detalles.Can_ven * detalles.Pre_ven).Sum()
                    );
                }
                return sngDeuda;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteBE ConsultarCliente(String strCodigo)
        {
            try
            {
                //Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                // Obtenemos el cliente consultando mediante LINQ...
                Tb_Cliente objCliente = (
                    from miCliente in MisVentas.Tb_Cliente
                    where miCliente.Cod_cli == strCodigo
                    select miCliente).FirstOrDefault();

                // Instanciamos ClienteBE...
                ClienteBE objClienteBE = new ClienteBE();

                // Validamos si el cliente existe...
                if(objCliente == null)
                {
                    // si el cliente no existe, asignaremos con una cadena en blanco la propiedad cod_cli
                    objClienteBE.Cod_cli = String.Empty;
                }
                else
                {
                    // Si el cliente existe cargamos las propiedades de la entidad de negocios...
                    objClienteBE.Cod_cli = objCliente.Cod_cli;
                    objClienteBE.Raz_soc_cli = objCliente.Raz_soc_cli;
                    objClienteBE.Ruc_cli = objCliente.Ruc_cli;
                    objClienteBE.Tel_cli = objCliente.Tel_cli;
                    objClienteBE.Dir_cli = objCliente.Dir_cli;
                    objClienteBE.Departamento = objCliente.Tb_Ubigeo.Departamento;
                    objClienteBE.Provincia = objCliente.Tb_Ubigeo.Provincia;
                    objClienteBE.Distrito = objCliente.Tb_Ubigeo.Distrito;
                    objClienteBE.Deuda = CalcularDeudaCliente(objCliente.Cod_cli);
                    objClienteBE.Fec_Registro = objCliente.Fec_reg;
                }
                return objClienteBE;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteBE> ListarCliente()
        {
            try
            {
                //Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                List<ClienteBE> objListaClienteBE = new List<ClienteBE>();

                // Obtenemos el cliente consultando mediante LINQ...
                var query = MisVentas.Tb_Cliente.OrderBy(miCliente => miCliente.Raz_soc_cli).ToList();

                // Instanciamos ClienteBE...
                foreach (var resultado in query) 
                {
                    ClienteBE objClienteBE = new ClienteBE();
                    objClienteBE.Cod_cli = resultado.Cod_cli;
                    objClienteBE.Raz_soc_cli = resultado.Raz_soc_cli;
                    objListaClienteBE.Add(objClienteBE);
                }
                return objListaClienteBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
