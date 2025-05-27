using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeonComputing_ADO;
using LeonComputing_BE;

namespace LeonComputing_BL
{
    public class UsuarioBL
    {
        UsuarioADO objUsuarioADO = new UsuarioADO();

        public UsuarioBE ConsultarUsuario(String strLogin)
        {
            return objUsuarioADO.ConsultarUsuario(strLogin);

        }
    }
}
