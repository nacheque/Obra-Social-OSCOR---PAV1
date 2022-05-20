using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Negocio
{
    class NE_Cobertura
    {
        public static List<Cobertura> obtenerListadoCobertura()
        {
            try
            {
                List<Cobertura> coberturas = new List<Cobertura>();
                DataTable tabla = AD_Cobertura.ObtenerCobertura();

                foreach (DataRow fila in tabla.Rows)
                {
                    Cobertura cobertura = new Cobertura();
                    TipoAfiliado tipoAfiliado = new TipoAfiliado();
                    tipoAfiliado.CodigoTipoAfiliado = int.Parse(fila[0].ToString());
                    tipoAfiliado.DescripcionTipoAfiliado = fila[1].ToString();
                    cobertura.TipoAfiliado = tipoAfiliado;
                    Practica practica = new Practica();
                    practica.CodigoPractica = int.Parse(fila[2].ToString());
                    practica.DescripcionPractica = fila[3].ToString();
                    practica.PrecioPractica = float.Parse(fila[4].ToString());
                    cobertura.Practica = practica;
                    cobertura.Porcentaje = int.Parse(fila[5].ToString());

                    coberturas.Add(cobertura);
                }

                return coberturas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarCobertura(Cobertura cobertura)
        {
            try
            {
                AD_Cobertura.AgregarCobetura(cobertura);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarCobertura(Cobertura cobertura, int id_tipo, int id_practica)
        {
            try
            {
                AD_Cobertura.ActualizarCobertura(cobertura, id_tipo, id_practica);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarCobertura(int id_tipo, int id_practica)
        {
            try
            {
                AD_Cobertura.EliminarCobertura(id_tipo, id_practica);
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
