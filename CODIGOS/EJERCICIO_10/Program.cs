using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos nuestras variables.
            int edad;
            string tipo;
 
            // Solicitamos la información al usuario.
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
 
            // Evaluamos la edad
            switch(edad)
            {
                case >= 60:
                tipo = "anciano";
                break;
                case >= 50:
                tipo = "adulto mayor";
                break;
                case >= 30:
                tipo = "adulto";
                break;
                case >= 20:
                tipo = "joven";
                break;
                case >= 13:
                tipo = "adolescente";
                break;
                case >= 10:
                tipo = "puberto";
                break;
                case >= 4:
                tipo = "infante";
                break;
                case >= 0:
                tipo = "recién nacido";
                break;
                default:
                tipo = "ingrese una edad correcta";
                break;
            }
 
            Console.WriteLine("Es un: " + tipo);
        }
    }
}