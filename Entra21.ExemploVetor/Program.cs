using Entra21.ExemploVetor;

Console.WriteLine(@"--------Menu-------
1- Exemplo 01
2- Exemplo 02
");

var opcaoDesejada = 0;

while ((opcaoDesejada <= 0) || (opcaoDesejada > 2))
{
    try
    {
        Console.WriteLine("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if ((opcaoDesejada <= 0) || (opcaoDesejada > 2))
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
    ExemploVetor exemploVetor = new ExemploVetor();
    exemploVetor.Executar();
}
else if (opcaoDesejada == 2)
{
    ExemploProfessor exemploProfessor = new ExemploProfessor ();
    exemploProfessor.Executar();
}