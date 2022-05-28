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
            else if (Caracter.StartsWith("e"))
            {
                obterCodigoAscii = 101;
            }
            else if (Caracter.StartsWith("f"))
            {
                obterCodigoAscii = 102;
            }
            else if (Caracter.StartsWith("g"))
            {
                obterCodigoAscii = 103;
            }
            else if (Caracter.StartsWith("h"))
            {
                obterCodigoAscii = 104;
            }
            else if (Caracter.StartsWith("i"))
            {
                obterCodigoAscii = 105;
            }
            else if (Caracter.StartsWith("j"))
            {
                obterCodigoAscii = 106;
            }
            else if (Caracter.StartsWith("k"))
            {
                obterCodigoAscii = 107;
            }
            else if (Caracter.StartsWith("l"))
            {
                obterCodigoAscii = 108;
            }
            else if (Caracter.StartsWith("m"))
            {
                obterCodigoAscii = 109;
            }
            else if (Caracter.StartsWith("n"))
            {
                obterCodigoAscii = 110;
            }
            else if (Caracter.StartsWith("o"))
            {
                obterCodigoAscii = 111;
            }
            else if (Caracter.StartsWith("p"))
            {
                obterCodigoAscii = 112;
            }
            else if (Caracter.StartsWith("q"))
            {
                obterCodigoAscii = 113;
            }
            else if (Caracter.StartsWith("r"))
            {
                obterCodigoAscii = 114;
            }
            else if (Caracter.StartsWith("s"))
            {
                obterCodigoAscii = 115;
            }
            else if (Caracter.StartsWith("t"))
            {
                obterCodigoAscii = 116;
            }
            else if (Caracter.StartsWith("u"))
            {
                obterCodigoAscii = 117;
            }
            else if (Caracter.StartsWith("v"))
            {
                obterCodigoAscii = 118;
            }
            else if (Caracter.StartsWith("w"))
            {
                obterCodigoAscii = 119;
            }
            else if (Caracter.StartsWith("x"))
            {
                obterCodigoAscii = 120;
            }
            else if (Caracter.StartsWith("y"))
            {
                obterCodigoAscii = 121;
            }
            else if (Caracter.StartsWith("z"))
            {
                obterCodigoAscii = 122;
            }
            else if (Caracter.StartsWith("A"))
            {
                obterCodigoAscii = 65;
            }
            else if (Caracter.StartsWith("B"))
            {
                obterCodigoAscii = 66;
            }
            else if (Caracter.StartsWith("C"))
            {
                obterCodigoAscii = 67;
            }
            else if (Caracter.StartsWith("D"))
            {
                obterCodigoAscii = 68;
            }
            else if (Caracter.StartsWith("E"))
            {
                obterCodigoAscii = 69;
            }
            else if (Caracter.StartsWith("F"))
            {
                obterCodigoAscii = 70;
            }
            else if (Caracter.StartsWith("G"))
            {
                obterCodigoAscii = 71;
            }
            else if (Caracter.StartsWith("H"))
            {
                obterCodigoAscii = 72;
            }
            else if (Caracter.StartsWith("I"))
            {
                obterCodigoAscii = 73;
            }
            else if (Caracter.StartsWith("J"))
            {
                obterCodigoAscii = 74;
            }
            else if (Caracter.StartsWith("K"))
            {
                obterCodigoAscii = 75;
            }
            else if (Caracter.StartsWith("L"))
            {
                obterCodigoAscii = 76;
            }
            else if (Caracter.StartsWith("M"))
            {
                obterCodigoAscii = 77;
            }
            else if (Caracter.StartsWith("N"))
            {
                obterCodigoAscii = 78;
            }
            else if (Caracter.StartsWith("O"))
            {
                obterCodigoAscii = 79;
            }
            else if (Caracter.StartsWith("P"))
            {
                obterCodigoAscii = 80;
            }
            else if (Caracter.StartsWith("Q"))
            {
                obterCodigoAscii = 81;
            }
            else if (Caracter.StartsWith("R"))
            {
                obterCodigoAscii = 82;
            }
            else if (Caracter.StartsWith("S"))
            {
                obterCodigoAscii = 83;
            }
            else if (Caracter.StartsWith("T"))
            {
                obterCodigoAscii = 84;
            }
            else if (Caracter.StartsWith("U"))
            {
                obterCodigoAscii = 85;
            }
            else if (Caracter.StartsWith("V"))
            {
                obterCodigoAscii = 86;
            }
            else if (Caracter.StartsWith("W"))
            {
                obterCodigoAscii = 87;
            }
            else if (Caracter.StartsWith("X"))
            {
                obterCodigoAscii = 88;
            }
            else if (Caracter.StartsWith("Y"))
            {
                obterCodigoAscii = 89;
            }
            else if (Caracter.StartsWith("Z"))
            {
                obterCodigoAscii = 90;
            }

            return obterCodigoAscii;
        }
    }
}
