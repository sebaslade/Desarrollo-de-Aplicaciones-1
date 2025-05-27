using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LeonComputing_BE;

namespace LeonComputing_ADO
{
    public class AsociadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarAsociado(AsociadoBE objAsociadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarAsociado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vape_paterno", objAsociadoBE.Ape_paterno);
                cmd.Parameters.AddWithValue("@vape_materno", objAsociadoBE.Ape_materno);
                cmd.Parameters.AddWithValue("@vnombres", objAsociadoBE.Nom_aso);
                cmd.Parameters.AddWithValue("@vdireccion", objAsociadoBE.Dir_aso);
                cmd.Parameters.AddWithValue("@vdni", objAsociadoBE.Dni);
                cmd.Parameters.AddWithValue("@vfoto", objAsociadoBE.foto);
                cmd.Parameters.AddWithValue("@vtlf_celular", objAsociadoBE.Tlf_celular);
                cmd.Parameters.AddWithValue("@vtlf_domicilio", objAsociadoBE.Tlf_domicilio);
                cmd.Parameters.AddWithValue("@vcorreo", objAsociadoBE.Correo);
                cmd.Parameters.AddWithValue("@vId_Empresa", objAsociadoBE.Id_Empresa);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objAsociadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vusuario_registro", objAsociadoBE.Usu_registro);
                cmd.Parameters.AddWithValue("@vestado_aso", objAsociadoBE.Est_aso);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarAsociado(AsociadoBE objAsociadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarAsociado";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vcod_asociado", objAsociadoBE.Cod_asociado);
                cmd.Parameters.AddWithValue("@vape_paterno", objAsociadoBE.Ape_paterno);
                cmd.Parameters.AddWithValue("@vape_materno", objAsociadoBE.Ape_materno);
                cmd.Parameters.AddWithValue("@vnombres", objAsociadoBE.Nom_aso);
                cmd.Parameters.AddWithValue("@vdireccion", objAsociadoBE.Dir_aso);
                cmd.Parameters.AddWithValue("@vdni", objAsociadoBE.Dni);
                cmd.Parameters.AddWithValue("@vfoto", objAsociadoBE.foto);
                cmd.Parameters.AddWithValue("@vtlf_celular", objAsociadoBE.Tlf_celular);
                cmd.Parameters.AddWithValue("@vtlf_domicilio", objAsociadoBE.Tlf_domicilio);
                cmd.Parameters.AddWithValue("@vcorreo", objAsociadoBE.Correo);
                cmd.Parameters.AddWithValue("@vId_Empresa", objAsociadoBE.Id_Empresa);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objAsociadoBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vusuario_ult_modificacion", objAsociadoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vestado_aso", objAsociadoBE.Est_aso);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public AsociadoBE ConsultarAsociado(String strCod)
        { 
            try
            {
                AsociadoBE objAsociadoBE = new AsociadoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarAsociado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_asociado", strCod);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if(dtr.HasRows == true )
                {
                    dtr.Read();
                    objAsociadoBE.Cod_asociado = dtr["cod_asociado"].ToString();
                    objAsociadoBE.Ape_paterno = dtr["ape_paterno"].ToString();
                    objAsociadoBE.Ape_materno = dtr["ape_materno"].ToString();
                    objAsociadoBE.Nom_aso = dtr["nombres"].ToString();
                    objAsociadoBE.Dir_aso = dtr["direccion"].ToString();
                    objAsociadoBE.Dni = dtr["dni"].ToString();
                    objAsociadoBE.foto = dtr["foto"] != DBNull.Value ? (Byte[])(dtr["foto"]) : null;
                    objAsociadoBE.Tlf_celular = dtr["tlf_celular"].ToString();
                    objAsociadoBE.Tlf_domicilio = dtr["tlf_domicilio"].ToString();
                    objAsociadoBE.Correo = dtr["correo"].ToString();
                    objAsociadoBE.Id_Empresa = Convert.ToInt16(dtr["Id_Empresa"]);
                    objAsociadoBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objAsociadoBE.Est_aso = Convert.ToInt16(dtr["estado_aso"]);
                    dtr.Close();
                }
                return objAsociadoBE;
            }   
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public DataTable ListarAsociado()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAsociados";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Asociado");
                return dts.Tables["Asociado"];
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
        }
    }
}
