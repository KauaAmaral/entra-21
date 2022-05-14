using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForTry
{
    internal class Exercicio03
    {
        public void Executar()
        {
            // Solicite um número e apresentar a tabuada do mesmo até 1000.

            var tabuada = 0;
            var i = 1000;

            while (tabuada <= 0)
            {
                try
                {
                    Console.Write("Digite qual tabuada deseja: ");
                    tabuada = Convert.ToInt32(Console.ReadLine());

                    if (tabuada <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine(@"Apenas maiores que 0.
                        ");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(@"Apenas números inteiro.
                    ");
                }
            }

            for (var j = 1; j <= i; j++)
            {
                var resultado = j * tabuada;
                Console.WriteLine(j + " x " + tabuada + " = " + resultado);
            }
        }
    }
}