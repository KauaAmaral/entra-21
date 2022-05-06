using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            // Solicite o nome, valor e a quantidade de produtos, enquanto o nome for diferente de sair,
            // ao final deve - se aplicar ao valor total da compra um desconto de 5 %.

            double somaTodosProdutos = 0, valorTotalDesconto = 0, somaValor = 0, desconto = 0;
            string nome = "", resposta = "";

            while (nome != "fim")
            {
                Console.WriteLine("Nome Produto:");

                nome = Console.ReadLine().Trim().ToLower();

                while (nome != "fim")
                {
                    Console.WriteLine("Valor do produto: ");
                    double valor = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    somaValor = valor * quantidade;
                    somaTodosProdutos = somaTodosProdutos + somaValor;
                    desconto = somaTodosProdutos * 0.05;
                    valorTotalDesconto = somaTodosProdutos - desconto;

                    Console.WriteLine("Nome do produto:");
                    nome = Console.ReadLine().Trim().ToLower();
                }



            }
            Console.Clear();
            Console.WriteLine("Valor total da compra com 5% de desconto: R$" + valorTotalDesconto);


        }
    }
}
