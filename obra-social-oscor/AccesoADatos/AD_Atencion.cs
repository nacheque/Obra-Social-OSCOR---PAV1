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
    class AD_Atencion
    {
        public static DataTable ObtenerAtenciones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " SELECT AT.ID_ATENCION, AF.NRO_AFILIADO, AF.APELLIDO + ', ' + AF.NOMBRE AS NOMBRE_COMPLETO_AFILIADO, " +
                                  " AT.FECHA_HORA_ATENCION, C.COD_CENTRO, C.DENOMINACION, E.COD_ESPECIALIDAD, E.NOMBRE, " +
                                  " P.MATRICULA, P.APELLIDO + ', ' + P.NOMBRE AS NOMBRE_COMPLETO_PROF, AT.IMPORTE, " +
                                  " PR.ID_PRACTICA, PR.DESCRIPCION " +
                                  " FROM ATENCIONES_POR_AFILIADO AT " +
                                  " JOIN AFILIADOS AF ON AF.NRO_AFILIADO = AT.NRO_AFILIADO " +
                                  " JOIN CENTROS C ON C.COD_CENTRO = AT.COD_CENTRO " +
                                  " JOIN ESPECIALIDADES E ON E.COD_ESPECIALIDAD = AT.COD_ESPECIALIDAD " +
                                  " JOIN PROFESIONALES P ON P.MATRICULA = AT.MATRICULA " +
                                  " JOIN PRACTICAS PR ON PR.ID_PRACTICA = AT.ID_PRACTICA ";

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

        public static void AgregarAtencion(Atencion atencion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO ATENCIONES_POR_AFILIADO (NRO_AFILIADO, COD_CENTRO, COD_ESPECIALIDAD, MATRICULA, IMPORTE, ID_PRACTICA)" +
                                 " VALUES (@nro_afiliado, @cod_centro, @cod_especialidad, @matricula, @importe, @id_practica)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_afiliado", atencion.Afiliado.NumeroAfiliado);
                cmd.Parameters.AddWithValue("@cod_centro", atencion.Centro.CodigoCentro);
                cmd.Parameters.AddWithValue("@cod_especialidad", atencion.Especialidad.CodigoEspecialidad);
                cmd.Parameters.AddWithValue("@matricula", atencion.Profesional.Matricula);
                cmd.Parameters.AddWithValue("@importe", atencion.Importe);
                cmd.Parameters.AddWithValue("@id_practica", atencion.Practica.CodigoPractica);

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

        public static void EditarAtencion(Atencion atencion, int idAtencion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);                 

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE ATENCIONES_POR_AFILIADO SET COD_CENTRO = @cod_centro, " +
                    "COD_ESPECIALIDAD = @cod_especialidad, MATRICULA = @matricula, IMPORTE = @importe, ID_PRACTICA = @id_practica " +
                                 " WHERE ID_ATENCION = @id_atencion";

                cmd.Parameters.Clear();                
                cmd.Parameters.AddWithValue("@cod_centro", atencion.Centro.CodigoCentro);
                cmd.Parameters.AddWithValue("@cod_especialidad", atencion.Especialidad.CodigoEspecialidad);
                cmd.Parameters.AddWithValue("@matricula", atencion.Profesional.Matricula);
                cmd.Parameters.AddWithValue("@importe", atencion.Importe);
                cmd.Parameters.AddWithValue("@id_practica", atencion.Practica.CodigoPractica);
                cmd.Parameters.AddWithValue("@id_atencion", idAtencion);

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
