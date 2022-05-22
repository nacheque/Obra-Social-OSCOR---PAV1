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
    class AD_ValorCuota
    {
        public static DataTable ObtenerValoresDeCoutas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT VC.ID_TIPO_AFILIADO, VC.EDAD_DESDE, VC.EDAD_HASTA, VC.MONTO, TP.DESCRIPCION\n" +
                    "              FROM VALOR_CUOTA VC\n" +
                    "              JOIN TIPOS_AFILIADO TP\n" +
                    "              ON VC.ID_TIPO_AFILIADO = TP.COD_TIPO;";

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

        public static void AgregarVC(ValorCuota valorCuota)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO VALOR_CUOTA (ID_TIPO_AFILIADO, EDAD_DESDE, EDAD_HASTA, MONTO) VALUES (@tipoAfiliado, @edadDesde, @edadHasta, @monto)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoAfiliado", valorCuota.TipoAfiliado.CodigoTipoAfiliado);
                cmd.Parameters.AddWithValue("@edadDesde", valorCuota.EdadDesde);
                cmd.Parameters.AddWithValue("@edadHasta", valorCuota.EdadHasta);
                cmd.Parameters.AddWithValue("@monto", valorCuota.Monto);

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

        public static void ActualizarVC(ValorCuota valorCuota, int idTipoAfiliado, int edadDesde)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE VALOR_CUOTA SET EDAD_HASTA = @edadHasta, MONTO = @monto\n" +
                    "               WHERE ID_TIPO_AFILIADO = @idTipoAfiliado AND EDAD_DESDE = @edadDesde";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@edadHasta", valorCuota.EdadHasta);
                cmd.Parameters.AddWithValue("@monto", valorCuota.Monto);
                cmd.Parameters.AddWithValue("@idTipoAfiliado", idTipoAfiliado);
                cmd.Parameters.AddWithValue("@edadDesde", edadDesde);

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

        public static void EliminarVC(int idTipoAfiliado, int edadDesde)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM VALOR_CUOTA WHERE ID_TIPO_AFILIADO = @idTipoAfiliado AND EDAD_DESDE = @edadDesde";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idTipoAfiliado", idTipoAfiliado);
                cmd.Parameters.AddWithValue("@edadDesde", edadDesde);

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
