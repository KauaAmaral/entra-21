using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio03
{
    public class ConversorAsciiTests
    {
        [Fact]

        public void Validar_Conversor_Ascii()
        {
            ConversorAscii conversorAscii = new ConversorAscii();
            conversorAscii.Caracter = "a";

            var obterCodigoAscii = conversorAscii.ObterCodigoAscii();

            var resultadoFinal = 0;

            if (conversorAscii.Caracter.StartsWith("a"))
            {
                resultadoFinal = 97;
            }

            obterCodigoAscii.Should().Be(resultadoFinal);
        }
    }
}
