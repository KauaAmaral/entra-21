using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            // Crie um vetor para armazenar as notas de uma disciplina. A disciplina deve conter 4 notas.
            // Solicite para o usuário o nome e as quatro notas, armazenando as notas em um vetor, realize a média destas notas e apresente.

            double[] notas = new double[4];

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            var media = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                while (notas[i] <= 0)
                {
                    try
                    {
                        Console.Write("Nota: ");
                        notas[i] = Convert.ToDouble(Console.ReadLine());

                        if (notas[i] <= 0)
                        {
                            Console.WriteLine("Nota menor ou igual a 0 não é válida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite uma nota válida.");
                    }
                }

                media = media + notas[i];

            }

            Console.WriteLine(@"
Média: " + media / 4);




        }
    }
}
