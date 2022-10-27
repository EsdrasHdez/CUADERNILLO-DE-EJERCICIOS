using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inscripcion_uthh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, fecha;
            double costoCurso;
            int  edad;
            {
                Console.WriteLine("CURSOS DE PROGRAMACION EN UTHH  ");
                Console.WriteLine("EL COSTO DE LA INSCRIPCION ES DE $150.00 \n ");
                Console.WriteLine(".................................................");
                Console.WriteLine("INGRESA EL NOMBRE COMPLETO");
                nombre = Convert.ToString(Console.ReadLine());
                Console.WriteLine("INGRESA CUANTOS AÑOS TIENES");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESA LA FECHA DE INSCRIPCION");
                fecha = Convert.ToString(Console.ReadLine());
                costoCurso = 150;
                Console.WriteLine("................................................. \n ");
                Console.WriteLine("BIENVENIDO UTHH");
                Console.WriteLine("ERES PARTE DE LA UNIVERSIDAD UTHH");
                Console.WriteLine("NOMBRE DEL ASPIRANTE: " + nombre);
                Console.WriteLine("NÚMERO DE FOLLIO: UTHH-" + 2214 + edad);
                Console.WriteLine("FECHA DE REGISTRO: " + fecha);
                Console.WriteLine("PAGO DE FICHA ES $" + costoCurso + "\n" );
                Console.WriteLine("POR SIEMPRE LOS MEJORES");

                Console.ReadKey();
            }
        }
    }
}
