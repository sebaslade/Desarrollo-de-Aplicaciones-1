using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using LeonComputing_BE;

namespace LeonComputing_ADO
{
    public class AsociadoADO
    {
        public List<AsociadoBE> ListarAsociado()
        {
            try
            {

                LeonComputingEntities MisAsociados = new LeonComputingEntities();

                List<AsociadoBE> objListaAsociado = new List<AsociadoBE>();

                var query = MisAsociados.usp_ListarAsociados();

                foreach (var resultado in query)
                {
                    AsociadoBE objAsociadoBE = new AsociadoBE();
                    objAsociadoBE.Cod_asociado = resultado.cod_asociado;
                    objAsociadoBE.Ape_paterno = resultado.ape_paterno;
                    objAsociadoBE.Ape_materno = resultado.ape_materno;
                    objAsociadoBE.Nom_aso = resultado.nombres;
                    objAsociadoBE.Dni = resultado.dni;
                    objAsociadoBE.Tlf_celular = resultado.tlf_celular;
                    objListaAsociado.Add(objAsociadoBE);

                }
                return objListaAsociado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
