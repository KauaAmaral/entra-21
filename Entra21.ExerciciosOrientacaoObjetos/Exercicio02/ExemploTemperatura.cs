using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            var temperatura = new Temperaturas();
            temperatura.TemperaturaDeOrigem = "celsius";
            temperatura.TemperaturaDeDestino = "fahrenheit";
            temperatura.Temperatura = 42.30;

            Console.WriteLine(temperatura.ApresentarTemperaturaConvertida());
        }
    }
}
