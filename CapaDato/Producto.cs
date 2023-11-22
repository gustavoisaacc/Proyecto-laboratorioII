using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato
{
    public class Producto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public Marca Marca { get; set; }
        public Tipo Tipo { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string Vencimiento { get; set; }

    }

    
}
