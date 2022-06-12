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

        public static void AgregarEspecialidadPorCentro(EspecialidadPorCentro especialidadPorCentro)
        {
            try
            {
                AD_EspecialidadPorCentro.AgregarEspecialidadPorCentro(especialidadPorCentro);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void EliminarEspecialidadPorCentro(int codEspecialidad, int codCentro)
        {
            try
            {
                AD_EspecialidadPorCentro.EliminarEspecialidadPorCentro(codEspecialidad, codCentro);
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
