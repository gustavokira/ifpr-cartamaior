using System;
using jogo;

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
