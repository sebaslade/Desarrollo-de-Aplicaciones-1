using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeonComputing_BE;

namespace LeonComputing_ADO
{
    public class CursoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public Boolean InsertarCurso(CursoBE objCursoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCurso";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vdescripcion", objCursoBE.descripcion);
                cmd.Parameters.AddWithValue("@vhoras_teoria", objCursoBE.horas_teoria);
                cmd.Parameters.AddWithValue("@vhoras_practica", objCursoBE.horas_practica);
                cmd.Parameters.AddWithValue("@vnivel_dificultad", objCursoBE.nivel_dificultad);
                cmd.Parameters.AddWithValue("@vcomentarios", objCursoBE.comentarios);
                cmd.Parameters.AddWithValue("@vIdEspecialidad", objCursoBE.idEspecialidad);
                cmd.Parameters.AddWithValue("@vusuario_registro", objCursoBE.Usu_registro);
                cmd.Parameters.AddWithValue("@vestado_cur", objCursoBE.estado_cur);

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

        public Boolean ActualizarCurso(CursoBE objCursoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCurso";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@vcod_curso", objCursoBE.codCurso);
                cmd.Parameters.AddWithValue("@vdescripcion", objCursoBE.descripcion);
                cmd.Parameters.AddWithValue("@vhoras_teoria", objCursoBE.horas_teoria);
                cmd.Parameters.AddWithValue("@vhoras_practica", objCursoBE.horas_practica);
                cmd.Parameters.AddWithValue("@vnivel_dificultad", objCursoBE.nivel_dificultad);
                cmd.Parameters.AddWithValue("@vcomentarios", objCursoBE.comentarios);
                cmd.Parameters.AddWithValue("@vIdEspecialidad", objCursoBE.idEspecialidad);
                cmd.Parameters.AddWithValue("@vusuario_ult_modificacion", objCursoBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vestado_cur", objCursoBE.estado_cur);

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

        public CursoBE ConsultarCurso(String codCurso)
        {
            try
            {
                CursoBE objCursoBE = new CursoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCurso";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod_curso", codCurso);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objCursoBE.codCurso = dtr["cod_curso"].ToString();
                    objCursoBE.descripcion = dtr["descripcion"].ToString();
                    objCursoBE.horas_teoria = Convert.ToInt16(dtr["horas_teoria"]);
                    objCursoBE.horas_practica = Convert.ToInt16(dtr["horas_practica"]);
                    objCursoBE.nivel_dificultad = dtr["nivel_dificultad"].ToString();
                    objCursoBE.comentarios = dtr["comentarios"].ToString();
                    objCursoBE.estado_cur = Convert.ToInt16(dtr["estado_cur"]);
                    objCursoBE.idEspecialidad = Convert.ToInt16(dtr["IdEspecialidad"]);
                    dtr.Close();
                }
                return objCursoBE;
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

        public DataTable ListarCurso()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCursos";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Curso");
                return dts.Tables["Curso"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
