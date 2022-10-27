using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un programa que dado un operario se conoce su sueldo y los años de antigüedad.");
            Console.WriteLine("Realizar un programa que lea los datos de entrada e indicar:");
            Console.WriteLine("Si el sueldo es  mayor  o igual a $10000 y su antigüedad es mayor o igual a 8 años, otorgarle un aumento del 25 %, mostrar el sueldo a pagar.");
            Console.WriteLine("Si el sueldo es mayor o igual a $10000 y su antigüedad es menor o igual a 7 años, otorgarle un aumento de 15 %.");
            Console.WriteLine("Si el sueldo es menor  a 10000 mostrar el sueldo.");
            Console.WriteLine("..............................................................................................................");

            double sueld, sueldT, aumento;
            int antiguedad;
            Console.WriteLine("Ingresa el sueldo del empleado");
            sueld = double.Parse(Console.ReadLine());
            if (sueld>=10000)   
            {
                Console.WriteLine("Ingresa los años de trabajo");
                antiguedad = int.Parse(Console.ReadLine());
                if (antiguedad>=8)
                {
                    aumento = sueld * 0.25;
                    sueldT = aumento + sueld;
                    Console.WriteLine("Aumento $ " + aumento);
                    Console.WriteLine("Sueldo total $" + sueldT);
                }
                else if (antiguedad<=7)
                {
                    aumento = 10000 * 0.15;
                    sueldT = aumento + sueld;
                    Console.WriteLine("Aumento $ " + aumento);
                    Console.WriteLine("Sueldo total $" + sueldT);
                }
            }
            else
            {
                Console.WriteLine("El sueldo a pagar es de : $ " + sueld);
            }
            Console.ReadKey();
        }
    }
}
