using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            // Solicite o nome, valor, quantidade enquanto a quantidade de produtos for menor que 5.
            // Ao final deve-se aplicar um desconto de R$ 150,00.

            int quantidadeItens = 0, quantidadeProdutos = 0;
            double valor = 0, somaTodosProdutos = 0, valorTotalDesconto = 0, somaValor = 0, desconto = 150;

            while (quantidadeProdutos < 5)
            {
                Console.WriteLine("Quantidade de produtos:");
                quantidadeItens = Convert.ToInt32(Console.ReadLine());

                while (quantidadeProdutos < 5)
                {
                    Console.WriteLine("Nome do Produto:");
                    string nomeProduto = Console.ReadLine().Trim().ToLower();

                    Console.WriteLine("Valor produto:");
                    valor = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Quantidade de produtos:");
                    quantidadeItens = Convert.ToInt32(Console.ReadLine());

                    somaValor = valor * quantidadeItens;
                    somaTodosProdutos = somaTodosProdutos + somaValor;
                    quantidadeProdutos = quantidadeProdutos + 1;

                }



            }
            valorTotalDesconto = somaTodosProdutos - desconto;

            Console.WriteLine("Valor a pagar: R$" + valorTotalDesconto);

        }
    }
}
