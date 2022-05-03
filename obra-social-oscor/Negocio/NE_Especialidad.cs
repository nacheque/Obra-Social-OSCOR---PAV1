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
    public class NE_Especialidad
    {
        public static List<Especialidad> ObtenerListadoEspecialidades()
        {
            try
            {
                List<Especialidad> especialidades = new List<Especialidad>();
                DataTable tabla = AD_Especialidad.ObtenerEspecialidades();
                foreach (DataRow fila in tabla.Rows)
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.CodigoEspecialidad = int.Parse(fila[0].ToString());
                    especialidad.NombreEspecialidad = fila[1].ToString();
                    especialidades.Add(especialidad);
                }

                return especialidades;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
