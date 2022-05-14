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
                Console.WriteLine("Nome da peça: ");
                var nomePeca = Console.ReadLine();

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
