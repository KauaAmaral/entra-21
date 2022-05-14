﻿using Entra21.ExerciciosForTry;

Console.WriteLine(@"--------Menu-------
1- Exercício 01
2- Exercício 05
");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
