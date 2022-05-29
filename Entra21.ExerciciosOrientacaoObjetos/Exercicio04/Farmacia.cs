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

        public string RazaoSocial, Cnpj, NomeProduto1, CategoriaProduto1, NomeProduto2, CategoriaProduto2, NomeProduto3, CategoriaProduto3, Categoria1, Categoria2, Categoria3;
        public double PrecoProduto1, PrecoProduto2, PrecoProduto3;

        public double ApresentarTotalDoPedido()
        {
            var apresentarTotalDoPedido = PrecoProduto1 + PrecoProduto2 + PrecoProduto3;

            return apresentarTotalDoPedido;
        }

        public double ApresentarTotalDoPedidoPorCategoriaDeProduto()
        {
            var apresentarTotalDoPedidoPorCategoriaDeProdutos = 0.0;

            return apresentarTotalDoPedidoPorCategoriaDeProdutos;
        }


    }
}
