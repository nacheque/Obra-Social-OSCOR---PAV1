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
    class AD_Centro
    {

        public static DataTable ObtenerCentrosReporteImprimir()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " SELECT CE.DENOMINACION AS NOMBRE,CE.CALLE,CE.NUMERO,BA.BARRIO,LO.LOCALIDAD,CE.TELEFONO, CE.PROPIO " +
                                  " FROM CENTROS CE " +
                                  " JOIN BARRIOS BA ON CE.ID_BARRIO = BA.ID_BARRIO " +
                                  " JOIN LOCALIDADES LO ON CE.ID_LOCALIDAD = LO.ID_LOCALIDAD";

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

        public static DataTable ObtenerCantidadEspPorCentro()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " select c.denominacion, count(epc.cod_especialidad) as cantidad_especialidades " +
                                  " from CENTROS c join ESPECIALIDADES_POR_CENTROS epc on c.COD_CENTRO = epc.COD_CENTRO " +
                                  " group by c.DENOMINACION ";

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

        public static DataTable ObtenerCentros()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT C.COD_CENTRO, C.DENOMINACION, C.CALLE, C.NUMERO, B.ID_BARRIO, B.BARRIO,\n" +
                    "                    L.ID_LOCALIDAD, L.LOCALIDAD, C.TELEFONO, C.MAIL, C.PROPIO\n" +
                    "              FROM CENTROS C JOIN BARRIOS B ON B.ID_BARRIO = C.ID_BARRIO\n" +
                    "              JOIN LOCALIDADES L ON L.ID_LOCALIDAD = C.ID_LOCALIDAD;";

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

        public static DataTable ObtenerCentrosConEspYProf()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT DISTINCT C.COD_CENTRO, C.DENOMINACION\n" +
                    "              FROM CENTROS C JOIN PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD PCE ON C.COD_CENTRO = PCE.COD_CENTRO;";                   

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

        public static DataTable ObtenerCentrosConEspSinProf()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COD_CENTRO, DENOMINACION FROM CENTROS\n" +
                    "              WHERE COD_CENTRO NOT IN (SELECT COD_CENTRO FROM PROFESIONALES_POR_CENTROS_POR_ESPECIALIDAD)\n" +
                    "              AND COD_CENTRO IN (SELECT COD_CENTRO FROM ESPECIALIDADES_POR_CENTROS)";

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

        public static DataTable ObtenerCentrosConEsp()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT COD_CENTRO, DENOMINACION FROM CENTROS\n" +
                    "                WHERE COD_CENTRO IN(SELECT COD_CENTRO FROM ESPECIALIDADES_POR_CENTROS)";

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

        public static DataTable ObtenerCentroReporte()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Clear();

                string consulta = "SELECT C.COD_CENTRO, C.DENOMINACION " +
                    " FROM  CENTROS C";

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

        public static int ObtenerUltimoIdCentro()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT IDENT_CURRENT ('CENTROS') AS Current_Identity";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = int.Parse(cmd.ExecuteScalar().ToString());
                return resultado;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }

        }

        public static void AgregarCentro(Centro centro, List<EspecialidadPorCentro> especialidadesPorCentros)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objetoTransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO CENTROS (DENOMINACION, CALLE, NUMERO, ID_BARRIO, ID_LOCALIDAD, TELEFONO, MAIL, PROPIO)" +
                    "              VALUES(@denominacion, @calle, @numero, @id_barrio, @id_localidad, @telefono, @mail, @propio)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", centro.Denominacion);
                cmd.Parameters.AddWithValue("@calle", centro.Calle);
                cmd.Parameters.AddWithValue("@numero", centro.Numero);
                cmd.Parameters.AddWithValue("@id_barrio", centro.Barrio.IdBarrio);
                cmd.Parameters.AddWithValue("@id_localidad", centro.Localidad.IdLocalidad);
                cmd.Parameters.AddWithValue("@telefono", centro.Telefono);
                cmd.Parameters.AddWithValue("@mail", centro.Mail);
                cmd.Parameters.AddWithValue("@propio", centro.Propio);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                objetoTransaccion = cn.BeginTransaction("Alta de Centro");

                cmd.Transaction = objetoTransaccion;

                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach (EspecialidadPorCentro especialidadPorCentro in especialidadesPorCentros)
                {
                    string consultaEspPorCentro = "INSERT INTO ESPECIALIDADES_POR_CENTROS (COD_CENTRO, COD_ESPECIALIDAD)" +
                        "                          VALUES(@id_centro, @id_especialidad)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id_centro", especialidadPorCentro.Centro.CodigoCentro);
                    cmd.Parameters.AddWithValue("@id_especialidad", especialidadPorCentro.Especialidad.CodigoEspecialidad);

                    cmd.CommandText = consultaEspPorCentro;

                    cmd.ExecuteNonQuery();
                }

                objetoTransaccion.Commit();
            }
            catch (Exception ex)
            {
                objetoTransaccion.Rollback();
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void EditarCentro(Centro centro, int codigoCentro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE CENTROS SET DENOMINACION = @denominacion, CALLE = @calle, NUMERO = @numero, ID_BARRIO = @id_barrio, " +
                                 " ID_LOCALIDAD = @id_localidad, TELEFONO = @telefono, MAIL = @mail, PROPIO = @propio " +
                                 " WHERE COD_CENTRO = @cod_centro";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@denominacion", centro.Denominacion);
                cmd.Parameters.AddWithValue("@calle", centro.Calle);
                cmd.Parameters.AddWithValue("@numero", centro.Numero);
                cmd.Parameters.AddWithValue("@id_barrio", centro.Barrio.IdBarrio);
                cmd.Parameters.AddWithValue("@id_localidad", centro.Localidad.IdLocalidad);
                cmd.Parameters.AddWithValue("@telefono", centro.Telefono);
                cmd.Parameters.AddWithValue("@mail", centro.Mail);
                cmd.Parameters.AddWithValue("@propio", centro.Propio);
                cmd.Parameters.AddWithValue("@cod_centro", codigoCentro);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();                

                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
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
