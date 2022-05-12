using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio14
    {
        public void Executar()
        {
            // Solicitar a quantidade de caracteres que serão digitados. Após isto solicitando um
            // caracter por vez e armazenar o texto, no final deve - se apresentar o texto.
            // Exemplo:
            // Quantidade de caracteres digitados:
            // Caracter: a
            // Caracter:
            // Caracter: c
            // Caracter: a
            // Caracter: m
            // Caracter: i
            // Caracter: s
            // Caracter: a
            // Caracter:
            // Caracter: é
            // Caracter:
            // Caracter: a
            // Caracter: m
            // Caracter: a
            // Caracter: r
            // Caracter: e
            // Caracter: l
            // Caracter: a
            // Para solicitar o caracter ao usuário deve-se utilizar char.
            // Ao final apresente o texto contendo os caracteres que o usuário digitou.
            // Exemplo: “A camisa é amarela”

            Console.Write("Qual a quantidade de caracteres que serão digitados? ");
            int quantidadeCaracteres = Convert.ToInt32(Console.ReadLine());

            int indice = 0;
            string caracter = "", todosCaracteres = "";

            while (indice < quantidadeCaracteres)
            {
                Console.Write("Caracter: ");
                caracter = Console.ReadLine();
                todosCaracteres = todosCaracteres + caracter;

                indice = indice + 1;
            }

            Console.Clear();
            Console.WriteLine(todosCaracteres);



        }
    }
}
