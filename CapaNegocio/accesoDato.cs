using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class AccesoDato
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader leer;
        public SqlDataReader Lectura { get { return leer; } }
        public AccesoDato()
        {
            conexion = new SqlConnection(ConectarDB.cadenaConexion);
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                leer = comando.ExecuteReader();
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        public void ejecutarEscritura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }
    }
}
