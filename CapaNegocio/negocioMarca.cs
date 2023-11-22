using CapaDato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class negocioMarca
    {

        public List<Marca> Listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            AccesoDato accesoDato = new AccesoDato();

            try
            {
                accesoDato.setearConsulta("SELECT id, nombre FROM MarcaS");
                accesoDato.ejecutarLectura();
                while (accesoDato.Lectura.Read())
                {
                    Marca item = new Marca();
                    item.Id = (int)accesoDato.Lectura["id"];
                    item.Nombre = (string)accesoDato.Lectura["Nombre"];


                    listaMarcas.Add(item);


                }
                return listaMarcas;
            }
            catch (Exception Error)
            {

                throw Error;
            }
            finally { accesoDato.cerrarConexion(); }
        }
    }
}
