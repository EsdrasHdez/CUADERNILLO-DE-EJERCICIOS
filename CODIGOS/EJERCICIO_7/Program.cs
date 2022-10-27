using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compraLapices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            double costo, descuento, tpago;
            Console.WriteLine("Ingrese la cantidad de lapices comprados");
            cantidad = int.Parse(Console.ReadLine());
            costo = cantidad * 2.50;
            Console.WriteLine("Precio por lapiz : 2.50 ");
            Console.WriteLine("El costo es: $ " + costo );
            if (cantidad > 1000)
            {
                Console.WriteLine("Descuento = 7% ");
                descuento = costo * 0.07;
                Console.WriteLine(" es ===> " + descuento);
                tpago = costo - descuento;
                Console.WriteLine("El total a pagar es : " + tpago);
            }
            else
            {
                Console.WriteLine("No hay descuento ");
            }
            Console.ReadKey();
        }
    }
}
