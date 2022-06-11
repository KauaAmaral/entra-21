namespace Entra21.ExemplosListObjetos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        // Armazenar o código do proximo produto
        private int codigoAtual = 1;

        // Encapsulamento + tipoRetorno + nomeMetodo(Parametro)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Iniciar um objeto da classe Produto
            Produto produto = new Produto();

            // Atribuir valor para as Propriedades com os dados passados como parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            // Adicionar 1 no código atual para quando criar um novo produto o produto conter outro codigo
            codigoAtual = codigoAtual + 1;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            // Obtem o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            // Verificar senão foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso pq não existe produto com o codigo dos parametros
                return false;
            }

            // Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retorna verdadeiro pq foi possivel alterar o produto
            return true;
        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                // Resgatando de uma lista de tipos primitivo
                // int numero = numeros[i];

                // Resgatando de uma lista de objetos
                Produto produto = produtos[i];

                if (produto.Codigo == codigo)
                {
                    // Posso remover o indive do objeto desejado
                    // produtos.RemoveAt(i);

                    // Posso remover com o obejeto desejado
                    produtos.Remove(produto);

                    // Retorna true pq o produto com o codigo desejado foi removido da lista
                    return true;
                }
            }
            // Retorna false pq não foi encontrado produto com o codigo desejado, ou seja, nenhum elemneto foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto
            // filtrando por código
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verificar se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorna o produto encontrado
                    return produtoAtual;
                }
            }

            // Retorna null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }

        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            //Percorre a lista de produtos para obter o produto com o menor preço unitario
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtem o produto atual da lista que esta sendo percorrida
                Produto produto = produtos[i];

                // Verificar se o produto atual possui o menor preço unitario
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    // Armazena o preco unitario, pois é o menor preco unitario até o momento
                    menorPrecoUnitario = produto.PrecoUnitario;

                    // Armazena o produto para posteriormente saber qual é o produto com o menor preco unitario
                    produtoMenorPrecoUnitario = produto;
                }
            }
            return produtoMenorPrecoUnitario;
        }

        public List<double> ObterTodosPrecos()
        {
            // Criar lista de precos totais
            var precos = new List<double>();

            // Percorrer todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtem o produto atual da lista de produtos
                var produto = produtos[i];

                // Adicioar o preco total na lista de precos
                precos.Add(produto.CalcularPrecoTotal());
            }
            return precos;
        }

        public List<double> ObterPrecosTotaisFiltradosPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            // Criar uma lsita de precos totais
            var precos = new List<double>();

            // Percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtem o produto atual da lista de produtos
                var produto = produtos[i];

                // Verificar se a localizacao do produto atual é a localizacao passada no parametro
                if (produto.Localizacao == localizacao)
                {
                    // Adicionar o preco total do produto atual que foi filtrado por localizacao
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }

        public List<double> ObterPrecosTotaisDoArmazem()
        {
            // Criar um lista de precos totais
            var precos = new List<double>();

            // percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obtem o produto atual da lista de produtos
                var produto = produtos[i];

                // Verificar se a localizacao do produto atual e armazem
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    // Adiciona o preco total do produto atual que foi filtrado por armazem
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }

        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;

            // percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {

                // Obtem o produto atual da lista de produtos
                var produto = produtos[i];

                // Adiciona o preco total do produto na variavel soma de precos totais
                somaPrecosTotais += produto.CalcularPrecoTotal();
            }
            // Calcular a media de acordo com a quantidade de produtos
            var media = somaPrecosTotais / produtos.Count;

            return media;
        }


    }
}
