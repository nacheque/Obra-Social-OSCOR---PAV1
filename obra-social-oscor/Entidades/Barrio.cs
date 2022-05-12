using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    public class Barrio
    {
        private int idBarrio;
        private string barrio;

        public int IdBarrio
        {
            get => idBarrio;
            set => idBarrio = value;
        }

        public string NombreBarrio
        {
            get => barrio;
            set => barrio = value;
        }
    }
}
