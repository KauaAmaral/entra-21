using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio10
    {
        public void Executar()
        {
            // Criei um vetor e solicite 8 números. Crie outro vetor preenchendo ele da seguinte forma.
            // - Primeira posição do vetor 2 recebe a soma da última posição do vetor 1 e a primeira posição do vetor 1.
            // - Segunda posição do vetor 2 recebe a soma da primeira posição do vetor 1 e a segunda posição do vetor 1.
            // - E continua até terminar o preenchimento do vetor 2.
            // Obrigatório utilização de for para preencher o vetor 2.

            var quantidade = 7;
            int[] numerosSolicitados = new int[8];
            int[] numerosSomados = new int[8];

            for (var i = 0; i < numerosSolicitados.Length; i++)
            {
                var numeroLetra = true;
                while (numeroLetra == true)
                {
                    try
                    {
                Console.Write("Numero: ");
                numerosSolicitados[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                        numeroLetra = false;
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Valor inválido.");
                        numeroLetra = true;
                    }
                }
            }

            for (var i = 0; i < numerosSolicitados.Length; i++)
            {
                numerosSomados[i] = numerosSolicitados[i] + numerosSolicitados[quantidade];
                quantidade = quantidade - 1;
            }

            Console.WriteLine("Soma: ");

            for (var i = 0; i < numerosSolicitados.Length; i++)
            {

                Console.WriteLine(numerosSomados[i]);
            }
        }
    }
}
