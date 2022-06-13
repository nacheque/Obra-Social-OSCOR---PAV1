using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Helpers
{
    class Fechas
    {   //este metodo recibe una fecha en formato dd/mm/yyyy y devuelve un string en formato yyyymmdd
        public static string ConvertirFechaEnStringParaQuery(string paramFecha)
        {
            string [] paramFechaSplit = paramFecha.Split('/');
            string fecha = paramFechaSplit[2] + paramFechaSplit[1] + paramFechaSplit[0];

            return fecha;
        }

    }
}
