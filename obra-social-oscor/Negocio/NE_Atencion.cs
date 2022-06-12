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
    class NE_Atencion
    {
        public static List<Atencion> obtenerListadoAtenciones()
        {
            try
            {
                List<Atencion> atenciones = new List<Atencion>();
                DataTable tabla = AD_Atencion.ObtenerAtenciones();

                foreach (DataRow fila in tabla.Rows)
                {
                    Atencion atencion = new Atencion();

                    atencion.IdAtencion = int.Parse(fila[0].ToString());

                    Afiliado afiliado = new Afiliado();
                    afiliado.NumeroAfiliado = int.Parse(fila[1].ToString());
                    afiliado.NombreCompleto = fila[2].ToString();

                    atencion.Afiliado = afiliado;
                    atencion.FechaHoraAtencion = DateTime.Parse(fila[3].ToString());

                    Centro centro = new Centro();
                    centro.CodigoCentro = int.Parse(fila[4].ToString());
                    centro.Denominacion = fila[5].ToString();

                    atencion.Centro = centro;

                    Especialidad especialidad = new Especialidad();
                    especialidad.CodigoEspecialidad = int.Parse(fila[6].ToString());
                    especialidad.NombreEspecialidad = fila[7].ToString();

                    atencion.Especialidad = especialidad;

                    Profesional profesional = new Profesional();
                    profesional.Matricula = int.Parse(fila[8].ToString());
                    profesional.NombreCompleto = fila[9].ToString();

                    atencion.Profesional = profesional;
                    atencion.Importe = float.Parse(fila[10].ToString());

                    Practica practica = new Practica();
                    practica.CodigoPractica = int.Parse(fila[11].ToString());
                    practica.DescripcionPractica = fila[12].ToString();

                    atencion.Practica = practica;
                                                                          
                    atenciones.Add(atencion);
                }

                return atenciones;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void AgregarAtencion(Atencion atencion)
        {
            try
            {
                AD_Atencion.AgregarAtencion(atencion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EditarAtencion(Atencion atencion, int idAtencion)
        {
            try
            {
                AD_Atencion.EditarAtencion(atencion, idAtencion);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
