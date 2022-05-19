using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForTry
{
    internal class Exercicio01
    {
        public void Executar()
        {
            // Solicite o preço e nome da peça de 13 peças.

            for (var i = 0; i < 13; i++)
            {
                var nomePeca = "";
                while (nomePeca.Length < 3)
                {
                    Console.WriteLine("Nome da peça: ");
                    nomePeca = Console.ReadLine();

                    if (nomePeca.Length < 3)
                    {
                        Console.WriteLine("Apneas peça com 3 ou mais letras.");
                    }
                }

                var valorPeca = 0.0;

                while (valorPeca <= 0)
                    try
                    {
                        Console.WriteLine("Valor da peça: ");
                        valorPeca = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (valorPeca <= 0)
                        {
                            Console.WriteLine("Valor não pode ser menor ou igual a 0");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor digitado não é um inteiro.");
                    }
            }

        }
    }
}
