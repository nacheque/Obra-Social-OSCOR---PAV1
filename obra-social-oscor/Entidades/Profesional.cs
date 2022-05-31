using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Profesional
    {
        private int matricula;
        private string apellido;
        private string nombre;
        private string calle;
        private int numeroCalle;
        private Barrio barrio;
        private Localidad localidad;
        private string telefono;
        private string nombreCompleto;

        public int Matricula
        {
            get => matricula;
            set => matricula = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Calle
        {
            get => calle;
            set => calle = value;
        }

        public int NumeroCalle
        {
            get => numeroCalle;
            set => numeroCalle = value;
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

        public string NombreCompleto
        {
            get => nombreCompleto;
            set => nombreCompleto = value;
        }

    }
}
