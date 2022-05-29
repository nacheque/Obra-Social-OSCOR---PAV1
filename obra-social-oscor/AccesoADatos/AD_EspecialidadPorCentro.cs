using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.AccesoADatos
{
    class AD_EspecialidadPorCentro
    {
        public static DataTable ObtenerEspecialidadesPorCentro(int codCentro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT EC.COD_ESPECIALIDAD, E.NOMBRE\n" +
                    "              FROM ESPECIALIDADES_POR_CENTROS EC JOIN CENTROS C ON C.COD_CENTRO = EC.COD_CENTRO\n" +
                    "              JOIN ESPECIALIDADES E ON E.COD_ESPECIALIDAD = EC.COD_ESPECIALIDAD\n" +
                    "              WHERE C.COD_CENTRO = @codigo_centro;";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo_centro", codCentro);
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
    }
}
