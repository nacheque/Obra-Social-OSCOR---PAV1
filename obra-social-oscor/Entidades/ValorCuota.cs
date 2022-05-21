using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class ValorCuota
    {
        private TipoAfiliado tipoAfiliado;
        private int edadDesde;
        private int edadHasta;
        private float monto;

        public TipoAfiliado TipoAfiliado
        {
            get => tipoAfiliado;
            set => tipoAfiliado = value;
        }

        public int EdadDesde
        {
            get => edadDesde;
            set => edadDesde = value;
        }

        public int EdadHasta
        {
            get => edadHasta;
            set => edadHasta = value;
        }

        public float Monto
        {
            get => monto;
            set => monto = value;
        }
    }
}
