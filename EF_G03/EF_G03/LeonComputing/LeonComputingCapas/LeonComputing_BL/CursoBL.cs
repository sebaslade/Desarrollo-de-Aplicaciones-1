using LeonComputing_ADO;
using LeonComputing_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BL
{
    public class CursoBL
    {
        CursoADO objCursoADO = new CursoADO();

        public bool InsertarCurso(CursoBE objCursoBE)
        {
            return objCursoADO.InsertarCurso(objCursoBE);
        }

        public bool ActualizarCurso(CursoBE objCursoBE)
        {
            return objCursoADO.ActualizarCurso(objCursoBE);
        }

        public CursoBE ConsultarCurso(string codCurso)
        {
            return objCursoADO.ConsultarCurso(codCurso);
        }

        public DataTable ListarCurso()
        {
            return objCursoADO.ListarCurso();
        }
    }
}
