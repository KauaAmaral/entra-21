using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            // Solicite um número e faça o fatorial deste número, utilizando while.

            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            double resultado = 1;

            while (numero != 1)
            {
                resultado = resultado * numero;
                numero = numero - 1;
            }
            Console.Clear();
            Console.WriteLine("Resultado fatorial: " + resultado);
        }
    }
}
