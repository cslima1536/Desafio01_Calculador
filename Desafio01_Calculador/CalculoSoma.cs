using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01_Calculador
{
	public class CalculoSoma
	{
		public int Valor1 { get; set; }
		public int Valor2 { get; set; }
		public void Soma()
		{
			Console.WriteLine("Você escolheu fazer uma soma!");
			Console.Write("Digite primeiro valor : ");
			Valor1 = int.Parse(Console.ReadLine());
			Console.Write("Digite segundo valor : ");
			Valor2 = int.Parse(Console.ReadLine());
			Console.WriteLine("A soma dos valores:  " + (Valor1 + Valor2));
		}
	}
}
