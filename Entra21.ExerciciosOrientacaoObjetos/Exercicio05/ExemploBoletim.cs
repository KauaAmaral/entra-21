using ConsoleTables;
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
                boletim.NotasMatematica[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Português: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasPortugues[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Física: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasFisica[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Química: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasQuimica[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Geografia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasGeografia[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas História: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasHistoria[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Filosofia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasFilosofia[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Sociologia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasSociologia[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Biologia: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasBiologia[i] = 8;
            }
            Console.Clear();

            Console.WriteLine("Notas Educação Fisica: ");

            for (int i = 0; i < 4; i++)
            {
                boletim.NotasEducacaoFisica[i] = 8;
            }
            Console.Clear();

            boletim.QuantidadeDiasLetivos = 200;

            boletim.QuantidadePresencas = 186;

            //var apresentarBoletim = new ConsoleTable("Matéria", "Nota 1", "Nota 2", "Nota 3", "Nota 4");
            //apresentarBoletim.AddRow("Matemática", boletim.NotasMatematica[1], boletim.NotasMatematica[2], boletim.NotasMatematica[3], boletim.NotasMatematica[4])
            //     .AddRow("Português", boletim.NotasPortugues[1], boletim.NotasPortugues[2], boletim.NotasPortugues[3], boletim.NotasPortugues[4])
            //     .AddRow("Física", boletim.NotasFisica[1], boletim.NotasFisica[2], boletim.NotasFisica[3], boletim.NotasFisica[4])
            //     .AddRow("Química", boletim.NotasQuimica[1], boletim.NotasQuimica[2], boletim.NotasQuimica[3], boletim.NotasQuimica[4])
            //     .AddRow("Geografia", boletim.NotasGeografia[1], boletim.NotasGeografia[2], boletim.NotasGeografia[3], boletim.NotasGeografia[4])
            //     .AddRow("Hitória", boletim.NotasHistoria[1], boletim.NotasHistoria[2], boletim.NotasHistoria[3], boletim.NotasHistoria[4])
            //     .AddRow("Filosofia", boletim.NotasFilosofia[1], boletim.NotasFilosofia[2], boletim.NotasFilosofia[3], boletim.NotasFilosofia[4])
            //     .AddRow("Sociologia", boletim.NotasSociologia[1], boletim.NotasSociologia[2], boletim.NotasSociologia[3], boletim.NotasSociologia[4])
            //     .AddRow("Biologia", boletim.NotasBiologia[1], boletim.NotasBiologia[2], boletim.NotasBiologia[3], boletim.NotasBiologia[4])
            //     .AddRow("Educação Fisica", boletim.NotasEducacaoFisica[1], boletim.NotasEducacaoFisica[2], boletim.NotasEducacaoFisica[3], boletim.NotasEducacaoFisica[4])
            //     .AddRow("Percentual de presença", "", "", "", "", boletim.Calcular_Percentual_Presenca())
            //     .AddRow("Exame", "", "", "", "", boletim.Validar_Em_Exame())
            //     .AddRow("Aprovado", "", "", "", "", boletim.Validar_Aprovado());
                
            //apresentarBoletim.Write();
        }
    }
}
