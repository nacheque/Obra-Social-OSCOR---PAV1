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
        private int idTipoAfiliado;
        private DateTime fechaInscripcion;
        private float montoInscripcion;

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

        public int TipoAfiliadoAfiliado
        {
            get => idTipoAfiliado;
            set => idTipoAfiliado = value;
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
    }
}
