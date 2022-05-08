using obra_social_oscor.Helpers;
using obra_social_oscor.Entidades;
using obra_social_oscor.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace obra_social_oscor.Negocio
{
    class Ne_TipoAfiliado
    {
        public static List<TipoAfiliado> ObtenerListadoTipoAfiliado()
        {
            try
            {
                List<TipoAfiliado> tipoAfiliados = new List<TipoAfiliado>();
                DataTable tabla = AD_TipoAfiliado.ObtenerTipoAfiliado();
                foreach (DataRow fila in tabla.Rows)
                {
                    TipoAfiliado tiposAfiliado = new TipoAfiliado();
                    tiposAfiliado.CodigoTipoAfiliado = int.Parse(fila[0].ToString());
                    tiposAfiliado.DescripcionTipoAfiliado = fila[1].ToString();
                    tipoAfiliados.Add(tiposAfiliado);
                }

                return tipoAfiliados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarTipoAfiliado(TipoAfiliado tipoAfiliado)
        {
            try
            {
                AD_TipoAfiliado.AgregarTipoAfiliado(tipoAfiliado);                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarTipoAfiliado(TipoAfiliado tipoAfiliado, int codigoTipo)
        {
            try
            {
                AD_TipoAfiliado.ActualizarTipoAfiliado(tipoAfiliado,codigoTipo);                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarTipoAfiliado(int codigoTipo)
        {
            try
            {
                AD_TipoAfiliado.EliminarTipoAfiliado(codigoTipo);                
            }
            catch (SqlException ex)
            {
                if (ex.Errors.Count > 0)
                {
                    switch (ex.Errors[0].Number)
                    {
                        case 547:
                            throw new InvalidOperationException("Foreign Key violation", ex);
                        default:
                            throw ex;
                    }
                }

            }
        }
    }
}
