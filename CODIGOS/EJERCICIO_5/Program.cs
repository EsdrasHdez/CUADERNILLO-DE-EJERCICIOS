using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correc25
{
    class Program
    {
        static void Main(string[] args)
        {
            double cal1, cal2, cal3, cal4, cal5, cal6, prom;
            Console.WriteLine("..............................................................................................");
            {
                Console.WriteLine("Ingresa la calificación de MATEMÁTICAS: ");
                cal1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificación de EXPRESIÓN ORAL Y ESCRITA: ");
                cal2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificación de GEOGRAFÍA: ");
                cal3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificación de INGLÉS: ");
                cal4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la calificación de BILOGÍA: ");
                cal5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la calificación de ARTES");
                cal6 = double.Parse(Console.ReadLine());

                prom = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6) / 6;
                Console.WriteLine("El promedio que obtuviste es de: " + prom);

                if (prom >= 7.6 && prom <= 10)
                {
                    Console.WriteLine("HAS APROBADO");
                }
                else
                {
                    Console.WriteLine("HAS REPROBADO");
                }
            }
            Console.ReadKey();
        }
    }
}
