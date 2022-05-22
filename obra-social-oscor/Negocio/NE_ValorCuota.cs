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
    class NE_ValorCuota
    {
        public static List<ValorCuota> ObtenerTablaValorCuota()
        {
            try
            {
                List<ValorCuota> valoresCuotas = new List<ValorCuota>();
                DataTable tabla = AD_ValorCuota.ObtenerValoresDeCoutas();

                foreach (DataRow fila in tabla.Rows)
                { 
                    TipoAfiliado tipoAfiliado = new TipoAfiliado();
                    tipoAfiliado.CodigoTipoAfiliado = int.Parse(fila[0].ToString());
                    tipoAfiliado.DescripcionTipoAfiliado = fila[4].ToString();

                    ValorCuota valorCuota = new ValorCuota();
                    valorCuota.TipoAfiliado = tipoAfiliado;
                    valorCuota.EdadDesde = int.Parse(fila[1].ToString());
                    valorCuota.EdadHasta = int.Parse(fila[2].ToString());
                    valorCuota.Monto = float.Parse(fila[3].ToString());

                    valoresCuotas.Add(valorCuota);
                }

                return valoresCuotas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AgregarVC(ValorCuota valorCuota)
        {
            try
            {
                AD_ValorCuota.AgregarVC(valorCuota);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ActualizarVC(ValorCuota valorCuota, int idTipoAfiliado, int edadDesde)
        {
            try
            {
                AD_ValorCuota.ActualizarVC(valorCuota, idTipoAfiliado, edadDesde);
            }
            catch (SqlException ex)
            {
                if (ex.Errors.Count > 0)
                {
                    switch (ex.Errors[0].Number)
                    {
                        case 547:
                            throw new InvalidOperationException("Foreign key violation", ex);
                        default:
                            throw ex;
                    }
                }
            }
        }

        public static void EliminarVC(int idTipoAfiliado, int edadDesde)
        {
            try
            {
                AD_ValorCuota.EliminarVC(idTipoAfiliado, edadDesde);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
