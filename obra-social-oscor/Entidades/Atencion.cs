using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Atencion
    {
        private Afiliado afiliado;
        private DateTime fechaHoraAtencion;
        private Centro centro;
        private Especialidad especialidad;
        private Profesional profesional;
        private float importe;
        private Practica practica;

        public Afiliado Afiliado
        {
            get => afiliado;
            set => afiliado = value;
        }

        public DateTime FechaHoraAtencion
        {
            get => fechaHoraAtencion;
            set => fechaHoraAtencion = value;
        }

        public Centro Centro
        {
            get => centro;
            set => centro = value;
        }

        public Especialidad Especialidad
        {
            get => especialidad;
            set => especialidad = value;
        }

        public Profesional Profesional
        {
            get => profesional;
            set => profesional = value;
        }

        public float Importe
        {
            get => importe;
            set => importe = value;
        }

        public Practica Practica
        {
            get => practica;
            set => practica = value;
        }
    }
}
