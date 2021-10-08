using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01_Calculador
{
	public class CalculoDivisao
	{
		public int Valor1 { get; set; }
		public int Valor2 { get; set; }
		public void Divisao() 
		{
			Console.WriteLine("Você escolheu fazer uma divisão !");
			Console.Write("Digite primeiro valor : ");
			Valor1 = int.Parse(Console.ReadLine());
			Console.Write("Digite segundo valor : ");
			Valor2 = int.Parse(Console.ReadLine());

			if (Valor2 != 0)
			{
				Console.WriteLine("A divisao dos valores :" + (Valor1 / Valor2));
			}
			else
			{
				Console.WriteLine("A divisao por zero não é possivel !");
			}
		}
	}
}
