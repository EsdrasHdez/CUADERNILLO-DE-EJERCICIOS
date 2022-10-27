using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcions;
            double num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("CALCULADORA BASICA");
            Console.WriteLine("SELECCIONA UNA OPCION: ");
            Console.WriteLine("S - suma");
            Console.WriteLine("R - resta");
            Console.WriteLine("D - division");
            Console.WriteLine("M - multiplicacion");
            Console.WriteLine("SELECCIONA UNA OPCION: ");
            opcions = char.Parse(Console.ReadLine());
            {
                switch (opcions)
                {
                    case 'S':
                        Console.WriteLine("SUMA");
                        Console.WriteLine("INGRESA EL PRIMER NUMERO: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INGRESA EL SEGUNDO NUMERO: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 + num2;
                        Console.WriteLine("RESULTADO " + resultado);
                        break;
                    case 'R':
                        Console.WriteLine("RESTA");
                        Console.WriteLine("INGRESA EL PRIMER NUMERO: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INGRESA EL SEGUNDO NUMERO: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine("RESULTADO " + resultado);
                        break;
                    case 'D':
                        Console.WriteLine("DIVICION");
                        Console.WriteLine("INGRESA EL PRIMER NUMERO: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INGRESA EL SEGUNDO NUMERO: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 / num2;
                        Console.WriteLine("RESULTADO " + resultado);
                        break;
                    case 'M':
                        Console.WriteLine("MULTIPLICACION");
                        Console.WriteLine("INGRESA EL PRIMER NUMERO: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("INGRESA EL SEGUNDO NUMERO: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine("RESULTADO " + resultado);
                        break;
                    default: 
                        Console.WriteLine("NO COINSIDE CON LA TELCA INGRESADA");
                        Console.WriteLine("PRESICIONES LA TECLA QUE TE INDIQUA");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
