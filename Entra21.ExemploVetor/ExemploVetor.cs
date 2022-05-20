using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploVetor
{
    internal class ExemploVetor
    {
        public void Executar()
        {
            var caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var linhas = File.ReadAllLines($"{caminho}/nomes.csv");

            int quantidadeRegistrosDoArquivo = linhas.Length - 1;
            Console.Write("Quantidade desejada: ");
            var quantidadeDesejada = Convert.ToInt32(Console.ReadLine()) + quantidadeRegistrosDoArquivo;

            var nomes = new string[quantidadeDesejada];
            var idades = new int[quantidadeDesejada];

            var quantidadeCadastrada = 0;

            for (int i = 1; i < linhas.Length; i++)
            {
                var linha = linhas[i];
                var colunas = linha.Split(";");
                var nome = colunas[0];
                var idade = Convert.ToInt32(colunas[1]);

                nomes[quantidadeCadastrada] = nome;
                idades[quantidadeCadastrada] = idade;

                quantidadeCadastrada = quantidadeCadastrada + 1;
            }

            for (int i = quantidadeCadastrada; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine().Trim();

                while (nomes[i].Length < 5 || nomes[i].Length > 30)
                {
                    Console.WriteLine("Digite um nome com no mínimo 5 caracteres e no máximo 30");
                    Console.Write("Nome: ");
                    nomes[i] = Console.ReadLine().Trim();
                }
                Console.Write("Idade: ");
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.Write("Nomes: ");
            string nomesTexto = "Nomes;Idades;\n";
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"{nomes[i]},");
                nomesTexto = nomesTexto + nomes[i] + ";" + idades[i] + "\n";
            }

            File.WriteAllText($"{caminho}/nomes.csv", nomesTexto);
        }
    }
}
