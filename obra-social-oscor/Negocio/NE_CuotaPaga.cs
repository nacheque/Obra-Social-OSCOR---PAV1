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
    class NE_CuotaPaga
    {
        public static List<CuotaPaga> obtenerListadoCuotasPagas()
        {
            try
            {
                List<CuotaPaga> cuotasPagas = new List<CuotaPaga>();
                DataTable tabla = AD_CuotaPaga.ObtenerCuotasPagas();

                foreach (DataRow fila in tabla.Rows)
                {
                    CuotaPaga cuotaPaga = new CuotaPaga();

                    Afiliado afiliado = new Afiliado();
                    afiliado.NumeroAfiliado = int.Parse(fila[0].ToString());
                    afiliado.NombreCompleto = fila[1].ToString();

                    cuotaPaga.Afiliado = afiliado;
                    cuotaPaga.NumeroCuota = int.Parse(fila[2].ToString());
                    cuotaPaga.AnioCuota = int.Parse(fila[3].ToString());
                    cuotaPaga.FechaPago = DateTime.Parse(fila[4].ToString());
                    cuotaPaga.MontoEmergencia = float.Parse(fila[5].ToString());
                    cuotaPaga.TotalPago = float.Parse(fila[6].ToString());

                    cuotasPagas.Add(cuotaPaga);
                }

                return cuotasPagas;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarCuotaPaga(CuotaPaga cuotaPaga)
        {
            try
            {
                AD_CuotaPaga.AgregarCuotaPaga(cuotaPaga);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EliminarCuotaPaga(int numeroAfiliado, int nroCuota, int anio)
        {
            try
            {
                AD_CuotaPaga.EliminarCuotaPaga(numeroAfiliado, nroCuota, anio);
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