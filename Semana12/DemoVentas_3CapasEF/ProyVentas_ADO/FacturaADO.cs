using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar dependencias
using ProyVentas_BE;
using System.Data.Entity.Core.Objects; // objectsParameters

namespace ProyVentas_ADO
{
    public class FacturaADO
    {
        public List<FacturaBE> ListarFacturasClienteFechas(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            try
            {
                // Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                // Declaramos la lista de retorno...
                List<FacturaBE> listaFacturas = new List<FacturaBE>();

                // Obtenemos con LINQ las facturas del cliente entre las 2 fechas pasadas...
                var query = (from miFactura in MisVentas.Tb_Factura
                             where miFactura.Cod_cli == strCodigo && miFactura.Fec_fac >= fecIni && miFactura.Fec_fac <= fecFin
                             select miFactura);

                // Recorre el resultado y llenamos la lista de facturas...
                foreach (var resultado in query) 
                { 
                    FacturaBE objFacturaBE = new FacturaBE();
                    objFacturaBE.Num_fac = resultado.Num_fac;
                    objFacturaBE.Fec_fac = resultado.Fec_fac;
                    objFacturaBE.Fec_can = resultado.Fec_can;
                    objFacturaBE.Est_fac = Convert.ToInt16(resultado.Est_fac);
                    
                    if(objFacturaBE.Est_fac == 1)
                    {
                        objFacturaBE.Estado = "Pendiente";
                    }
                    else if(objFacturaBE.Est_fac == 2)
                    {
                        objFacturaBE.Estado = "Cancelada";
                    }
                    else
                    {
                        objFacturaBE.Estado = "Anulada";
                    }
                    objFacturaBE.Cod_ven = resultado.Cod_ven;
                    objFacturaBE.ApellNom_ven = resultado.Tb_Vendedor.Ape_ven + ", " + resultado.Tb_Vendedor.Nom_ven;
                    objFacturaBE.Total = Convert.ToSingle((
                            from detalle in MisVentas.Tb_Detalle_Factura
                            where detalle.Num_fac == resultado.Num_fac
                            select detalle.Can_ven * detalle.Pre_ven).Sum());
                    // agregamos la instancia a la lista...
                    listaFacturas.Add(objFacturaBE);
                }
                return listaFacturas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FacturaBE> ListarFacturasClienteFechasSP(String strCodigo, DateTime fecIni, DateTime fecFin)
        {
            try
            {
                // Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                // Declaramos la lista de retorno...
                List<FacturaBE> listaFacturas = new List<FacturaBE>();

                // Obtenemos con LINQ las facturas del cliente entre las 2 fechas pasadas...
                var query = MisVentas.usp_ListarFacturasClienteFechas(strCodigo, fecIni, fecFin);

                // Recorre el resultado y llenamos la lista de facturas...
                foreach (var resultado in query)
                {
                    FacturaBE objFacturaBE = new FacturaBE();
                    objFacturaBE.Num_fac = resultado.num_fac;
                    objFacturaBE.Fec_fac = resultado.fec_fac;
                    objFacturaBE.Fec_can = resultado.fec_can;
                    objFacturaBE.Estado = resultado.estado;
                    objFacturaBE.Cod_ven = resultado.Cod_ven;
                    objFacturaBE.ApellNom_ven = resultado.Ape_ven+ ", "+ resultado.Nom_ven;
                    objFacturaBE.Total = Convert.ToSingle(resultado.total);

                    // agregamos la instancia a la lista...
                    listaFacturas.Add(objFacturaBE);
                }
                return listaFacturas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FacturaBE> ListarFacturas_Paginacion(String strCod_cli, String strCod_ven, String strEstado, Int16 intNumPag)
        {
            try
            {
                // Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                // Declaramos la lista de retorno...
                List<FacturaBE> objListaFacturaBE = new List<FacturaBE>();

                // Obtenemos con LINQ las facturas del cliente entre las 2 fechas pasadas...
                var query = MisVentas.usp_ListarFacturas_Paginacion(strCod_cli,strCod_ven, strEstado, intNumPag);

                // Recorre el resultado y llenamos la lista de facturas...
                foreach (var resultado in query)
                {
                    FacturaBE objFacturaBE = new FacturaBE();
                    objFacturaBE.Num_fac = resultado.Num_fac;
                    objFacturaBE.Fec_fac = resultado.Fec_fac;
                    objFacturaBE.Fec_can = resultado.Fec_can;
                    objFacturaBE.Estado = resultado.Estado;
                    objFacturaBE.Ruc_cli = resultado.Ruc_cli;
                    objFacturaBE.Cod_ven = resultado.Cod_ven;
                    objFacturaBE.Total = Convert.ToSingle(resultado.Total);
                    objFacturaBE.Cod_cli = resultado.Cod_cli;
                    objFacturaBE.Raz_soc_cli = resultado.Raz_soc_cli;
                    objFacturaBE.ApellNom_ven = resultado.Ape_ven + ", " + resultado.Nom_ven;

                    // agregamos la instancia a la lista...
                    objListaFacturaBE.Add(objFacturaBE);
                }
                return objListaFacturaBE;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Int16 NumPag_ListarFacturas_Paginacion(String strCod_cli, String strCod_ven, String strEstado)
        {
            try
            {
                // Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                // Declaramos la lista de retorno...
                Int16 intRegistros = 0;
                ObjectParameter NumReg = new ObjectParameter("NumReg", typeof(Int16));
                MisVentas.usp_NumPag_ListarFacturas_Paginacion(strCod_cli, strCod_ven, strEstado, NumReg);

                intRegistros = Convert.ToInt16(NumReg.Value);
                return intRegistros;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<FacturacionAnual> ListarFacturacionAnual()
        {
            try
            {
                // Instanciamos el modelo...
                VentasLeonEntities MisVentas = new VentasLeonEntities();

                // Declaramos la lista de retorno...
                List<FacturacionAnual> objListaFacturacionAnual = new List<FacturacionAnual>();

                // Obtenemos con LINQ las facturas del cliente entre las 2 fechas pasadas...
                var query = MisVentas.usp_VentasPorAño();

                // Recorre el resultado y llenamos la lista de facturas...
                foreach (var resultado in query)
                {
                    FacturacionAnual objFacturacionAnual = new FacturacionAnual();
                    objFacturacionAnual.Año = Convert.ToInt16(resultado.Año);
                    objFacturacionAnual.CantFacturas = Convert.ToInt16(resultado.CantFacturas);
                    objFacturacionAnual.TotalAnual = Convert.ToSingle(resultado.TotalAnual);

                    // agregamos la instancia a la lista...
                    objListaFacturacionAnual.Add(objFacturacionAnual);
                }
                return objListaFacturacionAnual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
