using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio04;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio05;

Console.WriteLine(@"--------Menu-------
1- Exercício 01
2- Exercício 02
3- Exercício 03 
4- Exercício 04
5- Exercício 05
");

var opcaoDesejada = 0;

while ((opcaoDesejada <= 0) || (opcaoDesejada > 5))
{
    try
    {
        Console.WriteLine("Digite a opção desejada: ");
        opcaoDesejada = Convert.ToInt32(Console.ReadLine());

        if ((opcaoDesejada <= 0) || (opcaoDesejada > 5))
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
    ExemploLivro exemploLivro = new ExemploLivro();
    exemploLivro.Executar();
}
else if (opcaoDesejada == 2)
{
    ExemploTemperatura exemploTemperatura = new ExemploTemperatura();
    exemploTemperatura.Executar();
}
else if (opcaoDesejada == 3)
{
    ExemploConversorAscii exemploConversorAscii = new ExemploConversorAscii();
    exemploConversorAscii.Executar();
}
else if (opcaoDesejada == 4)
{
    ExemploFarmacia exemploFarmacia = new ExemploFarmacia();
    exemploFarmacia.Executar();
}
else if (opcaoDesejada == 5)
{
    ExemploBoletim exemploBoletim = new ExemploBoletim();
    exemploBoletim.Executar();
}
