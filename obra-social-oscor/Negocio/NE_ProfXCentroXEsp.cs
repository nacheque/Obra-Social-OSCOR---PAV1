using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using obra_social_oscor.Entidades;
using obra_social_oscor.AccesoADatos;
using System.Data;

namespace obra_social_oscor.Negocio
{
    class NE_ProfXCentroXEsp
    {
        public static void ArgegarProfesionalACentroConEspecialidad(ProfesionalPorCentroPorEspecialidad pce)
        {
            try
            {
                AD_ProfXCentroXEsp.AsignarProfesionalCentroEsp(pce);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ProfesionalPorCentroPorEspecialidad> ObtenerListaDeProfXEspDeCentro(Centro centro)
        {
            List<ProfesionalPorCentroPorEspecialidad> pces = new List<ProfesionalPorCentroPorEspecialidad>();
            DataTable tabla = AD_ProfXCentroXEsp.ObtenerProfXEsp(centro.CodigoCentro);

            foreach (DataRow fila in tabla.Rows)
            {
                Especialidad esp = new Especialidad();
                esp.CodigoEspecialidad = int.Parse(fila[0].ToString());
                esp.NombreEspecialidad = fila[1].ToString();

                Profesional prof = new Profesional();
                prof.Matricula = int.Parse(fila[2].ToString());
                prof.NombreCompleto = fila[3].ToString();

                ProfesionalPorCentroPorEspecialidad pce = new ProfesionalPorCentroPorEspecialidad();
                pce.Centro = centro;
                pce.Especialidad = esp;
                pce.Profesional = prof;

                pces.Add(pce);
            }

            return pces;


        }
    }
}
