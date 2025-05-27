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
    public class EventoBL
    {
        EventoADO objEventoADO = new EventoADO();

        public Boolean InsertarEvento(EventoBE objEventoBE)
        {
            return objEventoADO.InsertarEvento(objEventoBE);
        }
        public Boolean ActualizarEvento(EventoBE objEventoBE)
        {
            return objEventoADO.ActualizarEvento(objEventoBE);
        }
        public Boolean EliminarEvento(EventoBE strCodigo)
        {
            return objEventoADO.EliminarEvento(strCodigo);
        }

        public EventoBE ConsultarEvento(String strCodigo)
        {
            return objEventoADO.ConsultarEvento(strCodigo);
        }
        public DataTable ListarEvento()
        {
            return objEventoADO.ListarEvento();
        }
    }
}