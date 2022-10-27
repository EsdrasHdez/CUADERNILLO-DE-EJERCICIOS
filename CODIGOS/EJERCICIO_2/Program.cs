using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            string cliente, fecha;
            double presta, Tprest=0, interes=0, dinero, total=0;
           
            for (x=1; x<=100; x++)
            {
                Console.WriteLine("EL PRESTAMO COBRA CON EL 10% DE INTERES \n");
                Console.WriteLine("Ingresa el nombre del Cliente");
                cliente = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingresa el fehca del prestamo");
                fecha = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingresa la cantidad del prestamo");
                presta = double.Parse(Console.ReadLine());
                Console.WriteLine("................................................................................ \n");
                dinero = 100000;
                if (presta <= 10000)
                {
                    interes = presta * 10 / 100;
                    Tprest = presta + interes;
                    total = dinero - presta;
                    Console.WriteLine("NOMBRE DEL CLIENTE: " + cliente);
                    Console.WriteLine("FECHA DEL PRESTAMO: " + fecha);
                    Console.WriteLine("PRESTAMO: $ " + presta);
                    Console.WriteLine("INTERES DEL PRESTAMO ES 10%: $ " + interes);
                    Console.WriteLine("TOTAL QUE DEBE DE PAGAR EL PRESTRAMO : $" + Tprest + "\n");
                    Console.WriteLine("................................................................................ \n");
                    Console.WriteLine("CANTIDA DE DINERO QUE QUEDA");
                    Console.WriteLine("$" + total + "\n" + "\n");
                    Console.WriteLine("................................................................................ \n");
                }
                else if (presta >= 11000)
                {
                    Console.WriteLine("LO SIENTIMOS ESA CANTIDA NO TE PODAMOS PRESTAR, SE PUEDE 10,000 O MENOS \n");
                    Console.WriteLine("................................................................................ \n");
                }
            }
            Console.ReadLine();
        }
    }
}
