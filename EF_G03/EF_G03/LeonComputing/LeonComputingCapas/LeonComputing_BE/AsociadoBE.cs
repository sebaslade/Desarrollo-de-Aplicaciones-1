using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_BE
{
    public class AsociadoBE
    {
        public String Cod_asociado { get; set; }
        public String Ape_paterno { get; set; }
        public String Ape_materno { get; set; }
        public String Nom_aso {  get; set; }
        public String Dir_aso { get; set; }
        public String Dni {  get; set; }
        public String Tlf_domicilio {  get; set; }
        public String Tlf_celular {  get; set; }
        public String Correo { get; set; }
        public Int16 Est_aso { get; set; }
        public Int16 Id_Empresa { get; set; }
        public Byte[] foto { get; set; }
        public String Id_Ubigeo { get; set; }
        public DateTime Fec_Registro { get; set; }
        public String Usu_registro {  get; set; }
        public String Usu_Ult_Mod { get; set; }
        public DateTime Fec_Ult_Mod {  get; set; }
    }
}
