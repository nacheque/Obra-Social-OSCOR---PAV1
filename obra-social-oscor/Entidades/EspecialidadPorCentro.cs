using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class EspecialidadPorCentro
    {
        private Centro centro;
        private Especialidad especialidad;

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
