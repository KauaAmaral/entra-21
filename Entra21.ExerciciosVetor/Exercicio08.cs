using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio08
    {
        public void Executar()
        {
            // Criar um vetor para armazenar 10 números, solicite os números e armazene.Será aceito neste vetor somente números pares.

            double[] numerosPares = new double[10];

            for (var i = 0; i < numerosPares.Length; i++)
            {
                var numero = 1.0;

                while (numero == 1)
                {
                    try
                    {
                        Console.Write("Numeros pares: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (numero % 2 == 0)
                        {
                            numerosPares[i] = numero;
                            numero = 0;
                        }
                        else if (numero % 2 != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Somente números pares.");
                            numero = 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um número válido.");
                        numero = 1;
                    }
                }
            }
            for (var i = 0; i < numerosPares.Length; i++)
            {
                Console.WriteLine(numerosPares[i]);
            }
        }
    }
}
