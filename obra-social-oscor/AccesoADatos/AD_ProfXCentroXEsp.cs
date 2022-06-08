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
    class AD_ProfXCentroXEsp
    {
        public static void AsignarProfesionalCentroEsp(ProfesionalPorCentroPorEspecialidad pce)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD\n" +
                    "               (COD_ESPECIALIDAD, COD_CENTRO, MATRICULA) VALUES\n" +
                    "               (@codEsp, @codCentro, @codProf)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codEsp", pce.Especialidad.CodigoEspecialidad);
                cmd.Parameters.AddWithValue("@codCentro", pce.Centro.CodigoCentro);
                cmd.Parameters.AddWithValue("@codProf", pce.Profesional.Matricula);

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

        public static DataTable ObtenerProfXEsp(int codCentro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT E.COD_ESPECIALIDAD, E.NOMBRE, P.MATRICULA, P.APELLIDO + ', ' + P.NOMBRE AS NOMBRE_COMPLETO\n" +
                    "               FROM PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD PCE\n" +
                    "               JOIN PROFESIONALES P ON P.MATRICULA = PCE.MATRICULA\n" +
                    "               JOIN ESPECIALIDADES E ON E.COD_ESPECIALIDAD = PCE.COD_ESPECIALIDAD\n" +
                    "               WHERE PCE.COD_CENTRO = @codCentro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCentro", codCentro);


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

        public static void EliminarAsignacionPCE(int codCentro, int codEsp, int matricula)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD\n" + 
                    "               WHERE COD_CENTRO = @codCentro AND COD_ESPECIALIDAD = @codEsp AND MATRICULA = @matricula";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCentro", codCentro);
                cmd.Parameters.AddWithValue("@codEsp", codEsp);
                cmd.Parameters.AddWithValue("@matricula", matricula);
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
