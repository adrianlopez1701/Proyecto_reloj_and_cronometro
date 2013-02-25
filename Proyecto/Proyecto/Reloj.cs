using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Proyecto
{
	class Reloj
	{
		public void iniciar()
		{
			for (; ; ) 
			{
				Console.Clear();
				Console.WriteLine(DateTime.Now); 
				Thread.Sleep(1000); 
			}
		}
	}
}
