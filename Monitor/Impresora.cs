using System;
using System.Threading;

namespace MonitorPrueba
{
	public class Impresora
	{
		public void imprimir()
		{
			//los procesos entran pero el primero que llegue bloquea el campo
			//mediante esta instrucción
			Monitor.Enter(this);

			//imprimo el mensaje de que está bloqueado el espacio
			Console.WriteLine("El {0} entra y bloquea el espacio", Thread.CurrentThread.Name);

			//esto lo que hace es que en la consola espera 3 segundoos para liberar el espacio
			//si no lo pongo no vería como entran en 'tiempo real' los procesos
			Thread.Sleep(3000);

			//imprimo el mensaje de que se liberó el campo
			Console.WriteLine("El {0} sale y libera el espacio", Thread.CurrentThread.Name);

			//el campo se libera por medio de la siguiente instrucción
			//y el siguiente proceso ya puede ocupar el espacio
			Monitor.Exit(this);
		}
	}
}

