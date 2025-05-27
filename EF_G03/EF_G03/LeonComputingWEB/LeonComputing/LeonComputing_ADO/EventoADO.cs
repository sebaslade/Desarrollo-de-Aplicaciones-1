using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using LeonComputing_BE;

namespace LeonComputing_ADO
{
    public class EventoADO
    {
        public List<PresupuestoMensual> ListarPresupuestoMensual()
        {
            try
            {
                LeonComputingEntities leonComputing = new LeonComputingEntities();

                List<PresupuestoMensual> objListaPresupuestoMensual = new List<PresupuestoMensual>();

                var query = leonComputing.usp_PresupuestoCuposPorMes();

                foreach (var result in query)
                {
                    PresupuestoMensual objPresupuestoMensual = new PresupuestoMensual();
                    objPresupuestoMensual.Mes = result.Mes.ToString();
                    objPresupuestoMensual.Presupuesto = Convert.ToDecimal(result.Presupuesto_Requerido);
                    objPresupuestoMensual.Cupos = Convert.ToInt64(result.Cupos_Programados);

                    objListaPresupuestoMensual.Add(objPresupuestoMensual);
                }
                return objListaPresupuestoMensual;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
