using System;
/* 
Para el ejemplo, pensamos en un ticket de una compra. El mismo deberia tener al menos: producto, cantidad de producto, precio unitario, 
fecha de la compra y monto a pagar. Ademas, si la compra se realiza un dia sabado o domingo, hay un 15% de descuento.
 */
namespace ManejoDeTiempos
{
    class Program
    {
        static void Main(string[] args)
        {
            TiempoFalso tiempo = new TiempoFalso();
            Console.WriteLine(tiempo.Now().DayOfWeek);
            tiempo.AgregarDias(5);
            Console.WriteLine(tiempo.Now().DayOfWeek);
            tiempo.AgregarDias(1);
            Console.WriteLine(tiempo.Now().DayOfWeek);
        }
    }
}
