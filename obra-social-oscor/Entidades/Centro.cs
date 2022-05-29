using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Centro
    {
        private int codCentro;
        private string denominacion;
        private string calle;
        private int numero;
        private Barrio barrio;
        private Localidad localidad;
        private string telefono;
        private string mail;
        private string propio;

        public int CodigoCentro
        {
            get => codCentro;
            set => codCentro = value;
        }

        public string Denominacion
        {
            get => denominacion;
            set => denominacion = value;
        }

        public string Calle
        {
            get => calle;
            set => calle = value;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public Barrio Barrio
        {
            get => barrio;
            set => barrio = value;
        }

        public Localidad Localidad
        {
            get => localidad;
            set => localidad = value;
        }

        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }

        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public string Propio
        {
            get => propio;
            set => propio = value;
        }
    }
}
