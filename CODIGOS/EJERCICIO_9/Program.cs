using System;
using System.Linq;

namespace Areas_figura
{
	public static class Program
	{
		public static void Main()
		{
			double b,a,area;
			int opcion;
			
			Console.WriteLine("calculadora de areas");
			Console.WriteLine("1-cuadrado");
			Console.WriteLine("2-triangulo");
			Console.WriteLine("3-rectabgulo");
			
			Console.WriteLine("elige una de las opciones abteriores");
			
			opcion=int.Parse(Console.ReadLine());
			
			
			switch(opcion)
			{
			case 1:
			Console.WriteLine("ingrese el lado del cuadrado");
			a=double.Parse(Console.ReadLine());
			area= a*a;
			Console.WriteLine("el area del cuadrado es:"+ area);
			break;
			case 2:
			Console.WriteLine("ingrese la base del triangulo");
			b=double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese la altura del triangulo");
			a=double.Parse(Console.ReadLine());
			area=(b*a)/2;
			Console.WriteLine("el area del triangulo es: "+area);
			break;
			case 3:
			Console.WriteLine("ingrese la base del rectagulo");
			b=double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese la altura del rectangulo");
			a=double.Parse(Console.ReadLine());
			area=b*a;
			Console.WriteLine("el area del rectangulo es: "+area);
			break;
			default:
			Console.WriteLine("esa opcion no existe");
			break;
			}

		}
	}
}