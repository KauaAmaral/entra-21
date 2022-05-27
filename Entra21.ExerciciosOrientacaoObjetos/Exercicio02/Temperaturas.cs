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

        public double CalcularCelsius()
        {
            var temperaturaFinal = 0.0;

            if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "celsius")
            {
                temperaturaFinal = (Temperatura - 32) * 1.8;
            }
            else if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "celsius")
            {
                temperaturaFinal = Temperatura - 273.15;
            }

            return temperaturaFinal;
        }

        public double CalcularKelvin()
        {
            var temperaturaFinal = 0.0;

            if (TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "kelvin")
            {
                temperaturaFinal = Temperatura + 273.15;
            }
            else if (TemperaturaDeOrigem == "fahrenheit" && TemperaturaDeDestino == "kelvin")
            {
                temperaturaFinal = (Temperatura - 32) * 5 / 9 + 273.15;
            }

            return temperaturaFinal;
        }

        public double CalcularFahreinheit()
        {
            var temperaturaFinal = 0.0;

            if (TemperaturaDeOrigem == "kelvin" && TemperaturaDeDestino == "fahrenheit")
            {
                temperaturaFinal = (Temperatura - 273.15) * 5 / 9 + 32;
            }
            else if (TemperaturaDeOrigem == "celsius" && TemperaturaDeDestino == "fahrenheit")
            {
                temperaturaFinal = Temperatura * 1.8 + 32;
            }

            return temperaturaFinal;
        }
    }
}
