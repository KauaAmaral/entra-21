    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            // Solicite um número e apresentar a tabuada do mesmo até 1000.

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int indice = 0, resultado = 0;

            while (indice < 1000)
            {
                indice = indice + 1;
                resultado = numero * indice;

                Console.WriteLine(indice + " x " + numero + " = " + resultado);
            }
        }
    }
}
