using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    public class Especialidad
    {
        private int codEspecialidad;
        private string nombre;

        //public Especialidad(string nombre)
        //{
        //    this.nombre = nombre;
        //}

        //public Especialidad()
        //{

        //}

        public string NombreEspecialidad
        {
            get => nombre;
            set => nombre = value;
        }

        public int CodigoEspecialidad
        {
            get => codEspecialidad;
            set => codEspecialidad = value;
        }
    }
}
