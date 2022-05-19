using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obra_social_oscor.Negocio
{
    public class NE_Practica
    {
        public static List<Practica> obtenerListadoPracticas() 
        {
            try
            {
                List<Practica> practicas = new List<Practica>();
                DataTable tabla = AD_Practica.obtenerPracticas(); //me retorna mi tabla con objetos del tipo PRACTICA
                foreach (DataRow fila in tabla.Rows) //voy CARGANDO mi lista con objetos del tipo PRACTICA
                {
                    Practica practica = new Practica();
                    practica.CodigoPractica = int.Parse(fila[0].ToString());
                    practica.DescripcionPractica = fila[1].ToString();
                    practica.PrecioPractica = float.Parse(fila[2].ToString());
                    practicas.Add(practica); 
                   
                }

                return practicas; //me devuelve la lista con todos los objetos del tipo PRACTICA
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public static void agregarPractica(Practica practica)
        {
            try
            {
                AD_Practica.agregarPractica(practica);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void actualizarPractica(Practica practica, int codigoPractica) 
        {
            try
            {
                AD_Practica.actualizarPractica(practica, codigoPractica);
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public static void eliminarPractica(int codigoPractica) 
        {
            try
            {
                AD_Practica.eliminarPractica(codigoPractica);
            }
            catch (SqlException ex)
            {
                if (ex.Errors.Count > 0)
                {
                    switch (ex.Errors[0].Number)
                    {
                        case 547:
                            throw new InvalidOperationException("Foreign Key violation", ex);
                        default:
                            throw ex; 
                    }
                }
            }            
        }
    }
}
