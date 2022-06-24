using Newtonsoft.Json;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        // Contrutor: mais para frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();

            LerArquivo();
        }

        // Metodo adicionar recebe como parametro o objeto do endereco completo do form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            // Percorre a lista de enderecos afim de encontrar o endereco que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                // Obtem o endereco da lista de enderecos
                var endereco = enderecos[i];

                // Verifica se o codigo do endereco percorrido e o mesmo do endereco que deve ser alterado
                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    // Atualuza campos do endereco encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();

                    return;
                }
            }
        }

        public void Apagar(int codigoParaApagar)
        {
            // Percorre a lista de enderecos afim de encontrar o endereco que deve ser removido
            for (var i = 0;i < enderecos.Count; i++)
            {
                // Obtem o endereco percorrido
                var endereco = enderecos[i];

                if (endereco.Codigo == codigoParaApagar)
                {
                    // Remove o endereco encontrado da lista de enderecos
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }

        // Metodo que permite listar todos os enderecos
        public List<Endereco> ObterTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            // Percorrer a lista de enderecos afim de encontrar o endereco com o codigo desejado
            for (var i = 0; i < enderecos.Count; i++)
            {
                // Obtem o endereco percorrido
                var endereco = enderecos[i];

                // Verificar se o endereco contem o codigo desejado
                if (endereco.Codigo == codigo)
                    return endereco;
            }
            // Retornar null pois nao encontrou o endereco com o codigo desejado
            return null;
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecosEmJson);
        }

        public void LerArquivo()
        {
            // Verificar se o endereco nao existe
            if (File.Exists("enderecos.json") == false)
                return;

            // Ler o arquivo JSON e converter para uma lista de objetos de enderecos
            var enderecosEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);
        }
    }
}
