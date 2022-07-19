using Entra21.BancoDadosExercicio01.Ado.Net.Models;

namespace Entra21.BancoDadosExercicio01.Ado.Net.Services
{
    internal interface IUnidadeFederativaService
    {
        void Cadastrar(UnidadeFederativa unidadeFederativa);
        List<UnidadeFederativa> ObterTodos();
        void Apagar(int id); 
        UnidadeFederativa ObterPorId(int id);
        void Editar(UnidadeFederativa unidadeFederativa);
    }
}