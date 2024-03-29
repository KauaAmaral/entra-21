﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosForTry
{
    internal class Exercicio06
    {
        public void Executar()
        {
            // O comitê da seleção brasileira de futebol deseja obter algumas estatísticas dos
            // jogadores, para visualizar melhor o desempenho de seus atletas.
            // Para tal deve - se solicitar as seguintes informações abaixo:
            // ➔ Nome;
            // ➔ Idade;
            // ➔ Peso;
            // ➔ Sexo;
            // ➔ Altura;
            // ➔ Quantidade de gols marcados;
            // ➔ Quantidade de cartões amarelos recebidos;
            // ➔ Quantidade de cartões vermelhos recebidos;
            // Lembrando que um time de futebol terá 22 jogadores.
            // Ao final deve - se apresentar as seguintes estatísticas:
            // ➔ O jogador com o menor peso;
            // ➔ O jogador com a maior altura;
            // ➔ O jogador com o maior nome;
            // ➔ A quantidade de jogadores do sexo F
            // ➔ A quantidade de jogadores do sexo M
            // ➔ O jogador com a menor quantidade de cartões amarelos recebidos;
            // ➔ O jogador com o menor nome;
            // ➔ O jogador com o maior peso;
            // ➔ O jogador com a maior quantidade de cartões vermelhos recebidos;
            // ➔ O jogador com a maior quantidade de cartões amarelos recebidos;
            // ➔ O jogador com a menor quantidade de cartões vermelhos recebidos.

            var jogadorMenorNome = "                                                  ";
            string jogadorMenorPeso = "", jogadorMaiorPeso = "", jogadorMaiorAltura = "", jogadorMaiorNome = "", jogadorMenorAltura = "", jogadorMaisAmarelos = "";
            string jogadorMenosAmarelos = "", jogadorMaisVermehlos = "", jogadorMenosVermehlos = "";

            int jogadoresF = 0, jogadoresM = 0, quantidadeMaisAmarelos = -2000, quantidadeMenosAmarelos = 2000, quantidadeMaislVermelhos = -2000, quantidadeMenosVermelhos = 2000;

            double maiorPeso = -2000, menorPeso = 2000, maiorAltura = -2000, menorAltura = 2000;

            for (var i = 0; i < 3; i++)
            {
                // Pedindo informções

                var nome = "";
                while ((nome.Length < 3) || (nome.Length > 50))
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine().Trim().ToLower();
                    Console.Clear();

                    if ((nome.Length < 3) || (nome.Length > 50))
                    {
                        Console.WriteLine("Mínimo 3 Letra, Máximo 50 Letra.");
                    }
                }

                var idade = 0;
                while (idade < 6)
                {
                    try
                    {
                        Console.Write("Idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (idade < 6)
                        {
                            Console.WriteLine("Apenas acima de 6 anos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite uma idade váida.");
                    }
                }

                var peso = 0.0;
                while (peso < 15)
                {
                    try
                    {
                        Console.Write("Peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (peso < 15)
                        {
                            Console.WriteLine("Apenas acima de 15kg.");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um peso válido.");
                    }
                }

                var sexo = "";
                while ((sexo != "f") && (sexo != "feminino") && (sexo != "m") && (sexo != "masculino"))
                {
                    Console.Write("Sexo (M) ou (F): ");
                    sexo = Console.ReadLine().ToLower().Trim();
                    Console.Clear();

                    if ((sexo != "f") && (sexo != "feminino") && (sexo != "m") && (sexo != "masculino"))
                    {
                        Console.WriteLine("Digite um dos sexos sugeridos.");
                    }
                }

                var altura = 0.0;
                while (altura < 1.30)
                {
                    try
                    {
                        Console.Write("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        if (altura < 1.30)
                        {
                            Console.WriteLine("Apenas acima de 1,30m.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite uma altura válida.");
                    }
                }
                var quantidadeGolsMarcados = -1;
                while (quantidadeGolsMarcados < 0)
                {
                    try
                    {
                        Console.Write("Quantidade de gols marcados: ");
                        quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (quantidadeGolsMarcados < 0)
                        {
                            Console.WriteLine("Digite um valor válido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um valor válido.");
                    }
                }

                var quantidadeAmarelosRecebidos = -1;
                while (quantidadeAmarelosRecebidos < 0)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões amarelos recebidos: ");
                        quantidadeAmarelosRecebidos = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (quantidadeAmarelosRecebidos < 0)
                        {
                            Console.WriteLine("Digite um valor válido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um valor válido.");
                    }
                }

                var quantidadeVermelhosRecebidos = -1;
                while (quantidadeVermelhosRecebidos < 0)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões vermelhos reebidos: ");
                        quantidadeVermelhosRecebidos = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (quantidadeVermelhosRecebidos < 0)
                        {
                            Console.WriteLine("Digite um valor válido.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um valor válido.");
                    }
                }

                // Menor e Maior nome

                if (nome.Length > jogadorMaiorNome.Length)
                {
                    jogadorMaiorNome = nome;
                }

                if (nome.Length < jogadorMenorNome.Length)
                {
                    jogadorMenorNome = nome;
                }

                // Menor e maior peso 

                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    jogadorMaiorPeso = nome;
                }

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    jogadorMenorPeso = nome;
                }

                // maior e menor altura

                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    jogadorMaiorAltura = nome;
                }

                if (altura < menorAltura)
                {
                    menorAltura = altura;
                    jogadorMenorAltura = nome;
                }

                // quantidade de cada sexo

                if ((sexo == "feminino") || (sexo == "f"))
                {
                    jogadoresF = jogadoresF + 1;
                }
                else if ((sexo == "masculino") || (sexo == "m"))
                {
                    jogadoresM = jogadoresM + 1;
                }

                // Quantidade maior e menor amarelos e vermelhos

                // Amarelos
                if (quantidadeAmarelosRecebidos > quantidadeMaisAmarelos)
                {
                    quantidadeMaisAmarelos = quantidadeAmarelosRecebidos;
                    jogadorMaisAmarelos = nome;
                }

                if (quantidadeAmarelosRecebidos < quantidadeMenosAmarelos)
                {
                    quantidadeMenosAmarelos = quantidadeAmarelosRecebidos;
                    jogadorMenosAmarelos = nome;
                }
                // Vermelhos
                if (quantidadeVermelhosRecebidos > quantidadeMaislVermelhos)
                {
                    quantidadeMaislVermelhos = quantidadeVermelhosRecebidos;
                    jogadorMaisVermehlos = nome;
                }

                if (quantidadeVermelhosRecebidos < quantidadeMenosVermelhos)
                {
                    quantidadeMenosVermelhos = quantidadeVermelhosRecebidos;
                    jogadorMenosVermehlos = nome;
                }
                Console.Clear();
            }

            Console.WriteLine("Jogador com o maior nome: " + jogadorMaiorNome +
                    "" +
                    "\nJogador com o menor nome: " + jogadorMenorNome +
                    "" +
                    "\nJogador com maior peso: " + jogadorMaiorPeso +
                    "" +
                    "\nJogador com o menor peso: " + jogadorMenorPeso +
                    "" +
                    "\nJogador com a maior altura: " + jogadorMaiorAltura +
                    "" +
                    "\nJogador com a menor altura: " + jogadorMenorAltura +
                    "" +
                    "\nJogador com mais amarelos: " + jogadorMaisAmarelos +
                    "" +
                    "\nJogador com menos amarelos: " + jogadorMenosAmarelos +
                    "" +
                    "\nJogador com mais vermelhos: " + jogadorMaisVermehlos +
                    "" +
                    "\nJogador com menos vermelhos: " + jogadorMenosVermehlos +
                    "" +
                    "\nQuantidade de jogadores do sexo M: " + jogadoresM +
                    "" +
                    "\nQuantidade de jogadoras do sexo F: " + jogadoresF +
                    "");
        }
    }
}
