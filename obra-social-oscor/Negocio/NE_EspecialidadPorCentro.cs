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
    class NE_EspecialidadPorCentro
    {
        public static List<EspecialidadPorCentro> ObtenerListadoEspecialidadesPorCentros(int codCentro)
        {
            try
            {
                List<EspecialidadPorCentro> especialidadesPorCentro = new List<EspecialidadPorCentro>();
                DataTable tabla = AD_EspecialidadPorCentro.ObtenerEspecialidadesPorCentro(codCentro);
                foreach (DataRow fila in tabla.Rows)
                {
                    EspecialidadPorCentro especialidadPorCentro = new EspecialidadPorCentro();

                    Especialidad especialidad = new Especialidad();
                    especialidad.CodigoEspecialidad = int.Parse(fila[0].ToString());
                    especialidad.NombreEspecialidad = fila[1].ToString();

                    especialidadPorCentro.Especialidad = especialidad;

                    especialidadesPorCentro.Add(especialidadPorCentro);

                }

                return especialidadesPorCentro;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
