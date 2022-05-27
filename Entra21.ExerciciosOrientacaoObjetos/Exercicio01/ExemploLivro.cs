using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            var livro = new Livro();
            livro.Autor = "Klebin Sena";
            livro.Titulo = "C Sharp";
            livro.CodigoIsbn = "1234567899";
            livro.IdiomaOriginal = "Português";
            livro.DataLancamento = new DateTime(2014, 04, 10);
            livro.QuantidadePaginas = 198;
            livro.Releituras = 0;
            livro.QuantidadePaginasLidas = 120;
            
            Console.WriteLine($@"{livro.ApresentarTituloAutor()}
Quantidade de páginas para ler: {livro.ApresentarQuantidadePaginasParaLer()}
Quantidade de páginas lidas no total: {livro.ApresentarQuantidadePaginasLidasNoTotal()}");
        }
    }
}

