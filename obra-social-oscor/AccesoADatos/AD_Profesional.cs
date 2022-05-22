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
    class AD_Profesional
    {
        public static DataTable ObtenerProfesionales()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT P.MATRICULA, P.APELLIDO, P.NOMBRE, P.CALLE, P.NUMERO,\n" +
                    "		              P.ID_BARRIO, B.BARRIO, P.ID_LOCALIDAD, L.LOCALIDAD, P.TELEFONO\n" +
                    "              FROM PROFESIONALES P\n" +
                    "              JOIN BARRIOS B ON P.ID_BARRIO = B.ID_BARRIO\n" +
                    "              JOIN LOCALIDADES L ON P.ID_LOCALIDAD = L.ID_LOCALIDAD;";

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

        public static void AgregarProfesional(Profesional profesional)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO PROFESIONALES (APELLIDO, NOMBRE, CALLE, NUMERO, ID_BARRIO, ID_LOCALIDAD, TELEFONO)" +
                                " VALUES (@apellido, @nombre, @calle, @numero, @id_barrio, @id_localidad, @telefono)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@apellido", profesional.Apellido);
                cmd.Parameters.AddWithValue("@nombre", profesional.Nombre);
                cmd.Parameters.AddWithValue("@calle", profesional.Calle);
                cmd.Parameters.AddWithValue("@numero", profesional.NumeroCalle);
                cmd.Parameters.AddWithValue("@id_barrio", profesional.Barrio.IdBarrio);
                cmd.Parameters.AddWithValue("@id_localidad", profesional.Localidad.IdLocalidad);
                cmd.Parameters.AddWithValue("@telefono", profesional.Telefono);

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

        public static void EditarProfesional(Profesional profesional, int matricula)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE PROFESIONALES SET APELLIDO = @apellido, NOMBRE = @nombre, CALLE = @calle, NUMERO = @numero, " +
                    "ID_BARRIO = @id_barrio, ID_LOCALIDAD = @id_localidad, TELEFONO = @telefono WHERE MATRICULA = @matricula";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@apellido", profesional.Apellido);
                cmd.Parameters.AddWithValue("@nombre", profesional.Nombre);
                cmd.Parameters.AddWithValue("@calle", profesional.Calle);
                cmd.Parameters.AddWithValue("@numero", profesional.NumeroCalle);
                cmd.Parameters.AddWithValue("@id_barrio", profesional.Barrio.IdBarrio);
                cmd.Parameters.AddWithValue("@id_localidad", profesional.Localidad.IdLocalidad);
                cmd.Parameters.AddWithValue("@telefono", profesional.Telefono);

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


        public static void EliminarProfesional(int matricula)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM PROFESIONALES WHERE MATRICULA = @matricula";

                cmd.Parameters.Clear();
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
