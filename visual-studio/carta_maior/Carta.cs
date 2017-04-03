using System;
namespace jogo
{
	public class Carta
	{
		private int valor;

		public Carta(int i)
		{
			this.valor = i;
		}

		public int GetValor()
		{
			return this.valor;
		}
	}
}