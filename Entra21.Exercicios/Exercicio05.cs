using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio05
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

            Console.WriteLine("Quantidade de carros para cadastrar: ");
            int quantidadeCarros = Convert.ToInt32(Console.ReadLine());

            int indice = 0, comecaA = 0, comecaG = 0, anoCarro = 0, somaAnoCarro = 0, mediaAnoCarro = 0;
            string modeloCarro = "";
            double valorCarro = 0, mediaValorCarro = 0, somaValorCarro = 0;

            while (indice < quantidadeCarros)
            {
                indice = indice + 1;

                Console.WriteLine("Modelo: ");
                modeloCarro = Console.ReadLine().ToLower().Trim();

                if (modeloCarro.StartsWith("g"))
                {
                    comecaG = comecaG + 1;
                }
                else if (modeloCarro.StartsWith("a"))
                {
                    comecaA = comecaA + 1;
                }

                Console.WriteLine("Ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());

                somaAnoCarro = somaAnoCarro + anoCarro;

                mediaAnoCarro = somaAnoCarro / quantidadeCarros;


                Console.WriteLine("Valor: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());

                somaValorCarro = somaValorCarro + valorCarro;

                mediaValorCarro = somaValorCarro / quantidadeCarros;
            }

            Console.WriteLine("Média do ano dos carros: " + mediaAnoCarro +
                "\nMédia do valor dos carros: " + mediaValorCarro +
                "\nQuantidade de carros que começam com G: " + comecaG +
                "\nQuantidade de carros que começam com A: " + comecaA);

        }
    }
}
