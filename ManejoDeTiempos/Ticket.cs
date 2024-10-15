using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeTiempos
{
    public class Ticket
    {
        public List<(Producto, int)> productos = new List<(Producto, int)>();
        public DateTime fecha;
        double importe;

        public Ticket(List<(Producto, int)> productos, Tiempo tiempo, double importe)
        {
            this.productos = productos;
            fecha = tiempo.Now();
            this.importe = importe;
        }

    }
}
