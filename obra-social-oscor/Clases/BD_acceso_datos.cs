using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace obra_social_oscor.Clases
{
    class BD_acceso_datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string cadena_conexion = "Data Source=DESKTOP-ND2MTO9;Initial Catalog=obraSocialOscar;Integrated Security=True";

        private void Conectar()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void Desconectar()
        {
            conexion.Close();
        }
        public DataTable EjecutarSQL(string comando)
        {
            Conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }
}
