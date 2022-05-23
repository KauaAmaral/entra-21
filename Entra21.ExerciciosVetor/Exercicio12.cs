using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio12
    {
        public void Executar()
        {
        // Crie um vetor de números e solicite. Após isto apresentar os números em ordem crescente.
        // Obrigatório utilização de for para apresentar em ordem crescente.
		
		int[] numeros = new int[5];
		var aux = 0;
		
		for (var i = 0; i < numeros.Length; i++)
		{
			var numeroLetra = true;
			while (numeroLetra == true)
			{
				try
				{			
			Console.Write("Numero: ");
			numeros[i] = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					
					numeroLetra = false;
					
		         }
				catch (Exception ex)
				{
					Console.Clear();
					numeroLetra = true;
					Console.Write("Digite um valor válido.");
				}
			}
			
		}
		
		
		for (var i = 0; i < numeros.Length; i++)
		{
			for (var j = 0; j < numeros.Length; j++)
			{
				if (numeros[i] < numeros[j])
				{
					aux = numeros[i];
					numeros[i] = numeros[j];
					numeros[j] = aux;
				}
			}
		}
		
		for (var i = 0; i < numeros.Length; i++)
		{
			Console.WriteLine(numeros[i]);
		}
  }
 }
}
