using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio04
{
    public class Farmacia
    {
        // Criar uma classe chamada Farmácia com as seguintes propriedades:
        // ● Razão social
        // ● CNPJ
        // ● Nome produto 1
        // ● Preço produto 1
        // ● Categoria produto 1
        // ● Nome produto 2
        // ● Preço produto 2
        // ● Categoria produto 2
        // ● Nome produto 3
        // ● Preço produto 3
        // ● Categoria produto 3

        // Criar métodos:
        // ● Apresentar total do pedido
        // ● Apresentar total do pedido por categoria de produto

        // Exemplo:
        // ○ Antiinflamatório total 15,78
        // ○ Antibiótico total 32.50
        // ● Apresentar quantidade por categoria
        // ● Apresentar nome do produto mais caro
        // ● Apresentar nome e categoria do produto mais barato.
        // Obs.: Criar classe ExercicioFarmacia e testes unitários validando os métodos acima.
        // Obs.: Pode utilizar vetor se desejar.

        public string RazaoSocial, Cnpj;
        public string[] NomeProduto = new string[3];
        public string[] Categoria = new string[3];
        public double[] PrecoProduto = new double[3];
        public string[] CategoriaProduto = new string[3];

        public string ApresentarTotalDoPedido()
        {
            var apresentarTotalDoPedido = PrecoProduto[0] + PrecoProduto[1] + PrecoProduto[2];

            return "Valor total da compra: R$" + apresentarTotalDoPedido;
        }

        public string ApresentarTotalDoPedidoPorCategoriaDeProduto()
        {
            double[] valorCategoria = new double[3];

            for (int i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == Categoria[0])
                {
                    valorCategoria[0] = valorCategoria[0] + PrecoProduto[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == Categoria[1])
                {
                    valorCategoria[1] = valorCategoria[1] + PrecoProduto[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == Categoria[2])
                {
                    valorCategoria[2] = valorCategoria[2] + PrecoProduto[i];
                }
            }

            return "Valor total de: " + Categoria[0] + ": R$" + valorCategoria[0] +
                "\nValor total de: " + Categoria[1] + ": R$" + valorCategoria[1] +
                "\nValor total de: " + Categoria[2] + ": R$" + valorCategoria[2];
        }

        public string ApresentarQuantidadePorCategoria()
        {
            double[] quantidadeCategoria = new double[3];

            for (int i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == Categoria[0])
                {
                    quantidadeCategoria[0] = quantidadeCategoria[0] + PrecoProduto[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == Categoria[1])
                {
                    quantidadeCategoria[1] = quantidadeCategoria[1] + PrecoProduto[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CategoriaProduto[i] == Categoria[2])
                {
                    quantidadeCategoria[2] = quantidadeCategoria[2] + PrecoProduto[i];
                }
            }

            return "Quantidade total de: " + Categoria[0] + ": " + quantidadeCategoria[0] +
                "\nQuantidade total de: " + Categoria[1] + ": " + quantidadeCategoria[1] +
                "\nQuantidade total de: " + Categoria[2] + ": " + quantidadeCategoria[2];
        }

        public string ApresentarNomeProdutoMaisCaro()
        {
            double produtoMaisCaro = double.MinValue;
            string nomeProdutoMaisCaro = "";
            
            for (int i = 0; i < 3; i++)
            {
                if (PrecoProduto[i] > produtoMaisCaro)
                {
                    produtoMaisCaro = PrecoProduto[i];
                    nomeProdutoMaisCaro = NomeProduto[i];
                }
            }
            
            return "Nome do produto mais caro: " + nomeProdutoMaisCaro;
        }
        
        public string ApresentarNomeCategoriaProdutoMaisBarato()
        {
            double produtoMaisBarato = double.MaxValue;
            string nomeProdutoMaisBarato = "";
            string categoriaProdutoMaisBarato = "";
            
            for (int i = 0; i < 3; i++)
            {
                if (PrecoProduto[i] < produtoMaisBarato)
                {
                    produtoMaisBarato = PrecoProduto[i];
                    nomeProdutoMaisBarato = NomeProduto[i];
                    categoriaProdutoMaisBarato = CategoriaProduto[i];
                }
            }
            
            return "Nome do produto mais barato: " + nomeProdutoMaisBarato +
                "\nCategoria do produto mais barato: " + categoriaProdutoMaisBarato;
        }

    }
}
