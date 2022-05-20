using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            // Crie um vetor para guardar 10 nomes e apresente os dez nomes.

            string[] nomes = new string[10];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine().Trim();
                Console.Clear();
            }

            Console.WriteLine(@"Todos os nomes:
");

            for(int i = 0;i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

        }

    }
}

