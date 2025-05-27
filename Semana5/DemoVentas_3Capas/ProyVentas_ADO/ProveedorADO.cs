using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ProyVentas_BE;
namespace ProyVentas_ADO
{
    public class ProveedorADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
          
        
        // Metodos de mantenimiento
        public Boolean InsertarProveedor(ProveedorBE objProveedorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProveedor";
                cmd.Parameters.Clear();
                //Agregamos parametros 
                //Codifique
                cmd.Parameters.AddWithValue("@vraz", objProveedorBE.Raz_soc_prv);
                cmd.Parameters.AddWithValue("@vdir", objProveedorBE.Dir_prv);
                cmd.Parameters.AddWithValue("@vtel", objProveedorBE.Tel_prv);
                cmd.Parameters.AddWithValue("@vruc", objProveedorBE.Ruc_prv);
                cmd.Parameters.AddWithValue("@vrep", objProveedorBE.Rep_ven);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProveedorBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vEst_prv", objProveedorBE.Est_prv);

                // Ejecutamos
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
        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProveedor";
                //Agregamos parametros 
                cmd.Parameters.Clear();
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", objProveedorBE.Cod_prv);
                cmd.Parameters.AddWithValue("@vraz", objProveedorBE.Raz_soc_prv);
                cmd.Parameters.AddWithValue("@vdir", objProveedorBE.Dir_prv);
                cmd.Parameters.AddWithValue("@vtel", objProveedorBE.Tel_prv);
                cmd.Parameters.AddWithValue("@vruc", objProveedorBE.Ruc_prv);
                cmd.Parameters.AddWithValue("@vrep", objProveedorBE.Rep_ven);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objProveedorBE.Id_Ubigeo);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objProveedorBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vEst_prv", objProveedorBE.Est_prv);

                //Ejecutamos
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

        public Boolean EliminarProveedor(String strcod)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProveedor";
                //Agregamos parametros 
                cmd.Parameters.Clear();
                //Codifique
                cmd.Parameters.AddWithValue("@vcod", strcod);

                //Ejecutamos
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

        public ProveedorBE ConsultarProveedor(String strCod)
        {
            try
            {
                ProveedorBE objProveedorBE = new ProveedorBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";
                cmd.Parameters.Clear();
                //Agregamos parametros 
                cmd.Parameters.AddWithValue("@vcod", strCod);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                //Codifique
                if(dtr.HasRows == true )
                {
                    dtr.Read();
                    // Asignamos las columnas del dtr a las propiedades de la instancia
                    // con solo los datos que deseamos mostrar en la consulta
                    objProveedorBE.Cod_prv = dtr["Cod_prv"].ToString();
                    objProveedorBE.Raz_soc_prv = dtr["raz_soc_prv"].ToString();
                    objProveedorBE.Ruc_prv = dtr["Ruc_prv"].ToString();
                    objProveedorBE.Dir_prv = dtr["Dir_prv"].ToString();
                    objProveedorBE.Tel_prv = dtr["Tel_prv"].ToString();
                    objProveedorBE.Rep_ven = dtr["Rep_ven"].ToString();
                    objProveedorBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();
                    objProveedorBE.Est_prv = Convert.ToInt16(dtr["Est_prv"]);
                    // Cerramos el dtr y devolvemos la instancia de la entidad de negocios
                    dtr.Close();
                }

                return objProveedorBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public DataTable ListarProveedor()
        {
            try
            {
                //Codifique
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Proveedores");
                return dts.Tables["Proveedores"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
