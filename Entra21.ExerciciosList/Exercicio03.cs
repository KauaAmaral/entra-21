using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosList
{
    public class Exercicio03
    {
        public void Executar()
        {
            // 3.Criar uma classe que irá as notas:
            // a.Solicitar a nota 1
            // b.Solicitar a nota 2
            // c.Solicitar a nota 3
            // d.Listar notas
            // e.Apresentar média das notas
            // f.Apresentar status da média

            List<double> notas = new List<double>();

            Console.WriteLine("Nota 1: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine("Nota 2: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("Nota 3: ");
            notas.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine($@"Nota 1: {notas[0]}
Nota 2: {notas[1]}
Nota 3: {notas[2]}");

            var mediaNotas = (notas[0] + notas[1] + notas[2]) / 3;

            Console.WriteLine($@"
Média: {mediaNotas}");
        }
    }
}
