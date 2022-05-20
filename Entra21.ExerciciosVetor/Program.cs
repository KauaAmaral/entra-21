using Entra21.ExerciciosVetor;

Console.WriteLine(@"--------Menu-------
1- Exercício 01
");

var opcaoDesejada = 0;

while ((opcaoDesejada <= 0) || (opcaoDesejada > 6))
{
    try
    {
        Console.WriteLine("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if ((opcaoDesejada <= 0) || (opcaoDesejada > 6))
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
