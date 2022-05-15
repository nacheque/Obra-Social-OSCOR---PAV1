using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Localidad
    {
        private int idLocalidad;
        private string nombreLocalidad;

        public int IdLocalidad
        {
            get => idLocalidad;
            set => idLocalidad = value;
        }

        public string NombreLocalidad
        {
            get => nombreLocalidad;
            set => nombreLocalidad = value;
        }
    }
}
