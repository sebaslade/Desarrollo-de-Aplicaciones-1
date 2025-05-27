using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar dependencias
using LeonComputing_ADO;
using LeonComputing_BE;


namespace LeonComputing_BL
{
    public class CursoBL
    {
        CursoADO objCursoADO = new CursoADO();

        public List<CursoBE> ListarCurso()
        {
            return objCursoADO.ListarCurso();
        }
    }
}
