using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Cobertura
    {
        private TipoAfiliado tipoAfiliado;
        private Practica practica;
        private int porcentaje;

        public Cobertura()
        {
        }

        public int Porcentaje
        {
            get => porcentaje;
            set => porcentaje = value;
        }
        internal TipoAfiliado TipoAfiliado
        {
            get => tipoAfiliado;
            set => tipoAfiliado = value;
        }
        internal Practica Practica
        {
            get => practica;
            set => practica = value;
        }
    }
}
