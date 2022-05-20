using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            // 1. Crie um vetor para guardar 16 números inteiros.
            // Preencha todas as posições com números e apresente a soma destes números.

            int[] numeros = new int[16];
            var soma = 0.0;

            for (int i = 0; i < numeros.Length; i++)
            {
                var numeroString = true;

                while (numeroString == true)
                {
                    try
                    {
                        Console.Write("Digite um número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        soma = soma + numeros[i];

                        numeroString = false;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Apenas números");

                        numeroString = true;
                    }
                }
            }

            Console.WriteLine($"Soma: {soma}");
        }
    }
}
