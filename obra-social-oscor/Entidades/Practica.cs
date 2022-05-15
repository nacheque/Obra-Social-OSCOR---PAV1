using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    public class Practica
    {
        private string descripcion;
        private string precio; //Modificar tipo de dato una vez verificada la funcionalidad


        public Practica(string descripcionPractica, string precioPractica)
        {
            this.descripcion = descripcionPractica;
            this.precio = precioPractica;
        }

        public string DescripcionPractica
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string PrecioPractica
        {
            get => precio;
            set => precio = value;
        }
    }
    
}
