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
    public class AD_Practica
    {
        public static DataTable obtenerPracticas()
        {
            string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaDeConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM PRACTICAS";

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

        public static void agregarPractica(Practica practica)
        {
            string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaDeConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO PRACTICAS (DESCRIPCION, PRECIO) VALUES (@descripcion, @precioPract)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@descripcion", practica.DescripcionPractica);
                cmd.Parameters.AddWithValue("@precioPract", practica.PrecioPractica);
               
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

        public static void actualizarPractica(Practica practica, int codigoPractica)
        {
            string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaDeConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                //UPDATE table_name
                //SET column1 = value1, column2 = value2, ...
                //WHERE condition;
                string consulta = "UPDATE PRACTICAS SET DESCRIPCION = @practicaMod, PRECIO = @precioMod WHERE ID_PRACTICA = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@practicaMod", practica.DescripcionPractica);
                cmd.Parameters.AddWithValue("@precioMod", practica.PrecioPractica);
                cmd.Parameters.AddWithValue("@codigo", codigoPractica);

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

        public static void eliminarPractica(int codigoPractica) 
        {

            string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaDeConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM PRACTICAS WHERE ID_PRACTICA = @codigo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigoPractica);

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
