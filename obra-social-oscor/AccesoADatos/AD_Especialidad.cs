using obra_social_oscor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.AccesoADatos
{
    public class AD_Especialidad
    {
        public static DataTable ObtenerEspecialidades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM ESPECIALIDADES";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerEspecialidadesPorCentro(int codCentro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT E.COD_ESPECIALIDAD, E.NOMBRE FROM  ESPECIALIDADES E " +
                                  " JOIN PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD PCE " +
                                  " ON E.COD_ESPECIALIDAD = PCE.COD_ESPECIALIDAD " +
                                  " WHERE PCE.COD_CENTRO = @cod_centro ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_centro", codCentro);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerEspecialidadesPorCentroSinProf(int codCentro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "Select e.cod_especialidad, e.nombre\n " +
                    "               From especialidades e\n" +
                    "               join especialidades_por_centros ec\n" +
                    "               on e.cod_especialidad = ec.cod_especialidad\n" +
                    "               Where ec.cod_centro = 19\n" +
                    "               And(select count(*)\n" +
                    "               from profesionales_por_centros_por_especialidad pes\n" +
                    "               where pes.cod_centro = ec.cod_centro and pes.cod_especialidad = ec.cod_especialidad) = 0";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod_centro", codCentro);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void AgregarEspecialidad(Especialidad especialidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO ESPECIALIDADES (NOMBRE) VALUES (@nombre)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", especialidad.NombreEspecialidad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void ActualizarEspecialidad(Especialidad especialidad, int codigoEspecialidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE ESPECIALIDADES SET NOMBRE = @nombre WHERE COD_ESPECIALIDAD = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", especialidad.NombreEspecialidad);
                cmd.Parameters.AddWithValue("@codigo", codigoEspecialidad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void EliminarEspecialidad(int codigoEspecialidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM ESPECIALIDADES WHERE COD_ESPECIALIDAD = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigoEspecialidad);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }

}
