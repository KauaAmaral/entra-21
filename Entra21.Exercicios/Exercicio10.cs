using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            // Solicite um número e apresente:
            // ● Os 50 números antecessores pares;
            // ● Os 50 números sucessores ímpares

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int ordemDecrescente = 0, indice = 0, ordemCrescente = 0, indice2 = 0;
            ordemDecrescente = numero;
            ordemCrescente = numero;

            Console.WriteLine(@"
Os 50 números antecessores pares do número: " + numero +
"");

            while (indice < 50)
            {
                ordemDecrescente = ordemDecrescente - 1;

                if (ordemDecrescente % 2 == 0)
                {
                    Console.WriteLine(ordemDecrescente);
                }
                indice = indice + 1;
            }

            Console.WriteLine(@"
Os 50 números sucessores ímpares do número: " + numero +
"");

            while (indice2 < 50)
            {
                ordemCrescente = ordemCrescente + 1;

                if (ordemCrescente % 2 != 0)
                {
                    Console.WriteLine(ordemCrescente);
                }
                indice2 = indice2 + 1;
            }
        }
    }
}
