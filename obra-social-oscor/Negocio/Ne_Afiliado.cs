using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace obra_social_oscor.Negocio
{
    class Ne_Afiliado
    {        
        public static List<Afiliado> obtenerListadoAfiliado()
        {
            try
            {
                List<Afiliado> afiliados = new List<Afiliado>();
                DataTable tabla = AD_Afiliado.ObtenerAfiliado();
                
                foreach (DataRow fila in tabla.Rows)
                {
                    Afiliado afiliado = new Afiliado();
                    afiliado.NumeroAfiliado = int.Parse(fila[0].ToString());
                    afiliado.ApellidoAfiliado = fila[1].ToString();
                    afiliado.NombreAfiliado = fila[2].ToString();
                    afiliado.FechaNacimientoAfiliado = DateTime.Parse(fila[3].ToString());
                    afiliado.FechaInscripcionAfiliado = DateTime.Parse(fila[4].ToString());
                    afiliado.MontoInscripcionAfiliado = float.Parse(fila[5].ToString());

                    TipoAfiliado tipoAfiliado = new TipoAfiliado();
                    tipoAfiliado.CodigoTipoAfiliado = int.Parse(fila[6].ToString());
                    tipoAfiliado.DescripcionTipoAfiliado = fila[7].ToString();

                    afiliado.TipoAfiliado = tipoAfiliado;
                    
                    afiliados.Add(afiliado);                    
                }

                return afiliados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static List<Afiliado> obtenerAfiliadoPorNumero(int numeroAfiliado)
        {
            try
            {
                List<Afiliado> afiliados = new List<Afiliado>();
                DataTable tabla = AD_Afiliado.ObtenerAfiliadoPorNroAfiliado(numeroAfiliado);

                foreach (DataRow fila in tabla.Rows)
                {
                    Afiliado afiliado = new Afiliado();
                    afiliado.NumeroAfiliado = int.Parse(fila[0].ToString());
                    afiliado.ApellidoAfiliado = fila[1].ToString();
                    afiliado.NombreAfiliado = fila[2].ToString();
                    afiliado.FechaNacimientoAfiliado = DateTime.Parse(fila[3].ToString());
                    afiliado.FechaInscripcionAfiliado = DateTime.Parse(fila[5].ToString());
                    afiliado.MontoInscripcionAfiliado = float.Parse(fila[6].ToString());

                    TipoAfiliado tipoAfiliado = new TipoAfiliado();
                    tipoAfiliado.CodigoTipoAfiliado = int.Parse(fila[4].ToString());                    

                    afiliado.TipoAfiliado = tipoAfiliado;

                    afiliados.Add(afiliado);
                }

                return afiliados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarAfiliado(Afiliado afiliado)
        {
            try
            {
                AD_Afiliado.AgregarAfiliado(afiliado);                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Afiliado> ObtenerAfiliadosReporte()
        {
            try
            {
                List<Afiliado> afiliados = new List<Afiliado>();
                DataTable tabla = AD_Afiliado.ObtenerAfiliadosReporte();

                foreach (DataRow fila in tabla.Rows)
                {
                    Afiliado afiliado = new Afiliado();
                    afiliado.NumeroAfiliado = int.Parse(fila[0].ToString());
                    afiliado.NombreCompleto = fila[0].ToString();

                    afiliados.Add(afiliado);
                }

                return afiliados;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void ActualizarAfiliado(Afiliado afiliado, int codigoAfiliado)
        {
            try
            {
                AD_Afiliado.ActualizarAfiliado(afiliado, codigoAfiliado);                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarAfiliado(int codigoAfiliado)
        {
            try
            {
                AD_Afiliado.EliminarAfiliado(codigoAfiliado);                
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
