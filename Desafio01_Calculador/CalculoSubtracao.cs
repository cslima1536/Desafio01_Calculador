using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01_Calculador
{
	public class CalculoSubtracao
	{
		public int Valor1 { get; set; }
		public int Valor2 { get; set; }
		public void Subtracao()
		{
			Console.WriteLine("Você escolheu fazer uma subtração!");
			Console.Write("Digite primeiro valor : ");
			Valor1 = int.Parse(Console.ReadLine());
			Console.Write("Digite segundo valor : ");
			Valor2 = int.Parse(Console.ReadLine());
			Console.WriteLine("A subtração dos valores : " + (Valor1 - Valor2));
		}
	}
}
