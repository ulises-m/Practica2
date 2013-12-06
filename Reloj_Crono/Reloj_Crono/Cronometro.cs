using System;

namespace Reloj_Crono
{
	public class Cronometro
{
		public Cronometro ()
{
		int h = 00;
		int m = 00;
		int s = 00;
		int x;
		Console.WriteLine("\r\n ----CRONOMETRO----    Enter (Inicio)");
	    Console.ReadKey();
		
			while (true) {
			Console.WriteLine (" Cronometro: {0}:{1}:{2}", h, m, s);

			x = Environment.TickCount & Int32.MaxValue;//Funcion para tomar la hora del sistema
			
				while (Environment.TickCount <= x+1000);
			

				s = s + 1;
					if (s == 60) {
							s = 0;
				m = m + 1;
					if (m == 60) {
							m = 0;
				h = h + 1;
					if (h == 24) {
							h = 0;
					}}}
					Console.Clear();//limpiar consola
			}

		}

	}
}
