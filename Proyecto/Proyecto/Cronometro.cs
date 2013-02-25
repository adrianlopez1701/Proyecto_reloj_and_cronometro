using System;

namespace Proyecto
{
	public class Cronometro
	{
		private int hrs;
		private int min;
		private int seg;
		private Utilerias utilerias;
		
		public Cronometro ()
		{
			this.hrs = 0;
			this.min = 0;
			this.seg = 0;
			this.utilerias = new Utilerias();
		}
		
		public void iniciar(){
			this.inicia();			
		}
		
		private void inicia(){
			this.utilerias.limpiar();
			for(this.hrs = 0; this.hrs < 1000; this.hrs++){
				for(this.min = 0; this.min < 60; this.min++){
					for(this.seg = 0; this.seg < 60; this.seg++){
						this.utilerias.imprimeLaHora(this.hrs, this.min, this.seg);
						this.utilerias.duerme();
						this.utilerias.limpiar();
					}
				}
			}
			
		}
		
	}
}
