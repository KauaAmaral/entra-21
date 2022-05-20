using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            // Solicite para o usuário 5 pesos e apresente a soma total dos pesos e a média dos pesos.

            double[] pesos = new double[5];
            var soma = 0.0;

            for (int i = 0; i < pesos.Length; i++)
            {
                while (pesos[i] <= 0)
                {
                    try
                    {
                        Console.Write("Digite um peso: ");
                        pesos[i] = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (pesos[i] <= 0)
                        {
                            Console.WriteLine("Apenas maior que 0");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um número.");
                    }

                }
                soma = soma + pesos[i];
            }

            var media = 0.0;
            media = soma / 5;

            Console.WriteLine($@"Soma total: {soma}
Média: {media}");
        }
    }
}
