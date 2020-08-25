using System;

/*
Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7*h) - 58
Para mulheres: (62.1*h) - 44.7
*/

class MainClass {
	public static double CalcPeso (double h, char sexo) {
    double peso=-1;

		if (sexo=='H')
			peso = 72.7*h-58;
		else
			if (sexo=='M')
				peso = 62.1*h-44.7;
		return peso;
  }

  public static void Main () {
    char sexo;
		double h;

		Console.Write("Informe seu sexo ('H' ou 'M'): ");
		sexo = char.Parse(Console.ReadLine());
		Console.Write("Informe sua altura: ");
		h = double.Parse(Console.ReadLine());

		Console.WriteLine("Seu peso ideal é: {0}", CalcPeso(h, sexo));
  }
}