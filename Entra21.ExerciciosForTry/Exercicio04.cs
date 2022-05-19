using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForTry
{
    internal class Exercicio04
    {
        public void Executar()
        {
            // Solicite um número e apresente:
            // ● Os 50 números antecessores pares;
            // ● Os 50 números sucessores ímpares.

            var numeroString = true;
            var numero = 0;

            while (numeroString == true)
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    numero = Convert.ToInt32(Console.ReadLine());
                    numeroString = false;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Apenas numeros inteiro.");
                    numeroString = true;
                }
            }

            int ordemCrescente = numero, ordemDecrescente = numero;

            Console.WriteLine("" +
                "\nOs 50 números antecessores pares do número " + numero +
                "\n");

            for (var i = 0; i < 50; i++)
            {
                ordemDecrescente = ordemDecrescente - 1;

                if (ordemDecrescente % 2 == 0)
                {
                    Console.WriteLine(ordemDecrescente);
                }
            }

            Console.WriteLine("" +
                "\nOs 50 números sucessores ímpares do número " + numero +
                "\n");

            for (var i = 0; i < 50; i++)
            {
                ordemCrescente = ordemCrescente + 1;

                if (ordemCrescente % 2 != 0)
                {
                    Console.WriteLine(ordemCrescente);
                }
            }


        }
    }
}
