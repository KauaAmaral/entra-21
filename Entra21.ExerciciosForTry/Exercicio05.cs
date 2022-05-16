using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForTry
{
    internal class Exercicio05
    {
        public void Executar()
        {
            // A padaria do joão necessita armazenar os pedidos dos seus clientes, cada cliente
            // poderá realizar quantos pedidos desejar, porém para que o cliente possa solicitar
            // estes produtos o cardápio deve ser apresentado para ele.
            // Ao final de o cliente solicitar os produtos, deve-se apresentar o total dos pedidos e a
            // quantidade de produtos consumidos.
            // O critério para que não seja mais solicitado o código do produto ao cliente é se o mesmo
            // informar o código 16.

            // 1  Bolos       | Bolo Brigadeiro                             | R$ 29,50
            // 2  Bolos       | Bolo Floresta Negra                         | R$ 2,00
            // 3  Bolos       | Bolo Leite com Nutella                      | R$ 29,23
            // 4  Bolos       | Bolo Mousse de Chocolate                    | R$ 7,10
            // 5  Bolos       | Bolo Nega Maluca                            | R$ 19,33
            // 6  Doces       | Bomba de Creme                              | R$ 17,71
            // 7  Doces       | Bomba de Morango                            | R$ 4,82
            // 8  Sanduíches  | Filé-Mignon com fritas e cheddar            | R$ 21,16
            // 9  Sanduíches  | Hambúrguer com queijos, champignon e rúcula | R$ 12,70
            // 10 Sanduíches  | Provolone com salame                        | R$ 19,70
            // 11 Sanduíches  | Vegetariano de berinjela                    | R$ 28,22
            // 12 Pizzas      | Calabresa                                   | R$ 8,98
            // 13 Pizzas      | Napolitana                                  | R$ 0,42
            // 14 Pizzas      | Peruana                                     | R$ 18,36
            // 15 Pizzas      | Portuguesa                                  | R$ 27,50
            // 16 Sair

            // Ao final apresentar:
            // ● A quantidade de bolos escolhidos;
            // ● A quantidade de doces escolhidos;
            // ● A quantidade de Sanduíches escolhidos;
            // ● A quantidade de pizzas escolhidas;
            // ● A média dos produtos;

            int numeroPedido = 0, quantidadeBolo = 0, quantidadeDoce = 0, quantidadeSanduiche = 0, quantidadepizza = 0, quantidadePedidos = 0;
            var valorTotal = 0.0;

            while (numeroPedido != 16)
            {
                try
                {
                    Console.WriteLine(@"Menu
            1  Bolos       | Bolo Brigadeiro                             | R$ 29,50
            2  Bolos       | Bolo Floresta Negra                         | R$ 2,00
            3  Bolos       | Bolo Leite com Nutella                      | R$ 29,23
            4  Bolos       | Bolo Mousse de Chocolate                    | R$ 7,10
            5  Bolos       | Bolo Nega Maluca                            | R$ 19,33
            6  Doces       | Bomba de Creme                              | R$ 17,71
            7  Doces       | Bomba de Morango                            | R$ 4,82
            8  Sanduíches  | Filé-Mignon com fritas e cheddar            | R$ 21,16
            9  Sanduíches  | Hambúrguer com queijos, champignon e rúcula | R$ 12,70
            10 Sanduíches  | Provolone com salame                        | R$ 19,70
            11 Sanduíches  | Vegetariano de berinjela                    | R$ 28,22
            12 Pizzas      | Calabresa                                   | R$ 8,98
            13 Pizzas      | Napolitana                                  | R$ 0,42
            14 Pizzas      | Peruana                                     | R$ 18,36
            15 Pizzas      | Portuguesa                                  | R$ 27,50

            16 Sair");

                    numeroPedido = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if ((numeroPedido <= 0) || (numeroPedido > 16))
                    {
                        Console.WriteLine(@"Digite apenas números do menu
");
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(@"Digite apenas números do menu.
");
                }

                // Quantidade de produtos consumidos

                if ((numeroPedido > 0) && (numeroPedido < 16))
                {
                    quantidadePedidos = quantidadePedidos + 1;
                }

                // valor total
                // Quantidade de cada categoria

                if (numeroPedido == 1)
                {
                    valorTotal = valorTotal + 29.50;
                    quantidadeBolo = quantidadeBolo + 1;
                }
                else if (numeroPedido == 2)
                {
                    valorTotal = valorTotal + 2;
                    quantidadeBolo = quantidadeBolo + 1;
                }
                else if (numeroPedido == 3)
                {
                    valorTotal = valorTotal + 29.23;
                    quantidadeBolo = quantidadeBolo + 1;
                }
                else if (numeroPedido == 4)
                {
                    valorTotal = valorTotal + 7.10;
                    quantidadeBolo = quantidadeBolo + 1;
                }
                else if (numeroPedido == 5)
                {
                    valorTotal = valorTotal + 19.33;
                    quantidadeBolo = quantidadeBolo + 1;
                }
                else if (numeroPedido == 6)
                {
                    valorTotal = valorTotal + 17.71;
                    quantidadeDoce = quantidadeDoce + 1;
                }
                else if (numeroPedido == 7)
                {
                    valorTotal = valorTotal + 4.82;
                    quantidadeDoce = quantidadeDoce + 1;
                }
                else if (numeroPedido == 8)
                {
                    valorTotal = valorTotal + 21.16;
                    quantidadeSanduiche = quantidadeSanduiche + 1;
                }
                else if (numeroPedido == 9)
                {
                    valorTotal = valorTotal + 12.70;
                    quantidadeSanduiche = quantidadeSanduiche + 1;
                }
                else if (numeroPedido == 10)
                {
                    valorTotal = valorTotal + 19.70;
                    quantidadeSanduiche = quantidadeSanduiche + 1;
                }
                else if (numeroPedido == 11)
                {
                    valorTotal = valorTotal + 28.22;
                    quantidadeSanduiche = quantidadeSanduiche + 1;
                }
                else if (numeroPedido == 12)
                {
                    valorTotal = valorTotal + 8.98;
                    quantidadepizza = quantidadepizza + 1;
                }
                else if (numeroPedido == 13)
                {
                    valorTotal = valorTotal + 0.42;
                    quantidadepizza = quantidadepizza + 1;
                }
                else if (numeroPedido == 14)
                {
                    valorTotal = valorTotal + 18.36;
                    quantidadepizza = quantidadepizza + 1;
                }
                else if (numeroPedido == 15)
                {
                    valorTotal = valorTotal + 27.50;
                    quantidadepizza = quantidadepizza + 1;
                }

            }
            double mediaValor = valorTotal / quantidadePedidos;

            Console.WriteLine("Quantidade de bolos pedido: " + quantidadeBolo +
                "\nQuantidade de doces pedido: " + quantidadeDoce +
                "\nQuantidade de sanduíches pedido: " + quantidadeSanduiche +
                "\nQuantidade de pizzas pedida: " + quantidadepizza +
                "\nQuantidade total de pedidos: " + quantidadePedidos +
                "\nValor total da comanda: R$" + valorTotal +
                "\nMédia do valor total: R$" + mediaValor);

        }
    }
}
