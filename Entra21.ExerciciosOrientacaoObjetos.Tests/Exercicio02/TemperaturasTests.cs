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

            var temperaturaFinal = (temperatura.Temperatura - 32) * 1.8;

            calcularFahrenheitParaCelsius.Should().Be(temperaturaFinal);
        }

        public void Validar_Calcular_Kelvin_Para_Celsius()
        {
            Temperaturas temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "kelvin";
            temperatura.TemperaturaDeDestino = "celsius";
            temperatura.Temperatura = 300;

            var calcularKelvinParaCelsius = temperatura.CalcularKelvinParaCelsius();

            var temperaturaFinal = temperatura.Temperatura - 273.15;

            calcularKelvinParaCelsius.Should().Be(temperaturaFinal);
        }

        public void Validar_Calcular_Celsius_Para_Kelvin()
        {
            Temperaturas temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "celsius";
            temperatura.TemperaturaDeDestino = "kelvin";
            temperatura.Temperatura = 300;

            var CalcularCelsiusParaKelvin = temperatura.CalcularCelsiusParaKelvin();

            var temperaturaFinal = temperatura.Temperatura + 273.15;

            CalcularCelsiusParaKelvin.Should().Be(temperaturaFinal);
        }

        public void Validar_Calcular_Fahrenheit_Para_Kelvin()
        {
            Temperaturas temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "fahrenheit";
            temperatura.TemperaturaDeDestino = "kelvin";
            temperatura.Temperatura = 300;
            
            var calcularFahrenheitParaKelvin = temperatura.CalcularFahrenheitParaKelvin();

            var temperaturaFinal = (temperatura.Temperatura - 32) * 5 / 9 + 273.15;

            calcularFahrenheitParaKelvin.Should().Be(temperaturaFinal);
        }

        public void Validar_Calcular_Kelvin_Para_Fahrenheit()
        {
            Temperaturas temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "kelvin";
            temperatura.TemperaturaDeDestino = "fahrenheit";
            temperatura.Temperatura = 300;

            var calcularKelvinParaFahrenheit = temperatura.CalcularKelvinParaFahrenheit();

            var temperaturaFinal = (temperatura.Temperatura - 273.15) * 5 / 9 + 32;

            calcularKelvinParaFahrenheit.Should().Be(temperaturaFinal);
        }

        public void Validar_Calcular_CelsiusPara_Fahrenheit()
        {
            Temperaturas temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "celsius";
            temperatura.TemperaturaDeDestino = "fahrenheit";
            temperatura.Temperatura = 300;

            var calcularCelsiusParaFahrenheit = temperatura.CalcularCelsiusParaFahrenheit();

            var temperaturaFinal = temperatura.Temperatura * 1.8 + 32;
        }

    }
}
