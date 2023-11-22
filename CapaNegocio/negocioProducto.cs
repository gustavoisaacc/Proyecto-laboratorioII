using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();
            AccesoDato accesoDato = new AccesoDato();

            try
            {
                accesoDato.setearConsulta("SELECT precio, vencimiento, cantidad, codigo, M.nombre Marca, T.nombre [Tipo Producto] FROM PRODUCTOS inner join MARCAS M on PRODUCTOS.idMarca  = M.id inner join TIPOS T on PRODUCTOS.idTipo  = T.id");
                accesoDato.ejecutarLectura();

                while (accesoDato.Lectura.Read())
                {
                    Producto item = new Producto();
                    item.Marca = new Marca();
                    item.Marca.Nombre = (string)accesoDato.Lectura["Marca"];
                    item.Tipo = new Tipo();
                    item.Tipo.Nombre = (string)accesoDato.Lectura["Tipo Producto"];
                    item.Codigo = (int)accesoDato.Lectura["codigo"];
                    item.Precio = (double)accesoDato.Lectura["precio"];
                    item.Cantidad = (int)accesoDato.Lectura["cantidad"];
                    item.Vencimiento = (string)accesoDato.Lectura["vencimiento"];
                    productos.Add(item);


                }
            }
            catch (Exception Error)
            {

                throw Error;
            }
            finally { accesoDato.cerrarConexion(); }
            return productos;
        }

        public void cargarProducto(Producto nuevoProducto)
        {
            AccesoDato dato = new AccesoDato();
            try
            {
                dato.setearConsulta("INSERT INTO PRODUCTOS(cantidad, precio, vencimiento, codigo, idMarca, idTipo) VALUES ( "+nuevoProducto.Cantidad+" , "+nuevoProducto.Precio+", '"+nuevoProducto.Vencimiento+"', "+nuevoProducto.Codigo+", "+nuevoProducto.Marca.Id+", "+nuevoProducto.Tipo.Id+")");
                dato.ejecutarEscritura();
                

            }
            catch (Exception Error)
            {

                throw Error;
            }finally { dato.cerrarConexion(); };
        } 

    }
}
