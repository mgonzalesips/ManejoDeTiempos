using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeTiempos
{
    public class Producto
    {
        public string nombre;
        public double precioUnitario;
        
        public Producto(string nombre, double precioUnitario)
        {
            this.nombre = nombre;
            this.precioUnitario = precioUnitario;
        }
    }
}
