using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agregamos dependencias
using ProyVentas_BE;

namespace ProyVentas_ADO
{
    public class VendedorADO
    {
        public List<VendedorBE> ListarVendedor()
        {
            try
            {
                // Instanciamos
                VentasLeonEntities MisVentas = new VentasLeonEntities();
                List<VendedorBE> objListaVendedor = new List<VendedorBE>();
                
                // Con LinQ obtenemos la coleccion de 
                var query = (from miVendedor in MisVentas.Tb_Vendedor
                             orderby miVendedor.Ape_ven, miVendedor.Nom_ven
                             select miVendedor).ToList();

                foreach (var resultado in query) 
                {
                    VendedorBE objVendedorBE = new VendedorBE();
                    objVendedorBE.Cod_ven = resultado.Cod_ven;
                    objVendedorBE.Ape_ven = resultado.Ape_ven;
                    objVendedorBE.Nom_ven = resultado.Nom_ven;
                    objVendedorBE.Sue_ven = Convert.ToSingle(resultado.Sue_ven);
                    objVendedorBE.Fec_ing = Convert.ToDateTime(resultado.Fec_ing);
                    objVendedorBE.ApellNom_Supervisor = resultado.Tb_Vendedor2.Ape_ven+", "+resultado.Tb_Vendedor2.Nom_ven;
                    objVendedorBE.Estado = Convert.ToInt16(resultado.Est_ven)==1 ?"Activo" :"Inactivo";
                    objListaVendedor.Add(objVendedorBE);
                }
                return objListaVendedor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VendedorBE> ListarVendedorSP()
        {
            try
            {
                // Instanciamos
                VentasLeonEntities MisVentas = new VentasLeonEntities();
                List<VendedorBE> objListaVendedor = new List<VendedorBE>();

                // Con LinQ obtenemos la coleccion de 
                var query = MisVentas.usp_ListarVendedor();

                foreach (var resultado in query)
                {
                    VendedorBE objVendedorBE = new VendedorBE();
                    objVendedorBE.Cod_ven = resultado.Cod_ven;
                    objVendedorBE.Ape_ven = resultado.Ape_ven;
                    objVendedorBE.Nom_ven = resultado.Nom_ven;
                    objVendedorBE.Sue_ven = Convert.ToSingle(resultado.Sue_ven);
                    objVendedorBE.Fec_ing = Convert.ToDateTime(resultado.Fec_ing);
                    objVendedorBE.ApellNom_Supervisor = resultado.NomSupervisor;
                    objVendedorBE.Estado = Convert.ToInt16(resultado.Est_ven) == 1 ? "Activo" : "Inactivo";
                    objListaVendedor.Add(objVendedorBE);
                }
                return objListaVendedor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<VendedorBE> ListarNombresVendedor()
        {
            try
            {
                // Instanciamos
                VentasLeonEntities MisVentas = new VentasLeonEntities();
                List<VendedorBE> objListaVendedor = new List<VendedorBE>();

                // Con LinQ obtenemos la coleccion de 
                var query = (from miVendedor in MisVentas.Tb_Vendedor
                             orderby miVendedor.Ape_ven, miVendedor.Nom_ven
                             select miVendedor).ToList();

                foreach (var resultado in query)
                {
                    VendedorBE objVendedorBE = new VendedorBE();
                    objVendedorBE.Cod_ven = resultado.Cod_ven;
                    objVendedorBE.ApellNom_ven = resultado.Ape_ven + ", " + resultado.Nom_ven;
                    objListaVendedor.Add(objVendedorBE);
                }
                return objListaVendedor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
