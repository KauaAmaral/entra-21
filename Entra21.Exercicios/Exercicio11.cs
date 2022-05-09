using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            //  Solicite para o usuário dois números. Apresente o seguinte menu e de acordo com a escolha deve
            //  ser apresentado a operação aritmética, isto deve ocorrer até que o mesmo escolha a opção de sair:
            // MENU
            // 1 Somar
            // 2 Subtrair
            // 3 Multiplicar
            // 4 Dividir
            // 5 Sair

            int menu = 0;

            while (menu != 5)
            {
                Console.WriteLine("Escolha dois números:");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                double numero2 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                double soma = numero1 + numero2;
                double subtracao = numero1 - numero2;
                double multiplicacao = numero1 * numero2;
                double divisao = numero1 / numero2;

                Console.WriteLine(@"  Menu

1     Somar
2     Subtrair
3     Multiplicar
4     Dividir
5     Sair");

                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + soma);
                }
                else if (menu == 2)
                {
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + subtracao);
                }
                else if (menu == 3)
                {
                    Console.WriteLine(numero1 + " x " + numero2 + " = " + multiplicacao);
                }
                else if (menu == 4)
                {
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + divisao);
                }
            }





        }
    }
}
