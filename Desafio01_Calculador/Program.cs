using System;

namespace Desafio01_Calculador
{
	class Program
	{
		static void Main(string[] args)
		{
			int opcao = 0;

			 void cabecalho() {
				Console.WriteLine("************* Calculadora**********");
				Console.WriteLine("************* 1 -Soma           ***");
				Console.WriteLine("************* 2 - Subtração     ***");
				Console.WriteLine("************* 3 - Multiplicação ***");
				Console.WriteLine("************* 4 - Dvisão        ***");
				Console.WriteLine("************ 99 - Sair          ***");
				Console.WriteLine("***********************************");
			}
			do
			{
				cabecalho();
				Console.Write("Digite um tipo de operação: ");
				opcao = int.Parse(Console.ReadLine());


				switch (opcao) {
					case 1: {
							CalculoSoma operacao = new CalculoSoma();
							operacao.Soma();
						}
						break;
					case 2:
						{
							CalculoSubtracao operacao = new CalculoSubtracao();
							operacao.Subtracao();
						}
						break;
					case 3:
						{
							CalculoMultiplicacao operacao = new CalculoMultiplicacao();
							operacao.Multiplicacao();
						}
						break;
					case 4:
						{
							CalculoDivisao operacao = new CalculoDivisao();
							operacao.Divisao();
						}
						break;
					default:
						Console.WriteLine("Sua escolha não esta em nenhuma das opções acima! ");						
						break;
				}
				Console.WriteLine("Pressione uma tecla para continuar");
				Console.ReadKey();
				Console.Clear();
			} while (opcao != 99);
			
		}
	}
}
