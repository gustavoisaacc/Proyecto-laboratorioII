using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ConectarDB
    {

        private const string Servidor = "DESKTOP-VF5FCOM\\SQLEXPRESS";
        private const string BaseDatos = "DISTRIBUIDORA";
        private const string Usuario = "sa";
        private const string Password = "2846Sofia";

        public static string cadenaConexion => $"Data Source={Servidor}; " +
                                               $"Initial Catalog={BaseDatos}; " +
                                               $"User={Usuario}; Password={Password}";

    }
}
