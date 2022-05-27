using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        //Crie uma classe chamada Livro para armazenar as seguintes informações
        //● Título
        //● Autor
        //● Código ISBN
        //● Idioma original
        //● Data de lançamento
        //● Quantidade de páginas
        //● Quantidade de páginas lidas
        //● Quantidade de releituras

        //Crie os seguintes métodos:
        //● ApresentarTituloAutor
        //● ApresentarQuantidadePaginasParaLer
        //● ApresentarQuantidadePaginasLidasNoTotal

        //Criar testes unitários validando os métodos criados acima

        public string Titulo, Autor, CodigoIsbn, IdiomaOriginal;
        public int QuantidadePaginas, QuantidadePaginasLidas, Releituras;
        public DateTime DataLancamento;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine(@$"Título: {Titulo}
Altor: {Autor}");
        }

        public int ApresentarQuantidadePaginasParaLer()
        {
            var quantidadePaginasParaLer = QuantidadePaginas - QuantidadePaginasLidas;

            return quantidadePaginasParaLer;
        }

        public int ApresentarQuantidadePaginasLidasNoTotal()
        {
            var quantidadePaginasLidasNoTotal = QuantidadePaginasLidas * Releituras;

            if (Releituras <= 0)
                quantidadePaginasLidasNoTotal = QuantidadePaginas;

            return quantidadePaginasLidasNoTotal;
        }





    }
}
