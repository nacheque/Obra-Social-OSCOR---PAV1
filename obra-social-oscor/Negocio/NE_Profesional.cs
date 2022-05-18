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
    class NE_Profesional
    {
        public static List<Profesional> obtenerListadoProfesionales()
        {
            try
            {
                List<Profesional> profesionales = new List<Profesional>();
                DataTable tabla = AD_Profesional.ObtenerProfesionales();

                foreach (DataRow fila in tabla.Rows)
                {
                    Profesional profesional = new Profesional();
                    profesional.Matricula = int.Parse(fila[0].ToString());
                    profesional.Apellido = fila[1].ToString();
                    profesional.Nombre = fila[2].ToString();
                    profesional.Calle = fila[3].ToString();
                    profesional.NumeroCalle = int.Parse(fila[4].ToString());
                    profesional.Telefono = fila[9].ToString();

                    Barrio barrio = new Barrio();
                    barrio.IdBarrio = int.Parse(fila[5].ToString());
                    barrio.NombreBarrio = fila[6].ToString();

                    Localidad localidad = new Localidad();
                    localidad.IdLocalidad = int.Parse(fila[7].ToString());
                    localidad.NombreLocalidad = fila[8].ToString();

                    profesional.Barrio = barrio;
                    profesional.Localidad = localidad;

                    profesionales.Add(profesional);
                }

                return profesionales;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarProfesional(Profesional profesional)
        {
            try
            {
                AD_Profesional.AgregarProfesional(profesional);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarProfesional(int matricula)
        {
            try
            {
                AD_Profesional.EliminarProfesional(matricula);
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
