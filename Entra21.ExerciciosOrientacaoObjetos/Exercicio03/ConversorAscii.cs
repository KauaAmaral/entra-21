using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio03
{
    public class ConversorAscii
    {
        // Criar uma classe chamada ConversorAscii
        // ● Caracter
        // Criar métodos:
        // ● Obter código ascii do caracter.Levar em consideração que pode ser em caixa
        // alta ou caixa baixa.
        // Obs.: É obrigatório fazer os ifs para descobrir o código ascii.

        // https://www.unitpedia.com/static/929d4e201cee26a3dd2546e10619a529/73c85/ascii.png

        public string Caracter;

        public int ObterCodigoAscii()
        {
            var obterCodigoAscii = 0;

            if (Caracter.StartsWith("a"))
            {
                obterCodigoAscii = 97;
            }
            else if (Caracter.StartsWith("b"))
            {
                obterCodigoAscii = 98;
            }
            else if (Caracter.StartsWith("c"))
            {
                obterCodigoAscii = 99;
            }
            else if (Caracter.StartsWith("d"))
            {
                obterCodigoAscii = 100;
            }


            return obterCodigoAscii;
        }

    }
}
