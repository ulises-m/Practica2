using System;

namespace Reloj_Crono
{
	class Reloj_Crono
	{
	
		
		

		public static void Main (string[] args)
		{


			Console.WriteLine("\r\n-------Este Programa Tiene las funciones de Reloj y Cronometro Elige Una-------\r\n");
			Console.WriteLine("1)Reloj \r\n2)Cronometro");

			Console.Write ("\r\nSeleccione Una Opcion: ");

			String opcion = Console.ReadLine();//opcion para el Switch 
			int opcionn = int.Parse(opcion); //Parseo para trnsformar el String a entero

			switch (opcionn) 
			{
			case 1: 
				Console.WriteLine("\r\n ----RELOJ----");
			    new Reloj();
				break;
				
			case 2: 
				new Cronometro();
				break;
			
			
			default:
				Console.WriteLine("La opcion que Seleccione no Existe");
				break;

			

			}

		}
	}
}
