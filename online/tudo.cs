using System;
using System.Collections;

namespace app
{
	class App
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("iniciando o jogo...");
			Jogo j = new Jogo();
			Console.WriteLine("distribuindo as cartas...");
			j.DistribuirCartas();
			Jogador ganhador = j.ExecutarRodada();
			Console.WriteLine("o ganhador foi o "+ganhador.GetNome());
		}
	}
}

class Jogo
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

class Carta
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

class Jogador
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