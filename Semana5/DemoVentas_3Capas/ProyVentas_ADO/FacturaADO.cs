using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProyVentas_ADO
{
    public class FacturaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataView dtv;

        public DataTable ListarFacturasClienteFechas(String strCodCli, DateTime FecIni, DateTime FecFin)
        {
            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarFacturasClienteFechas";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codcli", strCodCli);
                cmd.Parameters.AddWithValue("@fecini", FecIni);
                cmd.Parameters.AddWithValue("@fecfin", FecFin);

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Facturas");
                return dts.Tables["Facturas"];
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en el listado:" + ex.Message);
            }
        }
    }
}
