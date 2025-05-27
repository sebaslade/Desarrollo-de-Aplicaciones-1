using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class EventoBE
    {
        public Int16 id_evento { get; set; }
        public Int16 id_empresa { get; set; }
        public Int16 id_frecuencia { get; set; }
        public Int16 id_turno { get; set; }
        public decimal presupuesto_requerido { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public String dirección_evento { get; set; }
        public Int16 cupos_programados { get; set; }
        public String id_Expositor { get; set; }
        public String id_Ubigeo { get; set; }
        public String cod_curso { get; set; }
        public DateTime fecha_registro { get; set; }
        public String usu_registro { get; set; }
        public String usuario_ult_modificacion { get; set; }
        public DateTime fecha_ult_modificación { get; set; }
        public Int16 estado_eve { get; set; }

    }
    public class PresupuestoMensual
    {
        public Int16 MesNumero { get; set; }
        public String Mes { get; set; }
        public Decimal Presupuesto { get; set; }
        public Int64 Cupos { get; set; }
    }
}
