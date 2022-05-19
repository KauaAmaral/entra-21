using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForTry
{
    internal class Exercicio02
    {
        public void Executar()
        {
            // Faça um programa que solicite a quantidade de carros que o usuário deseja
            // cadastrar, após isto solicite para o usuário o modelo, valor e ano do carro até que
            // atinja a quantidade de carros para cadastro.
            // Apresente ao final:
            // ● Média do ano dos carros;
            // ● Média do valor dos carros;
            // ● Quantidade de carros que começam com a letra G;
            // ● Quantidade de carros que começam com a letra A.

            var quantidadeCarrosCadastrados = 0;
            while (quantidadeCarrosCadastrados <= 0)
            {
                try
                {
                    Console.WriteLine("Quantos carros voccê deseja cadastrar?");
                    quantidadeCarrosCadastrados = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (quantidadeCarrosCadastrados <= 0)
                    {
                        Console.WriteLine("Vaor acima de 0.");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Digite um valor válido.");
                }
            }

            int somaAno = 0, mediaAno = 0, somaG = 0, somaA = 0, anoCarro = 0;
            double somaValor = 0, mediaValor = 0, valorCarro = 0;

            for (var i = 0; i < quantidadeCarrosCadastrados; i++)
            {
                var modelo = "";
                while (modelo.Length < 2)
                {
                    Console.WriteLine("Modelo do carro:");
                    modelo = Console.ReadLine().ToLower().Trim();
                    Console.Clear();

                    if (modelo.Length < 2)
                    {
                        Console.WriteLine("Nome com 2 ou mais letra apenas.");
                    }
                }

                while (valorCarro <= 0)
                {
                    try
                    {
                        Console.WriteLine("Valor do carro:");
                        valorCarro = Convert.ToDouble(Console.ReadLine());

                        if (valorCarro <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine(@"Valor não pode ser menor ou igual a 0
                            ");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(@"Valor do carro não é válido
                        ");
                    }
                }

                somaValor = somaValor + valorCarro;

                while (anoCarro <= 0)
                {
                    try
                    {
                        Console.WriteLine("Ano do carro:");
                        anoCarro = Convert.ToInt32(Console.ReadLine());

                        if (anoCarro <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine(@"Ano do carro não pode ser menor ou igual a 0
                            ");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(@"Ano do carro não é valido
                        ");
                    }
                }

                somaAno = somaAno + anoCarro;

                if (modelo.StartsWith("g"))
                {
                    somaG = somaG + 1;
                }
                else if (modelo.StartsWith("a"))
                {
                    somaA = somaA + 1;
                }

                anoCarro = 0;
                valorCarro = 0;
                Console.Clear();

            }

            mediaValor = somaValor / quantidadeCarrosCadastrados;
            mediaAno = somaAno / quantidadeCarrosCadastrados;

            Console.WriteLine("Média do ano dos carros: " + mediaAno +
                "\nMédia do valor dos carros: " + mediaValor +
                "\nQuantidade de carros que começa com G: " + somaG +
                "\nQuantidade de carros que começa com A: " + somaA);
        }
    }
}
