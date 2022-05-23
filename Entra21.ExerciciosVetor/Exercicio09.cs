using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio09
    {
        public void Executar()
        {
            // Criar dois vetores, no primeiro solicite os nomes para o usuário, o outro vetor deverá ser preenchido da seguinte forma:
            // -Primeira posição vetor 2 recebe última posição vetor 1.
            // - Segunda posição vetor 2 recebe penúltima posição vetor 1.
            // - E continua até terminar o preenchimento do vetor 2.
            // Obrigatório utilização de for para preencher o vetor 2.
            // O tamanho do vetor você escolhe, mínimo de 5 posições.

                  var quantidade = 5;
          string[] nomesVetor1 = new string[quantidade];
            string[] nomesVetor2 = new string[quantidade];
		

            for (var i = 0; i < nomesVetor1.Length; i++)
            {
                 var nomeMenosLetras = true;
                while (nomeMenosLetras == true)
                {
                    Console.Write("Nome: ");
                    nomesVetor1[i] = Console.ReadLine().Trim();    
                    Console.Clear();

                    nomeMenosLetras = false;

                    if (nomesVetor1[i].Length < 3)
                    {
                        Console.Clear();
                        Console.WriteLine("No mínimo 3 letras.");
                        nomeMenosLetras = true;
                    }
                }
            }

            for (var i = 0; i < nomesVetor1.Length; i++)
            {
                nomesVetor2[i] = nomesVetor1[quantidade-1];
				quantidade = quantidade - 1;
            }
		 for (var i = 0; i < nomesVetor1.Length; i++)
            {
                Console.WriteLine("Nomes: " + nomesVetor1[i] +
					"\nNomes Invertido: " + nomesVetor2[i]);
		 }
        }



    }
}
}
