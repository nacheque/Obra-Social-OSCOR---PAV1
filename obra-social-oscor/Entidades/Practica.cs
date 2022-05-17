using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Practica
    {
        private int codigoPractica;
        private string descripcion;
        private float precio; //Modificar tipo de dato una vez verificada la funcionalidad


        public Practica(string descripcionPractica, float precioPractica)
        {
            this.descripcion = descripcionPractica;
            this.precio = precioPractica;
        }

        public Practica()
        {

        }

        public int CodigoPractica
        {
            get => codigoPractica;
            set => codigoPractica = value;
        }
        public string DescripcionPractica
        {
            get => descripcion;
            set => descripcion = value;
        }

        public float PrecioPractica
        {
            get => precio;
            set => precio = value;
        }
    }

}

