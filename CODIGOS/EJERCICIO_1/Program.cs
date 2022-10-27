using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFE_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anterior, actual, Ckwh, operacion;
            double pServicio, PserIva, pagoTotal;
            Console.WriteLine("COSTO DEL CONSUMO DE KWH");
            Console.WriteLine("1 = 0.745");
            Console.WriteLine("2 = 0.650");
            Console.WriteLine("Introduce el opcion que cuesta por el consumo de KWH");
            operacion = int.Parse(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    Console.WriteLine("Ingresa el consumo de KWH anterior");
                    anterior = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el consumo de KWH actual");
                    actual = int.Parse(Console.ReadLine());
                    Ckwh = actual - anterior;
                    pServicio = Ckwh * 0.745;
                    PserIva = Ckwh * 16 / 100;
                    pagoTotal = pServicio + PserIva;
                    Console.WriteLine("CONSUMO DE KWH ANTERIOR " + anterior);
                    Console.WriteLine("CONSUMO DE KWH ACTUAL " + actual);
                    Console.WriteLine("CONSUMIDO DE KWH " + Ckwh);
                    Console.WriteLine("PAGO DE SERVICIO SIN IVA $" + pServicio);
                    Console.WriteLine("PAGO DEL SERVICIO CON IVA $" + pagoTotal);
                    break;
                case 2:
                    Console.WriteLine("Ingresa el consumo de KWH anterior");
                    anterior = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el consumo de KWH actual");
                    actual = int.Parse(Console.ReadLine());
                    Ckwh = actual - anterior;
                    pServicio = Ckwh * 0.650;
                    PserIva = Ckwh * 16 / 100;
                    pagoTotal = pServicio + PserIva;
                    Console.WriteLine("CONSUMO DE KWH ANTERIOR " + anterior);
                    Console.WriteLine("CONSUMO DE KWH ACTUAL " + actual);
                    Console.WriteLine("CONSUMIDO DE KWH " + Ckwh);
                    Console.WriteLine("PAGO DE SERVICIO SIN IVA $" + pServicio);
                    Console.WriteLine("PAGO DEL SERVICIO CON IVA $" + pagoTotal);
                    Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, \n \n ");
                    break;
                default: Console.WriteLine("UPS EL NUMERO QUE PRECINASTE NO INDICA QUE TE MUESTRA LA PANTALLA");
                    Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, \n \n ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
