using Entra21.BancoDadosExercicio01.Ado.Net.Models;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Services
{
    internal interface ICidadeService
    {
        void Cadastrar(Cidade cidade);
        List<Cidade> ObterTodos();
        void Ediatr(Cidade cidade);
        Cidade ObterPorId(int id);
        void Apagar(int id);
    }
}