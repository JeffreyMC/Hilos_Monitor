using System;
using System.Threading;

namespace MonitorPrueba
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Impresora imprime = new Impresora(); // instancia la clase impresora

			//apréndase la sintaxis de estas declaraciones de memoria
			//crea los objetos thread y le paso el método de la clase impresora

			//crea el primer hilo
			Thread hilo1 = new Thread(new ThreadStart(imprime.imprimir));
			hilo1.Name = "Proceso1";

			//crea el segundo hilo
			Thread hilo2 = new Thread(new ThreadStart(imprime.imprimir));
			hilo2.Name = "Proceso2";

			//crea el tercer hilo
			Thread hilo3 = new Thread(new ThreadStart(imprime.imprimir));
			hilo3.Name = "Proceso3";

			//inicia los procesos
			hilo1.Start();
			hilo2.Start();
			hilo3.Start();

			Console.ReadKey();
		}
	}
}
