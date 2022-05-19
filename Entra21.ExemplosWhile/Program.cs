using Entra21.ExemplosWhile;

Console.WriteLine(@"--------Menu-------
1- Exemplo 01
2- Exemplo 02
3- Exemplo 03");

var opcaoDesejada = 0;

while ((opcaoDesejada <= 0) || (opcaoDesejada > 3))
{
    try
    {
        Console.WriteLine("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if ((opcaoDesejada <= 0) || (opcaoDesejada > 3))
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
Console.Clear(); ;

if (opcaoDesejada == 1)
{
    Exemplo01 meuExemplo01 = new Exemplo01();
    meuExemplo01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 meuExemplo02 = new Exemplo02();
    meuExemplo02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 meuExemplo03 = new Exemplo03();
    meuExemplo03.Executar();
}