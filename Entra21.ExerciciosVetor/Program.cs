using Entra21.ExerciciosVetor;

Console.WriteLine(@"--------Menu-------
1- Exercício 01
1- Exercício 02
3- Exercício 03
4- Exercício 04
5- Exercício 05
6- Exercício 06
7- Exercício 07
");

var opcaoDesejada = 0;

while ((opcaoDesejada <= 0) || (opcaoDesejada > 7))
{
    try
    {
        Console.WriteLine("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if ((opcaoDesejada <= 0) || (opcaoDesejada > 7))
        {
            Console.WriteLine(@"
Apenas um número do menu
");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(@"
Apenas um numero do menu
");
    }
}
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
else if (opcaoDesejada == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}