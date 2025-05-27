using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
// Agregar...
using LeonComputing_BE;

namespace LeonComputing_ADO
{
    public class CursoADO
    {

        public List<CursoBE> ListarCurso()
        {
            try
            {

                LeonComputingEntities MisCursos = new LeonComputingEntities();
      
                List<CursoBE> objListaCurso = new List<CursoBE>();
               
                var query = MisCursos.usp_ListarCursos();

                foreach (var resultado in query)
                {
                    CursoBE objCursoBE = new CursoBE();
                    objCursoBE.codCurso = resultado.cod_curso;
                    objCursoBE.nivel_dificultad = resultado.nivel_dificultad;
                    objCursoBE.descripcion = resultado.descripcion;
                    objCursoBE.horas_teoria = Convert.ToInt16(resultado.horas_teoria);
                    objCursoBE.horas_practica = Convert.ToInt16(resultado.horas_practica);
                    objCursoBE.nivel_dificultad = resultado.nivel_dificultad;  
                    objListaCurso.Add(objCursoBE);

                }
                return objListaCurso;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
