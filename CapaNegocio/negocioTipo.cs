using CapaDato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class negocioTipo
    {
        public List<Tipo> Listar()
        {
            List<Tipo> listaTipos = new List<Tipo>();
            AccesoDato accesoDato = new AccesoDato();

            try
            {
                accesoDato.setearConsulta("SELECT id, nombre FROM TIPOS");
                accesoDato.ejecutarLectura();
                while (accesoDato.Lectura.Read())
                {
                    Tipo item = new Tipo();
                    item.Id = (int)accesoDato.Lectura["id"];
                    item.Nombre = (string)accesoDato.Lectura["Nombre"];


                    listaTipos.Add(item);


                }
                return listaTipos;
            }
            catch (Exception Error)
            {

                throw Error;
            }
            finally { accesoDato.cerrarConexion(); }
        }
    }
}
