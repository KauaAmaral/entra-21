using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            // Crie dois vetores para guardar o nome e preço de 7 produtos e apresente o nome e preço dos sete produtos.

            double[] valoresProdutos = new double[7];
            string[] nomesProdutos = new string[7];

            for (int i = 0; i < valoresProdutos.Length; i++)
            {
                Console.Write("Nome do produto: ");
                nomesProdutos[i] = Console.ReadLine();

                while (valoresProdutos[i] <= 0)
                {
                    try
                    {
                        Console.Write("Valor do produto: ");
                        valoresProdutos[i] = Convert.ToDouble(Console.ReadLine());

                        if (valoresProdutos[i] <= 0)
                        {
                            Console.WriteLine("Número inválido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite apenas números.");
                    }

                    Console.Clear();

                }
            }

            for (int i = 0; i < nomesProdutos.Length; i++)
            {
                Console.WriteLine(nomesProdutos[i] + " = " + valoresProdutos[i]);
            }
        }
    }
}
