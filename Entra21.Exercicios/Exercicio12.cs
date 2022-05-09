﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio12
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

            int numeroPedido = 0;
            int quantidadeBolo = 0;
            int quantidadeDoce = 0;
            int quantidadeSanduiche = 0;
            int quantidadepizza = 0;
            int quantidadePedidos = 0;

            while (numeroPedido != 16)
            {
                while (numeroPedido != 16)
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

                    // Quantidade de produtos consumidos

                    numeroPedido = Convert.ToInt32(Console.ReadLine());

                    quantidadePedidos = quantidadePedidos + 1;

                    // quantidade de bolos, doces, sanduíches, pizzas

                    if ((numeroPedido == 1) || (numeroPedido == 2) || (numeroPedido == 3) || (numeroPedido == 4) || (numeroPedido == 5))
                    {
                        quantidadeBolo = quantidadeBolo + 1;
                    }
                    else if ((numeroPedido == 6) || (numeroPedido == 7))
                    {
                        quantidadeDoce = quantidadeDoce + 1;
                    }
                    else if ((numeroPedido == 8) || (numeroPedido == 9) || (numeroPedido == 10) || (numeroPedido == 11))
                    {
                        quantidadeSanduiche = quantidadeSanduiche + 1;
                    }
                    else if ((numeroPedido == 12) || (numeroPedido == 13) || (numeroPedido == 14) || (numeroPedido == 15))
                    {
                        quantidadepizza = quantidadepizza + 1;
                    }

                    // media dos produtos







                }
            }





        }
    }
}
