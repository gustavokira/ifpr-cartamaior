using System;
namespace jogo
{
	public class Jogador
	{
		private Carta carta;
		private String nome;

		public Jogador(String nome)
		{
			this.carta = null;
			this.nome = nome;
		}

		public void PegarCarta(Carta c)
		{
			this.carta = c;
		}

		public Carta JogarCarta()
		{
			Carta c = this.carta;
			this.carta = null;
			return c;
		}
		public String GetNome()
		{
			return this.nome;
		}
	}
}