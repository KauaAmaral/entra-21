using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            //Solicite nomes ao usuário até que o mesmo digite fim para o nome.

            string nome = "";

            while (nome != "fim")
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                Console.Clear();
            }


        }
    }
}
