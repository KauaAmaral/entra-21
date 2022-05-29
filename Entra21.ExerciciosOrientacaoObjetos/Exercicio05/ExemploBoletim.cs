using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio05
{
    public class ExemploBoletim
    {
        public void Executar()
        {
            var boletim = new Boletim();

            Console.WriteLine("Notas Matemática: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasMatematica[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Português: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasPortugues[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Física: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasFisica[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Química: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasQuimica[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Geografia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasGeografia[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas História: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasHistoria[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Filosofia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasFilosofia[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Sociologia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasSociologia[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Biologia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasBiologia[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("Notas Educação Fisica: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasEducacaoFisica[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            boletim.QuantidadeDiasLetivos = 200;

            boletim.QuantidadePresencas = 186;

            Console.WriteLine(boletim.Apresentar_Boletim);
        }
    }
}
