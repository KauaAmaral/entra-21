using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio03
{
    public  class ExemploConversorAscii
    {
        public void Executar()
        {
            var conversorAscii = new ConversorAscii();
            Console.Write("Digite uma letra: ");
            conversorAscii.Caracter = Console.ReadLine().Trim();
            Console.Clear();

            Console.WriteLine($@"Conversor Ascii de: {conversorAscii.Caracter} = {conversorAscii.ObterCodigoAscii()}");
        }
    }
}
