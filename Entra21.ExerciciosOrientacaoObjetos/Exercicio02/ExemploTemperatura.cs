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
            temperatura.TemperaturaDeOrigem = "fahrenheit";
            temperatura.TemperaturaDeDestino = "celsius";
            temperatura.Temperatura = 300;

            Console.WriteLine(temperatura.ApresentarTemperaturaConvertida());
        }
    }
}
