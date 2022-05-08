using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class TipoAfiliado
    {
        private int codTipo;
        private string descripcion;

        public TipoAfiliado(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public TipoAfiliado()
        {

        }

        public string DescripcionTipoAfiliado
        {
            get => descripcion;
            set => descripcion = value;
        }

        public int CodigoTipoAfiliado
        {
            get => codTipo;
            set => codTipo = value;
        }
    }
}
