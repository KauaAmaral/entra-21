using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            // Solicite o preço e nome da peça de 13 peças.

            int indice = 0;

            while (indice < 13)
            {
                Console.WriteLine("Nome da peça: ");
                string nomePeca = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Preço da peça: ");
                double precoPeca = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                indice = indice + 1;
            }

        }
    }
}
