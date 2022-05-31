using Entra21.ExerciciosOrientacaoObjetos.Exercicio05;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio05
{
    public class BoletimTests
    {
        [Fact]

        public void Validar_Calculor_Media_Materias()
        {
            Boletim boletim = new Boletim();

            var notasMateria = 8;

            var mediaMateria = 0;

            for (int i = 0; i < 4; i++)
            {
                mediaMateria = mediaMateria + notasMateria;
            }

            mediaMateria = mediaMateria / 4;

            mediaMateria.Should().Be(8);
        }

        [Fact]

        public void Validar_Nao_Ficou_Exame()
        {
            var validarEmExame = false;

            var media1 = 8.0;
            var media2 = 8.0;
            var media3 = 8.0;
            var media4 = 8.0;

            var quantidadeMateriasAbaixoMedia = 0;

            if (media1 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (media2 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (media3 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (media4 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }

            if (quantidadeMateriasAbaixoMedia > 3)
            {
                validarEmExame = true;
            }

            validarEmExame.Should().Be(false);
        }

        [Fact]

        public void Validar_Ficou_Exame()
        {
            var validarEmExame = false;

            var media1 = 0.0;
            var media2 = 0.0;
            var media3 = 0.0;
            var media4 = 0.0;

            var quantidadeMateriasAbaixoMedia = 0;

            if (media1 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (media2 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (media3 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (media4 < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }

            if (quantidadeMateriasAbaixoMedia > 3)
            {
                validarEmExame = true;
            }

            validarEmExame.Should().Be(true);
        }


    }
}
