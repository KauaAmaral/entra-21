using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio04
{
    public class FarmaciaTests
    {
        [Fact]

        public void Validar_Apresentar_Total_Do_Pedido()
        {
            double[] precoProduto = new double[3];
            precoProduto[0] = 8.5;
            precoProduto[1] = 10;
            precoProduto[2] = 8;

            var apresentarTotalDoPedido = precoProduto[0] + precoProduto[1] + precoProduto[2];

            apresentarTotalDoPedido.Should().Be(26.5);
        }

        [Fact]

        public void Validar_Apresentar_Total_Do_Pedido_Por_Categoria_De_Produto()   
        {
            double[] valorCategoria = new double[3];
            string[] categoriaProduto = new string[3];
            string[] categoria = new string[3];
            double[] precoProduto = new double[3];
            string[] nomeProduto = new string[3];

            categoria[0] = "Curativos";
            categoria[1] = "Remedios";
            categoria[2] = "Perfumes";
            nomeProduto[0] = "Bandaid";
            categoriaProduto[0] = categoria[0];
            precoProduto[0] = 4.99;
            nomeProduto[1] = "DorFlex";
            categoriaProduto[1] = categoria[1];
            precoProduto[1] = 12.90;
            nomeProduto[2] = "Paracetamol";
            categoriaProduto[2] = categoria[2];
            precoProduto[2] = 10.89;


            for (int i = 0; i < 3; i++)
            {
                if (categoriaProduto[i] == categoria[0])
                {
                    valorCategoria[0] = valorCategoria[0] + precoProduto[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (categoriaProduto[i] == categoria[1])
                {
                    valorCategoria[1] = valorCategoria[1] + precoProduto[i];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (categoriaProduto[i] == categoria[2])
                {
                    valorCategoria[2] = valorCategoria[2] + precoProduto[i];
                }
            }

            valorCategoria[0].Should().Be(4.99);
            valorCategoria[1].Should().Be(12.90);
            valorCategoria[2].Should().Be(10.89);
        }

        [Fact]

        public void Validar_Apresentar_Quantidade_Por_Categoria()
        {
            string[] categoriaProduto = new string[3];
            string[] categoria = new string[3];
            string[] nomeProduto = new string[3];
            double[] quantidadeCategoria = new double[3];

            categoria[0] = "Curativos";
            categoria[1] = "Remedios";
            categoria[2] = "Perfumes";
            nomeProduto[0] = "Bandaid";
            categoriaProduto[0] = categoria[0];
            nomeProduto[1] = "DorFlex";
            categoriaProduto[1] = categoria[1];
            nomeProduto[2] = "Paracetamol";
            categoriaProduto[2] = categoria[2];

            for (int i = 0; i < 3; i++)
            {
                if (categoriaProduto[i] == categoria[0])
                {
                    quantidadeCategoria[0] = quantidadeCategoria[0] + 1;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (categoriaProduto[i] == categoria[1])
                {
                    quantidadeCategoria[1] = quantidadeCategoria[1] + 1;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (categoriaProduto[i] == categoria[2])
                {
                    quantidadeCategoria[2] = quantidadeCategoria[2] + 1;
                }
            }

            quantidadeCategoria[0].Should().Be(1);
            quantidadeCategoria[1].Should().Be(1);
            quantidadeCategoria[2].Should().Be(1);
        }
    }
}
