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
    class AD_CuotaPaga
    {
        public static DataTable ObtenerCuotasPagas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT AF.NRO_AFILIADO, AF.APELLIDO + ', ' + AF.NOMBRE AS NOMBRE_COMPLETO_AFILIADO, " +
                                 " CP.NRO_CUOTA, CP.ANIO_CUOTA, CP.FECHA_PAGO, CP.MONTO_EMERGENCIA, CP.TOTAL_PAGO " +
                                 " FROM CUOTAS_PAGAS CP " +
                                 " JOIN AFILIADOS AF ON CP.NRO_AFILIADO = AF.NRO_AFILIADO";

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

        public static void AgregarCuotaPaga(CuotaPaga cuotaPaga)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO CUOTAS_PAGAS (NRO_AFILIADO, NRO_CUOTA, ANIO_CUOTA, MONTO_EMERGENCIA, TOTAL_PAGO)" +
                                 " VALUES (@nro_afiliado, @nro_cuota, @anio_cuota, @monto_emergencia, @total_pago)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_afiliado", cuotaPaga.Afiliado.NumeroAfiliado);
                cmd.Parameters.AddWithValue("@nro_cuota", cuotaPaga.NumeroCuota);
                cmd.Parameters.AddWithValue("@anio_cuota", cuotaPaga.AnioCuota);
                cmd.Parameters.AddWithValue("@monto_emergencia", cuotaPaga.MontoEmergencia);
                cmd.Parameters.AddWithValue("@total_pago", cuotaPaga.TotalPago);

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

        public static void EliminarCuotaPaga(int numeroAfiliado, int nroCuota, int anio)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = " DELETE FROM CUOTAS_PAGAS " +
                                  " WHERE NRO_AFILIADO = @nro_afiliado " +
                                  " AND NRO_CUOTA = @nro_cuota " +
                                  " AND ANIO_CUOTA = @anio_cuota ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_afiliado", numeroAfiliado);
                cmd.Parameters.AddWithValue("@nro_cuota", nroCuota);
                cmd.Parameters.AddWithValue("@anio_cuota", anio);

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