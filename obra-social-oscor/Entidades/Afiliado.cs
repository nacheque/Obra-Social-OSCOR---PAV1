using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Afiliado
    {
        private int numero_Afiliado;
        private string apellido_afiliado;
        private string nombre_afiliado;
        private DateTime fecha_nacimiento_afiliado;
        private int tipoafiliado_afiliado;
        private DateTime fecha_inscripcion_afiliado;
        private float monto_inscripcion_afiliado;

        public Afiliado(string apellido_afiliado, string nombre_afiliado, DateTime fecha_nacimiento_afiliado, int tipoafiliado_afiliado, DateTime fecha_inscripcion_afiliado, float monto_inscripcion_afiliado)
        {
            this.apellido_afiliado = apellido_afiliado;
            this.nombre_afiliado = nombre_afiliado;
            this.fecha_nacimiento_afiliado = fecha_nacimiento_afiliado;
            this.tipoafiliado_afiliado = tipoafiliado_afiliado;
            this.fecha_inscripcion_afiliado = fecha_inscripcion_afiliado;
            this.monto_inscripcion_afiliado = monto_inscripcion_afiliado;
        }

        public Afiliado() { }

        public int NumeroAfiliado
        {
            get => numero_Afiliado;
            set => numero_Afiliado = value;
        }

        public string ApellidoAfiliado
        {
            get => apellido_afiliado;
            set => apellido_afiliado = value;
        }

        public string NombreAfiliado
        {
            get => nombre_afiliado;
            set => nombre_afiliado = value;
        }

        public DateTime FechaNacimientoAfiliado
        {
            get => fecha_nacimiento_afiliado;
            set => fecha_nacimiento_afiliado = value;
        }

        public int TipoAfiliadoAfiliado
        {
            get => tipoafiliado_afiliado;
            set => tipoafiliado_afiliado = value;
        }

        public DateTime FechaInscripcionAfiliado
        {
            get => fecha_inscripcion_afiliado;
            set => fecha_inscripcion_afiliado = value;
        }
        
        public float MontoInscripcionAfiliado
        {
            get => monto_inscripcion_afiliado;
            set => monto_inscripcion_afiliado = value;
        }
    }
}
