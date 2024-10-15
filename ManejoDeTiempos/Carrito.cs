using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeTiempos
{
    public class Carrito
    {
        public double total;
        public double subtotal;

        public List<(Producto, int)> productos = new List<(Producto, int)>();
        public Carrito()
        {
            total = 0;
            subtotal = 0;
        }
        public void Agregar(Producto producto, int cantidad)
        {
            productos.Add((producto, cantidad));
        }

        public double Cobrar(Tiempo tiempo){
            foreach (var producto in productos){
                subtotal += producto.Item1.precioUnitario * producto.Item2;
            }
            /*double descuento = (tiempo.Now().DayOfWeek == DayOfWeek.Sunday || tiempo.Now().DayOfWeek == DayOfWeek.Saturday) ? 0.85 : 1;*/
            if (tiempo.Now().DayOfWeek == DayOfWeek.Sunday || tiempo.Now().DayOfWeek == DayOfWeek.Saturday)
            {
                total = subtotal * 0.85;
            }
            else
            {
                total = subtotal;
            }
            
            return total;
        }

        public double GetSubTotal()
        {
            return subtotal;
        }
    }
}
