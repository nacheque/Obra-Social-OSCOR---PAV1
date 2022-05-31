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
    class AD_Cobertura
    {
        public static DataTable ObtenerCobertura()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT C.ID_TIPO_AFILIADO, TP.DESCRIPCION, C.ID_PRACTICA,\n" +
                    "              P.DESCRIPCION, P.PRECIO,C.PORC_COBERTURA\n" +
                    "              FROM COBERTURAS C\n" +
                    "              INNER JOIN TIPOS_AFILIADO TP\n" +
                    "              ON C.ID_TIPO_AFILIADO = TP.COD_TIPO" +
                    "              INNER JOIN PRACTICAS P\n" +
                    "              ON C.ID_PRACTICA = P.ID_PRACTICA";
                /*SELECT A.NRO_AFILIADO, A.APELLIDO, A.NOMBRE, A.FECHA_NACIMIENTO,\n" +
                    "                     A.FECHA_INSCRIPCION, A.MONTO_INSCRIPCION, A.ID_TIPO_AFILIADO, TP.DESCRIPCION\n"*/
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

        public static int ObtenerCoberturaPorTipoAfiliadoYPractica(int idPractica, int idTipoAfiliado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT PORC_COBERTURA FROM COBERTURAS WHERE ID_TIPO_AFILIADO = @id_tipo_afiliado AND ID_PRACTICA = @id_practica";                   
                
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_tipo_afiliado", idTipoAfiliado);
                cmd.Parameters.AddWithValue("@id_practica", idPractica);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = int.Parse(cmd.ExecuteScalar().ToString());
                return resultado;

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

        public static void AgregarCobetura(Cobertura cobertura)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO COBERTURAS (ID_TIPO_AFILIADO, ID_PRACTICA, PORC_COBERTURA)" +
                                " VALUES (@tipoAfiliado, @practica, @porcentaje)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoAfiliado", cobertura.TipoAfiliado.CodigoTipoAfiliado);
                cmd.Parameters.AddWithValue("@practica", cobertura.Practica.CodigoPractica);
                cmd.Parameters.AddWithValue("@porcentaje", cobertura.Porcentaje);

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

        public static void ActualizarCobertura(Cobertura cobertura, int id_tipo, int id_practica)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE COBERTURAS SET ID_TIPO_AFILIADO = @id_tipo_afiliado, ID_PRACTICA = @id_practica,\n" +
                    "              PORC_COBERTURA = @porcentaje\n" +
                    "              WHERE ID_TIPO_AFILIADO = @id_tipo_afiliado AND ID_PRACTICA = @id_practica";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_tipo_afiliado", id_tipo);
                cmd.Parameters.AddWithValue("@id_practica", id_practica);
                cmd.Parameters.AddWithValue("@porcentaje", cobertura.Porcentaje);

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

        public static void EliminarCobertura(int id_tipo, int id_practica)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM COBERTURAS WHERE ID_TIPO_AFILIADO = @id_tipo_afiliado AND ID_PRACTICA = @id_practica";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_tipo_afiliado", id_tipo);
                cmd.Parameters.AddWithValue("@id_practica", id_practica);

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
