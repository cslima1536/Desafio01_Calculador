using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01_Calculador
{
	public class CalculoMultiplicacao
	{
		public int Valor1 { get; set; }
		public int Valor2 { get; set; }
		public void Multiplicacao() 
		{
			Console.WriteLine("Você escolheu fazer uma multiplicação!");
			Console.Write("Digite primeiro valor : ");
			Valor1 = int.Parse(Console.ReadLine());
			Console.Write("Digite segundo valor : ");
			Valor2 = int.Parse(Console.ReadLine());
			Console.WriteLine("A multiplicação dos valores : " + (Valor1 * Valor2));
		}
	}
}
