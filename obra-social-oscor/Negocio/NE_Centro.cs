using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Negocio
{
    class NE_Centro
    {
        public static List<Centro> obtenerListadoCentros()
        {
            try
            {
                List<Centro> centros = new List<Centro>();
                DataTable tabla = AD_Centro.ObtenerCentros();

                foreach (DataRow fila in tabla.Rows)
                {
                    Centro centro = new Centro();
                    centro.CodigoCentro = int.Parse(fila[0].ToString());
                    centro.Denominacion = fila[1].ToString();
                    centro.Calle = fila[2].ToString();
                    centro.Numero = int.Parse(fila[3].ToString());
                   
                    Barrio barrio = new Barrio();
                    barrio.IdBarrio = int.Parse(fila[4].ToString());
                    barrio.NombreBarrio = fila[5].ToString();

                    centro.Barrio = barrio;

                    Localidad localidad = new Localidad();
                    localidad.IdLocalidad = int.Parse(fila[6].ToString());
                    localidad.NombreLocalidad = fila[7].ToString();

                    centro.Localidad = localidad;

                    centro.Telefono = fila[8].ToString();
                    centro.Mail = fila[9].ToString();
                    centro.Propio = fila[10].ToString();

                    centros.Add(centro);
                }

                return centros;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarCentro(Centro centro, List<EspecialidadPorCentro> especialidadesPorCentro)
        {
            try
            {
                AD_Centro.AgregarCentro(centro, especialidadesPorCentro);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
