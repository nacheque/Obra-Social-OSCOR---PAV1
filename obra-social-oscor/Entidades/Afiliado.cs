using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Entidades
{
    class Afiliado
    {
        private int numeroAfiliado;
        private string apellido;
        private string nombre;
        private DateTime fecha_nacimiento;
        private TipoAfiliado tipoAfiliado;
        private DateTime fechaInscripcion;
        private float montoInscripcion;
        private string nombreCompleto;

        public Afiliado() { }

        public int NumeroAfiliado
        {
            get => numeroAfiliado;
            set => numeroAfiliado = value;
        }

        public string ApellidoAfiliado
        {
            get => apellido;
            set => apellido = value;
        }

        public string NombreAfiliado
        {
            get => nombre;
            set => nombre = value;
        }

        public DateTime FechaNacimientoAfiliado
        {
            get => fecha_nacimiento;
            set => fecha_nacimiento = value;
        }

        public TipoAfiliado TipoAfiliado
        {
            get => tipoAfiliado;
            set => tipoAfiliado = value;
        }

        public DateTime FechaInscripcionAfiliado
        {
            get => fechaInscripcion;
            set => fechaInscripcion = value;
        }
        
        public float MontoInscripcionAfiliado
        {
            get => montoInscripcion;
            set => montoInscripcion = value;
        }

        public string NombreCompleto
        {
            get => nombreCompleto;
            set => nombreCompleto = value;
        }
    }
}
