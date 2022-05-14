using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using obra_social_oscor.Entidades;
using obra_social_oscor.Formulario.ABM_Comunes;
using System.Windows.Forms;

namespace obra_social_oscor.AccesoADatos
{
    class AD_Afiliado
    {
        public static DataTable ObtenerAfiliado()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT A.NRO_AFILIADO, A.APELLIDO, A.NOMBRE, A.FECHA_NACIMIENTO,\n" +
                    "                     A.FECHA_INSCRIPCION, A.MONTO_INSCRIPCION, A.ID_TIPO_AFILIADO, TP.DESCRIPCION\n" +
                    "              FROM AFILIADOS A\n" +
                    "              JOIN TIPOS_AFILIADO TP\n" +
                    "              ON A.ID_TIPO_AFILIADO = TP.COD_TIPO;";

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

        public static void AgregarAfiliado(Afiliado afiliado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                
                string consulta = "INSERT INTO AFILIADOS (APELLIDO, NOMBRE, FECHA_NACIMIENTO, ID_TIPO_AFILIADO, MONTO_INSCRIPCION)" +
                                " VALUES (@apellido,@nombre,@fechaDeNacimiento,@tipoAfiliado,@Monto)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@apellido", afiliado.ApellidoAfiliado);
                cmd.Parameters.AddWithValue("@nombre", afiliado.NombreAfiliado);
                cmd.Parameters.AddWithValue("@fechaDeNacimiento", afiliado.FechaNacimientoAfiliado);
                cmd.Parameters.AddWithValue("@tipoAfiliado", afiliado.TipoAfiliado);
                cmd.Parameters.AddWithValue("@monto", afiliado.MontoInscripcionAfiliado);

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

        public static void ActualizarAfiliado(Afiliado afiliado, int codigoAfiliado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE AFILIADOS SET APELLIDO = @apellido WHERE NRO_AFILIADO = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@apellido", afiliado.ApellidoAfiliado);
                cmd.Parameters.AddWithValue("@codigo", codigoAfiliado);

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

        public static void EliminarAfiliado(int codigoAfiliado)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM AFILIADOS WHERE NRO_AFILIADO = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigoAfiliado);

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
