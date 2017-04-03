using System;
using System.Collections;

namespace jogo
{
	public class Jogo
	{
		private Jogador j1;
		private Jogador j2;
		private ArrayList cartas;

		public Jogo()
		{
			this.j1 = new Jogador("jogador 1");
			this.j2 = new Jogador("jogador 2");
			this.cartas = new ArrayList();

			Carta c1 = new Carta(1);
			Carta c2 = new Carta(2);

			this.cartas.Add(c1);
			this.cartas.Add(c2);
		}

		public Carta RetirarCartaDoTopo()
		{
			Carta c = (Carta)this.cartas[0];
			this.cartas.RemoveAt(0);
			return c;
		}

		public Carta RetirarCartaDoFundo()
		{
			Carta c = (Carta)this.cartas[this.cartas.Count - 1];
			this.cartas.RemoveAt(this.cartas.Count - 1);
			return c;
		}

		public void DistribuirCartas()
		{
			Carta c1 = this.RetirarCartaDoTopo();
			this.j1.PegarCarta(c1);

			Carta c2 = this.RetirarCartaDoTopo();
			this.j2.PegarCarta(c2);
		}

		public Jogador ExecutarRodada()
		{
			Carta c1 = this.j1.JogarCarta();
			Carta c2 = this.j2.JogarCarta();

			int valor1 = c1.GetValor();
			int valor2 = c2.GetValor();

			Console.WriteLine("jogador 1 jogou " + valor1);
			Console.WriteLine("jogador 2 jogou " + valor2);

			Jogador ganhador = null;

			if (valor1 > valor2)
			{
				ganhador = this.j1;
			}
			if (valor1 < valor2)
			{
				ganhador = this.j2;
			}
			return ganhador;
		}
	}
}