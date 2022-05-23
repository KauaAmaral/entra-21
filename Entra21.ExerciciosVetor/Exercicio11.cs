using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio11
    {
        public void Executar()
        {

            // Crie um vetor e solicite os números. Crie outros dois vetores, um deles irá armazenar
            // somente os números pares do vetor 1, o outro irá armazenar somente os números ímpares do vetor 1.
            // Obrigatório utilização de for para preencher o vetor 2 e 3.

            var quantidadePares = 0;
            var quantidadeImpares = 0;
            double[] numeros = new double[10];
            double[] numerosImpares = new double[10];
            double[] numerosPares = new double[10];


            for (var i = 0; i < numeros.Length; i++)
            {
                var numeroLetra = true;
                while (numeroLetra == true)
                {
                    try
                    {
                        Console.Write("Numeros: ");
                        numeros[i] = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        numeroLetra = false;

                        if (numeros[i] % 2 == 0)
                        {

                            numerosPares[quantidadePares] = numeros[i];
                            quantidadePares = quantidadePares + 1;
                        }
                        else if (numeros[i] % 2 != 0)
                        {

                            numerosImpares[quantidadeImpares] = numeros[i];
                            quantidadeImpares = quantidadeImpares + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        numeroLetra = true;
                        Console.Write("Valor Inválido.");
                    }
                }
            }

            for (var i = 0; i < quantidadeImpares; i++)
            {
                Console.WriteLine("Impares: " + numerosImpares[i]);
            }
            for (var i = 0; i < quantidadePares; i++)
            {
                Console.WriteLine("Pares: " + numerosPares[i]);
            }

        }
    }
}

