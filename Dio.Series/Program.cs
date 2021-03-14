using DIO.Series;
using System;

namespace Dio.Series
{
    class Program
    {
        static void Main(string[] args)
        {
			string opcaoUsuario = Operacoes.ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						Operacoes.ListarSeries();
						break;
					case "2":
						Operacoes.InserirSerie();
						break;
					case "3":
						Operacoes.AtualizarSerie();
						break;
					case "4":
						Operacoes.ExcluirSerie();
						break;
					case "5":
						Operacoes.VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = Operacoes.ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
		}
    }
}
