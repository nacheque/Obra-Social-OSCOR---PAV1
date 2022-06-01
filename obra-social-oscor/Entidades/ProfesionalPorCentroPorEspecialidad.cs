using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class ProfesionalPorCentroPorEspecialidad
    {
        private Profesional profesional;
        private Centro centro;
        private Especialidad especialidad;

        public Profesional Profesional
        {
            get => profesional;
            set => profesional = value;
        }

        public Centro Centro
        {
            get => centro;
            set => centro = value;
        }

        public Especialidad Especialidad
        {
            get => especialidad;
            set => especialidad = value;
        }
    }
}
