using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace obra_social_oscor.AccesoADatos
{
    class AD_Practica
    {
        public static DataTable obtenerComboPracticas()
        {
            string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaDeConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT P.ID_PRACTICA, P.DESCRIPCION FROM PRACTICAS P";

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
    }
}
