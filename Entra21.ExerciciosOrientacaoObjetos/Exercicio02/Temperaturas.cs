using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperaturas
    {
        // Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
        // ● temperatura de origem
        // ● Temperatura de destino
        // ● Temperatura

        // Criar métodos:
        // ● Calcular Celsius
        // ● Calcular Kelvin
        // ● Calcular Fahrenheit

        public string TemperaturaDeOrigem, TemperaturaDeDestino;
        public double Temperatura;

        public double CalcularFahrenheitParaCelsius()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (Temperatura - 32) * 1.8;

            return temperaturaFinal;
        }

        public double CalcularKelvinParaCelsius()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = Temperatura - 273.15;

            return temperaturaFinal;
        }

        public double CalcularCelsiusParaKelvin()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = Temperatura + 273.15;

            return temperaturaFinal;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (Temperatura - 32) * 5 / 9 + 273.15;

            return temperaturaFinal;
        }

        public double CalcularKelvinParaFahrenheit()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = (Temperatura - 273.15) * 5 / 9 + 32;

            return temperaturaFinal;
        }

        public double CalcularCelsiusParaFahrenheit()
        {
            var temperaturaFinal = 0.0;

            temperaturaFinal = Temperatura * 1.8 + 32;

            return temperaturaFinal;
        }

        public double ApresentarTemperaturaConvertida()
        {
            var apresentarTemperaturaConvertida = 0.0;

            if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "celsius")
            {
                apresentarTemperaturaConvertida = CalcularFahrenheitParaCelsius();
            }
            else if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "celsius")
            {
                apresentarTemperaturaConvertida = CalcularKelvinParaCelsius();
            }
            else if (TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "kelvin")
            {
                apresentarTemperaturaConvertida = CalcularCelsiusParaKelvin();
            }
            else if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "kelvin")
            {
                apresentarTemperaturaConvertida = CalcularFahrenheitParaKelvin();
            }
            else if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "fahrenheit")
            {
                apresentarTemperaturaConvertida = CalcularKelvinParaFahrenheit();
            }
            else if (TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "fahrenheit")
            {
                apresentarTemperaturaConvertida = CalcularCelsiusParaFahrenheit();
            }

            return apresentarTemperaturaConvertida;
        }
    }
}
