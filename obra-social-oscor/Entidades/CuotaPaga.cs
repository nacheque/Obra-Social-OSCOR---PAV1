using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class CuotaPaga
    {
        private Afiliado afiliado;
        private int numeroCuota;
        private int anioCuota;
        private DateTime fechaPago;
        private float montoEmergencia;
        private float totalPago;

        public Afiliado Afiliado
        {
            get => afiliado;
            set => afiliado = value;
        }

        public int NumeroCuota
        {
            get => numeroCuota;
            set => numeroCuota = value;
        }

        public int AnioCuota
        {
            get => anioCuota;
            set => anioCuota = value;
        }

        public DateTime FechaPago
        {
            get => fechaPago;
            set => fechaPago = value;
        }

        public float MontoEmergencia
        {
            get => montoEmergencia;
            set => montoEmergencia = value;
        }

        public float TotalPago
        {
            get => totalPago;
            set => totalPago = value;
        }
    }
}
