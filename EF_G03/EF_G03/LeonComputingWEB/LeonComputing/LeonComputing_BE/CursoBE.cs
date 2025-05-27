using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class CursoBE
    {
        public String codCurso { get; set; }
        public String descripcion { get; set; }
        public Int16 horas_teoria { get; set; }
        public Int16 horas_practica { get; set; }
        public String nivel_dificultad { get; set; }
        public String comentarios { get; set; }
        public Int16 estado_cur { get; set; }
        public Int16 idEspecialidad { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_registro { get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
    }
}
