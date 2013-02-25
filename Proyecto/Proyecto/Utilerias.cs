using System;

namespace Proyecto
{
	public class Utilerias
	{
		public Utilerias ()
		{
		}
		public string obtenFormatoDobleCero(int numero){
			string numeroConFormato = "";
			if(numero < 10){
				numeroConFormato = "0";
			}
			
			numeroConFormato += numero;
			return numeroConFormato;
		}
		
		public void duerme(){
			System.Threading.Thread.Sleep(10);
		}
		
		public void limpiar(){
			Console.Clear();
		}
		
		public void imprimeLaHora(int hrs, int min, int seg){
			Console.WriteLine(this.obtenFormatoDobleCero(hrs) + ":" + 
			                  this.obtenFormatoDobleCero(min) + ":" + 
			                  this.obtenFormatoDobleCero(seg));
		}
	}
}

