using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio07
    {
        public void Executar()
        {
            // Solicite a altura de 4 animais, apresente ao final a altura do animal com a menor altura.

            double[] alturas = new double[4];
            var menorAltura = double.MaxValue;

            for (int i = 0; i < alturas.Length; i++)
            {
                var alturaIgual0 = true;

                while (alturaIgual0 == true)
                {
                    try
                    {
                        Console.Write("Altura do animal: ");
                        alturas[i] = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        alturaIgual0 = false;

                        if (alturas[i] <= 0)
                        {
                            Console.WriteLine("Maior que 0.");
                            alturaIgual0 = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite uma altura válida.");
                        alturaIgual0 = true;
                    }
                }

                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }
            Console.Write("Altura do menor animal: " + menorAltura);
        }
    }
}
