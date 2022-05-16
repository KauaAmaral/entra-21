using System;
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

            string jogadorMenorPeso = "", jogadorMaiorPeso = "", jogadorMaiorAltura = "", jogadorMaiorNome = "", jogadorMenorNome = "", jogadorMenorAltura = "", jogadorMaisAmarelos = "";
            string jogadorMenosAmarelos = "", jogadorMaisVermehlos = "", jogadorMenosVermehlos = "";

            int jogadoresF = 0, jogadoresM = 0, quantidadeMaisAmarelos = -2000, quantidadeMenosAmarelos = 2000, quantidadeMaislVermelhos = -2000, quantidadeMenosVermelhos = 2000;

            double maiorPeso = -2000, menorPeso = 2000, maiorAltura = -2000, menorAltura = 2000;

            for (var i = 0; i < 3; i++)
            {
                // Pedindo informções

                Console.Write("Nome: ");
                var nome = Console.ReadLine().Trim().ToLower();

                Console.Write("Idade: ");
                var idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Peso: ");
                var peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sexo: ");
                var sexo = Console.ReadLine().ToLower().Trim();

                Console.Write("Altura: ");
                var altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de gols marcados: ");
                var quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões amarelos recebidos: ");
                var quantidadeAmarelosRecebidos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões vermelhos reebidos: ");
                var quantidadeVermelhosRecebidos = Convert.ToInt32(Console.ReadLine());

                // Menor e Maior nome

                if (nome.Length >= jogadorMaiorNome.Length)
                {
                    jogadorMaiorNome = nome;
                }
                else if (nome.Length <= jogadorMaiorNome.Length)
                {
                    jogadorMenorNome = nome;
                }
                else if (jogadorMenorNome.Length <= jogadorMenorNome.Length)
                {
                    jogadorMenorNome = nome;
                }

                // Menor e maior peso 

                if (peso >= maiorPeso)
                {
                    maiorPeso = peso;
                    jogadorMaiorPeso = nome;
                }
                else if (peso < maiorPeso)
                {
                    menorPeso = peso;
                    jogadorMenorPeso = nome;
                }
                else if (menorPeso <= menorPeso)
                {
                    menorPeso = peso;
                    jogadorMenorPeso = nome;
                }

                // maior e menor altura

                if (altura >= maiorAltura)
                {
                    maiorAltura = altura;
                    jogadorMaiorAltura = nome;
                }
                else if (altura < maiorAltura)
                {
                    menorAltura = altura;
                    jogadorMenorAltura = nome;
                }
                else if (menorAltura <= menorAltura)
                {
                    menorAltura = altura;
                    jogadorMenorAltura = nome;
                }

                // quantidade de cada sexo

                if (sexo.StartsWith("f"))
                {
                    jogadoresF = jogadoresF + 1;
                }
                else if (sexo.StartsWith("m"))
                {
                    jogadoresM = jogadoresM + 1;
                }

                // Quantidade maior e menor amarelos e vermelhos

                if (quantidadeAmarelosRecebidos >= quantidadeMaisAmarelos)
                {
                    quantidadeMaisAmarelos = quantidadeAmarelosRecebidos;
                    jogadorMaisAmarelos = nome;
                }
                else if (quantidadeAmarelosRecebidos < quantidadeMaisAmarelos)
                {
                    quantidadeMenosAmarelos = quantidadeAmarelosRecebidos;
                    jogadorMenosAmarelos = nome;
                }
                else if (quantidadeMenosAmarelos < quantidadeMenosAmarelos)
                {
                    quantidadeMenosAmarelos = quantidadeAmarelosRecebidos;
                    jogadorMenosAmarelos = nome;
                }
               
                if (quantidadeVermelhosRecebidos >= quantidadeMaislVermelhos)
                {
                    quantidadeMaislVermelhos = quantidadeVermelhosRecebidos;
                    jogadorMaisVermehlos = nome;
                }
                else if (quantidadeVermelhosRecebidos < quantidadeMaislVermelhos)
                {
                    quantidadeMenosVermelhos = quantidadeVermelhosRecebidos;
                    jogadorMenosVermehlos = nome;
                }
                else if (quantidadeMenosVermelhos < quantidadeMenosVermelhos)
                {
                    quantidadeMenosVermelhos = quantidadeVermelhosRecebidos;
                    jogadorMenosVermehlos = nome;
                }
                Console.Clear();
            }

            Console.WriteLine("Jogador com o maior nome: " + jogadorMaiorNome +
                "" +
                "\nJogador com o menor nome" + jogadorMenorNome +
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
