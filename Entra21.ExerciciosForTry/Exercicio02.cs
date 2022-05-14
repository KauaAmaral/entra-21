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

            Console.WriteLine("Quantos carros voccê deseja cadastrar?");
            var quantidadeCarrosCadastrados = Convert.ToInt32(Console.ReadLine());
            int somaAno = 0, mediaAno = 0, somaG = 0, somaA = 0;
            double somaValor = 0, mediaValor = 0;

            for (var i = 0; i < quantidadeCarrosCadastrados; i++)
            {
                Console.WriteLine("Modelo do carro:");
                var modelo = Console.ReadLine().ToLower().Trim();

                Console.WriteLine("Valor do carro:");
                var valorCarro = Convert.ToDouble(Console.ReadLine());
                somaValor = somaValor + valorCarro;

                Console.WriteLine("Ano do carro:");
                var anoCarro = Convert.ToInt32(Console.ReadLine());
                somaAno = somaAno + anoCarro;

                if (modelo.StartsWith("g"))
                {
                    somaG = somaG + 1;
                }
                else if (modelo.StartsWith("a"))
                {
                    somaA = somaA + 1;
                }


            }



        }
    }
}
