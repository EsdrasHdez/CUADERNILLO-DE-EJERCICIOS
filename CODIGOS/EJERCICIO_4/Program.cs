using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_negativo_positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado, perimetro, area;
            int opcion;
            Console.WriteLine("AREA O PERIMETRO ");
            Console.WriteLine("ingrese el lado del cuadrado");
            lado=double.Parse(Console.ReadLine());
            Console.WriteLine("1-area");
            Console.WriteLine("2-perimetro");
            Console.WriteLine("elige una opcion anterior");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    area = lado * lado;
                    Console.WriteLine("el area es " + area);
                    break;
                case 2:
                    perimetro = lado*4;
                    Console.WriteLine("el perimetro es " + perimetro);
                    break;
                default:
                    Console.WriteLine("esa opcion no existe");
                    break;
                    }
            
                    Console.ReadKey();

        }
    }
}
