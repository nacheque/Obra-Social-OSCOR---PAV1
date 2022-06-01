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

                    Afiliado afiliado = new Afiliado();
                    afiliado.NumeroAfiliado = int.Parse(fila[0].ToString());
                    afiliado.NombreCompleto = fila[1].ToString();

                    atencion.Afiliado = afiliado;
                    atencion.FechaHoraAtencion = DateTime.Parse(fila[2].ToString());

                    Centro centro = new Centro();
                    centro.CodigoCentro = int.Parse(fila[3].ToString());
                    centro.Denominacion = fila[4].ToString();

                    atencion.Centro = centro;

                    Especialidad especialidad = new Especialidad();
                    especialidad.CodigoEspecialidad = int.Parse(fila[5].ToString());
                    especialidad.NombreEspecialidad = fila[6].ToString();

                    atencion.Especialidad = especialidad;

                    Profesional profesional = new Profesional();
                    profesional.Matricula = int.Parse(fila[7].ToString());
                    profesional.NombreCompleto = fila[8].ToString();

                    atencion.Profesional = profesional;
                    atencion.Importe = float.Parse(fila[9].ToString());

                    Practica practica = new Practica();
                    practica.CodigoPractica = int.Parse(fila[10].ToString());
                    practica.DescripcionPractica = fila[11].ToString();

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

        public static void EditarAtencion(Atencion atencion, int nroAfiliado, string fechaHora)
        {
            try
            {
                AD_Atencion.EditarAtencion(atencion, nroAfiliado, fechaHora);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
