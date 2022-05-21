using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio06
    {
        public void Executar()
        {
            // Solicite a idade de 9 pessoas, apresente ao final a pessoa com a maior idade.

            int[] idades = new int[9];
            string[] nomes = new string[9];
            var nomeMaiorIdade = "";
            var nomeMenorIdade = "";
            var maiorIdade = int.MinValue;
            var menorIdade = int.MaxValue;

            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write("Digite seu nome: ");
                nomes[i] = Console.ReadLine();

                var numeroMenor0 = true;

                while (numeroMenor0 == true)
                {
                    try
                    {
                        Console.Write("Sua idade: ");
                        idades[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        numeroMenor0 = false;

                        if (idades[i] <= 0)
                        {
                            Console.WriteLine("Apenas acima de 0");
                            numeroMenor0 = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite uma idade válida.");
                        numeroMenor0 = true;
                    }

                }

                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    nomeMaiorIdade = nomes[i];

                }

                if (idades[i] < menorIdade)
                {
                    menorIdade = idades[i];
                    nomeMenorIdade = nomes[i];
                }

            }
            Console.Clear();

            Console.WriteLine($@"Maior idade: {nomeMaiorIdade}: {maiorIdade} anos
Menor idade: {nomeMenorIdade}: {menorIdade} anos");
        }
    }
}
