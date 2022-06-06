using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosList
{
    public class Exercicio02
    {
        public void Executar()
        {
            // Criar uma classe que irá armazenar os conteúdos passados até o momento:
            // a.Adicionar o conteúdo "Como fazer um bolo"
            // b.Listar conteúdos
            // c.Alterar conteúdo "Como fazer um bolo" para "Algoritmos onde vivem? Do que
            // se alimentam”
            // d.Adicionar o conteúdo "variáveis"
            // e.Adicionar o conteúdo "Mais para frente"
            // f.Alterar o conteúdo “Mais para frente" por "If com E"
            // g.Adicionar o conteúdo "If com OU”;
            // h.Adicionar o conteúdo "While";
            // i.Adicionar o conteúdo "For"
            // j.Listar conteúdos
            // k.Adicionar o conteúdo "Vetor"
            // l.Adicionar o conteúdo "Vetor”
            // m.Apagar os conteúdos "Vetor"
            // n.Adicionar o conteúdo "Vetor"
            // o.Alterar o conteúdo"Vetor" para "Vetor com For um amor na minha vida”
            // p.Listar conteúdos
            // q.Adicionar o conteúdo "Classe propriedades e métodos"
            // r.Listar conteúdos

            List<string> conteudosPassadosAteOMomento = new List<string>();

            conteudosPassadosAteOMomento.Add("Como fazer um bolo");

            Console.WriteLine($@"
Conteudos:
{conteudosPassadosAteOMomento[0]}");

            conteudosPassadosAteOMomento[0] = "Algoritmos onde vivem? Do que se alimentam";

            conteudosPassadosAteOMomento.Add("Variáveis");
            conteudosPassadosAteOMomento.Add("Mais para frente");

            conteudosPassadosAteOMomento[2] = "if com E";

            conteudosPassadosAteOMomento.Add("if com OU");
            conteudosPassadosAteOMomento.Add("while");
            conteudosPassadosAteOMomento.Add("for");

            Console.WriteLine($@"
Conteudos:
{conteudosPassadosAteOMomento[0]}
{conteudosPassadosAteOMomento[1]}
{conteudosPassadosAteOMomento[2]}
{conteudosPassadosAteOMomento[3]}
{conteudosPassadosAteOMomento[4]}
{conteudosPassadosAteOMomento[5]}");

            conteudosPassadosAteOMomento.Add("Vetor");
            conteudosPassadosAteOMomento.Add("Vetor");

            conteudosPassadosAteOMomento.RemoveAt(6);

            conteudosPassadosAteOMomento[6] = "Vetor com For um amor na minha vida";

            Console.WriteLine($@"
Conteudos:
{conteudosPassadosAteOMomento[0]}
{conteudosPassadosAteOMomento[1]}
{conteudosPassadosAteOMomento[2]}
{conteudosPassadosAteOMomento[3]}
{conteudosPassadosAteOMomento[4]}
{conteudosPassadosAteOMomento[5]}
{conteudosPassadosAteOMomento[6]}");

            conteudosPassadosAteOMomento.Add("Classe propriedades e métodos");

            Console.WriteLine($@"
Conteudos:
{conteudosPassadosAteOMomento[0]}
{conteudosPassadosAteOMomento[1]}
{conteudosPassadosAteOMomento[2]}
{conteudosPassadosAteOMomento[3]}
{conteudosPassadosAteOMomento[4]}
{conteudosPassadosAteOMomento[5]}
{conteudosPassadosAteOMomento[6]}
{conteudosPassadosAteOMomento[7]}");
        }
    }
}
