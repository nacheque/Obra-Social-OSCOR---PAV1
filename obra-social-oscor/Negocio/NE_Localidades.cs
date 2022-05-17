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
    class NE_Localidades
    {
        public static List<Localidad> ObtenerListadoLocalidades()
        {
            try
            {
                List<Localidad> localidades = new List<Localidad>();
                DataTable tabla = AD_Localidad.ObtenerLocalidades();
                foreach ( DataRow fila in tabla.Rows )
                {
                    Localidad localidad = new Localidad();
                    localidad.IdLocalidad = int.Parse(fila[0].ToString());
                    localidad.NombreLocalidad = fila[1].ToString();
                    localidades.Add(localidad);
                }

                return localidades;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AgregarLocalidad(Localidad localidad)
        {
            try
            {
                AD_Localidad.AgregarLocalidad(localidad);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EditarLocalidad(Localidad localidad, int codigoLoc)
        {
            try
            {
                AD_Localidad.EditarLocalidad(localidad, codigoLoc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EliminarLocalidad(int codigoLoc)
        {
            try
            {
                AD_Localidad.EliminarLocalidad(codigoLoc);
            }
            catch(SqlException ex)
            {

                if (ex.Errors.Count > 0)
                {
                    switch (ex.Errors[0].Number)
                    {
                        case 547:
                            throw new InvalidOperationException("Foreign Key Violation", ex);
                        default:
                            throw ex;
                    }
                }
            }
        }
    }
}
