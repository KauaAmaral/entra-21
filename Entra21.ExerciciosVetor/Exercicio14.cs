using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio14
    {
        public void Executar()
        {
            // Crie um vetor para armazenar os nomes dos produtos. Apresentar os nomes do menor nome até o maior nome.
            // Deve listar todos os nomes do menor para o maior.
            // Obrigatório utilização de for para apresentar os nomes do menor para o maior.


            string[] nomes = new string[5];
            var aux = "";

            for (var i = 0; i < nomes.Length; i++)
            {
                var nomeMenor2Letras = true;

                while (nomeMenor2Letras == true)
                {
                    Console.WriteLine("Nome: ");
                    nomes[i] = Console.ReadLine();
                    Console.Clear();

                    nomeMenor2Letras = false;

                    if (nomes[i].Length < 3)
                    {
                        Console.Clear();
                        Console.Write("Mínimo 3 letras.");
                        nomeMenor2Letras = true;
                    }
                }
            }


            for (var i = 0; i < nomes.Length; i++)
            {
                for (var j = 0; j < nomes.Length; j++)
                {
                    if (nomes[i].Length < nomes[j].Length)
                    {
                        aux = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux;
                    }
                }
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
