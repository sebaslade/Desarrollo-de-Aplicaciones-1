using LeonComputing_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeonComputing_ADO
{
    public class EventoADO
    {
        ConexionADO MiConexionADO = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarEvento(EventoBE objEventosBE)
        {
            try
            {
                cnx.ConnectionString = MiConexionADO.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEvento";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vId_Empresa", objEventosBE.id_empresa);
                cmd.Parameters.AddWithValue("@vid_frecuencia", objEventosBE.id_frecuencia);
                cmd.Parameters.AddWithValue("@vid_turno", objEventosBE.id_turno);
                cmd.Parameters.AddWithValue("@vfecha_inicio", objEventosBE.fecha_inicio);
                cmd.Parameters.AddWithValue("@vfecha_fin", objEventosBE.fecha_fin);
                cmd.Parameters.AddWithValue("@vpresupuesto_requerido", objEventosBE.presupuesto_requerido);
                cmd.Parameters.AddWithValue("@vdireccion_evento", objEventosBE.dirección_evento);
                cmd.Parameters.AddWithValue("@vcupos_programados", objEventosBE.cupos_programados);
                cmd.Parameters.AddWithValue("@vId_Expositor", objEventosBE.id_Expositor);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objEventosBE.id_Ubigeo);
                cmd.Parameters.AddWithValue("@vcod_curso", objEventosBE.cod_curso);
                cmd.Parameters.AddWithValue("@vusuario_registro", objEventosBE.usu_registro);
                cmd.Parameters.AddWithValue("@vestado_eve", objEventosBE.estado_eve);

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
        public Boolean ActualizarEvento(EventoBE objEventosBE)
        {
            try
            {
                cnx.ConnectionString = MiConexionADO.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEvento";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vid_evento", objEventosBE.id_evento);
                cmd.Parameters.AddWithValue("@vId_Empresa", objEventosBE.id_empresa);
                cmd.Parameters.AddWithValue("@vid_frecuencia", objEventosBE.id_frecuencia);
                cmd.Parameters.AddWithValue("@vid_turno", objEventosBE.id_turno);
                cmd.Parameters.AddWithValue("@vfecha_inicio", objEventosBE.fecha_inicio);
                cmd.Parameters.AddWithValue("@vfecha_fin", objEventosBE.fecha_fin);
                cmd.Parameters.AddWithValue("@vpresupuesto_requerido", objEventosBE.presupuesto_requerido);
                cmd.Parameters.AddWithValue("@vdireccion_evento", objEventosBE.dirección_evento);
                cmd.Parameters.AddWithValue("@vcupos_programados", objEventosBE.cupos_programados);
                cmd.Parameters.AddWithValue("@vId_Expositor", objEventosBE.id_Expositor);
                cmd.Parameters.AddWithValue("@vId_Ubigeo", objEventosBE.id_Ubigeo);
                cmd.Parameters.AddWithValue("@vcod_curso", objEventosBE.cod_curso);
                cmd.Parameters.AddWithValue("@vusuario_ult_modificacion", objEventosBE.usuario_ult_modificacion);
                cmd.Parameters.AddWithValue("@vestado_eve", objEventosBE.estado_eve);

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
        public Boolean EliminarEvento(EventoBE objEventoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexionADO.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEvento";

                cmd.Parameters.Clear();
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
        public EventoBE ConsultarEvento(String strCodigo)
        {
            try
            {
                EventoBE objEventosBE = new EventoBE();
                cnx.ConnectionString = MiConexionADO.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEvento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vid_evento", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEventosBE.id_evento = Convert.ToInt16(dtr["id_evento"].ToString());
                    objEventosBE.id_empresa = Convert.ToInt16(dtr["id_empresa"]);
                    objEventosBE.id_frecuencia = Convert.ToInt16(dtr["id_frecuencia"].ToString());
                    objEventosBE.id_turno = Convert.ToInt16(dtr["id_turno"].ToString());
                    objEventosBE.fecha_inicio = Convert.ToDateTime(dtr["fecha_inicio"].ToString());
                    objEventosBE.fecha_fin = Convert.ToDateTime(dtr["fecha_fin"].ToString());
                    objEventosBE.presupuesto_requerido = Convert.ToDecimal(dtr["presupuesto_requerido"].ToString());
                    objEventosBE.dirección_evento = dtr["direccion_evento"].ToString();
                    objEventosBE.cupos_programados = Convert.ToInt16(dtr["cupos_programados"].ToString());
                    objEventosBE.id_Expositor = dtr["id_Expositor"].ToString();
                    objEventosBE.id_Ubigeo = dtr["id_Ubigeo"].ToString();
                    objEventosBE.cod_curso = dtr["cod_curso"].ToString();
                    objEventosBE.estado_eve = Convert.ToInt16(dtr["estado_eve"]);
                    dtr.Close();
                }
                return objEventosBE;

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
        public DataTable ListarEvento()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexionADO.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEventos";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Eventos");
                return dts.Tables["Eventos"];
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
    }
}
