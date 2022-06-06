using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Entra21.ExerciciosList
{
    public class Exercicio01
    {
        public void Executar()
        {

            // Criar uma classe que irá armazenar os melhores filmes de todos os tempos.
            // a.Adicionar o filme "Dragon Ball Evollution";
            // b.Adicionar o filme "Titanic";
            // c.Adicionar o filme "Lanterna verde";
            // d.Listar os filmes armazenados na lista;
            // e.Adicionar o filme "";
            // f.Alterar o filme "Dragon Ball Evollution" para "Dragon Ball Super: Broly”;
            // g.Remover filme "Lanterna verde";
            // h.Verificar se a lista contém o filme "Lanterna verde" apresentando para o
            // usuário se está ou não cadastrado;
            // i.Adicionar o filme "Quarteto fantástico";
            // j.Listar os filmes armazenados na lista;
            // k.Alterar o filme "Titanic" para “Titanic 2”;
            // l.Listar os filmes armazenados na lista;
            // m.Verificar se filme "A Lagoa Azul” existe na lista, informando para o usuário

            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evollution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna Verde");

            Console.WriteLine($@"Filmes:
{filmes[0]}
{filmes[1]}
{filmes[2]}");

            filmes.Add("");

            filmes[0] = "Dragon Ball Super: Broly";

            filmes.RemoveAt(2);

            var contemNaListaLanternaVerde = filmes.Contains("Lanterna Verde");
            Console.WriteLine($@"
Contém na lista o filme Lanterna Verde: {contemNaListaLanternaVerde}");

            filmes.Add("Quarteto Fantástico");

            Console.WriteLine($@"
Filmes:
{filmes[0]}
{filmes[1]}
{filmes[2]}
{filmes[3]}");

            filmes[1] = "Tatanic 2";

            Console.WriteLine($@"
Filmes:
{filmes[0]}
{filmes[1]}
{filmes[2]}
{filmes[3]}");
        }
    }
}
