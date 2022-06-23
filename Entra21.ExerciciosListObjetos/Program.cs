using Entra21.ExerciciosListObjetos.Exercicio01;
using Entra21.ExerciciosListObjetos.Exercicio02;

Console.WriteLine(@"--------Menu-------
1- Exercício 01
1- Exercício 02
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
Apenas um número do menu
");
    }
}
Console.Clear();

if (opcaoDesejada == 1)
{
    TrianguloControlador controlador = new TrianguloControlador();
    controlador.GerenciarMenu();
}
else if (opcaoDesejada == 2)
{
    AlunoControlador controlador = new AlunoControlador();
    controlador.GerenciarMenu();
}
