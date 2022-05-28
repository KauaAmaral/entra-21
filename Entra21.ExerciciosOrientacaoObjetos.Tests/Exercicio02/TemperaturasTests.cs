using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExerciciosOrientacaoObjetos.Tests.Exercicio02
{
    public class TemperaturasTests
    {
        [Fact]

        public void Validar_Calcular_Fahrenheit_Para_Celsius()
        {
            Temperaturas temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "fahrenheit";
            temperatura.TemperaturaDeDestino = "celsius";
            temperatura.Temperatura = 300;

            var calcularFahrenheitParaCelsius = temperatura.CalcularFahrenheitParaCelsius();

            var resultadoFinal = (temperatura.Temperatura - 32) * 1.8;

            calcularFahrenheitParaCelsius.Should().Be(resultadoFinal);
        }
    }
}
