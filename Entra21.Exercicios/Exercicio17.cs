using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            // Faça um temporizador começando com 23:59:59 até 00:00:00.
            // Exemplo:
            // 23:59:59
            // 23:59:58
            // 23:59:57
            // ………...
            // 23:59:00
            // 23:58:59
            // …………
            // 23:00:01
            // 23:00:00
            // 22:59:59
            // …………
            // 00:00:02
            // 00:00:01
            // 00:00:00

            int horas = 23, minutos = 59, segundos = 59;

            while (horas > -1)
            {
                while (minutos > -1)
                {
                    while (segundos > -1)
                    {
                        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
                        segundos = segundos - 1;
                    }
                    minutos = minutos - 1;
                    segundos = 59;
                }
                horas = horas - 1;
                minutos = 59;
            }


        }
    }
}
