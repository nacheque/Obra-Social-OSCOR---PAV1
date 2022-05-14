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
    class NE_Barrio
    {
        public static List<Barrio> ObtenerListadoBarrios()
        {
            try
            {
                List<Barrio> barrios = new List<Barrio>();
                DataTable tabla = AD_Barrio.ObtenerBarrios();
                foreach (DataRow fila in tabla.Rows)
                {
                    Barrio barrio = new Barrio();
                    barrio.IdBarrio = int.Parse(fila[0].ToString());
                    barrio.NombreBarrio = fila[1].ToString();
                    barrios.Add(barrio);
                }

                return barrios;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void AgregarBarrio(Barrio barrio)
        {
            try
            {
                AD_Barrio.AgregarBarrio(barrio);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EliminarBarrio(int idBarrio)
        {
            try
            {
                AD_Barrio.EliminarBarrio(idBarrio);
            }
            catch (SqlException ex)
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
