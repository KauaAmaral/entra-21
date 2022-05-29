using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio05
{
    public class Boletim
    {
        // Criar uma classe chamada Boletim armazenar:
        // ● Vetor para notas de matemática
        // ● Vetor para notas de português
        // ● Vetor para notas de física
        // ● Vetor para notas de química
        // ● Vetor para notas de geografia
        // ● Vetor para notas de história
        // ● Vetor para notas de filosofia
        // ● Vetor para notas de sociologia
        // ● Vetor para notas de biologia
        // ● Quantidade de dias letivos
        // ● Quantidade de presenças

        // Criar métodos:
        // ● Calcular média de matemática
        // ● Calcular média de português
        // ● ….
        // ● Calcular quantidade de faltas
        // ● Calcular percentual de presença
        // ● Calcular percentual de faltas
        // ● Apresentar boletim(n precisa de teste)
        // ● Validar em exame
        // ● Validar reprovado
        // ● Calcular média geral
        // ● Validar passou de ano
        // Criar testes unitários validando os métodos acima.
        // Criar classe ExemploBoletim

        public double[] NotasMatematica = new double[4];
        public double[] NotasPortugues = new double[4];
        public double[] NotasFisica = new double[4];
        public double[] NotasQuimica = new double[4];
        public double[] NotasGeografia = new double[4];
        public double[] NotasHistoria = new double[4];
        public double[] NotasFilosofia = new double[4];
        public double[] NotasSociologia = new double[4];
        public double[] NotasBiologia = new double[4];
        public double[] NotasEducacaoFisica = new double[4];

        public int QuantidadeDiasLetivos, QuantidadePresencas;

        double mediaMatematica = 0;
        public double Calcular_Media_Matematica()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaMatematica = mediaMatematica + NotasMatematica[i];
            }

            mediaMatematica = mediaMatematica / 4;

            return mediaMatematica;
        }

        double mediaPortugues = 0;
        public double Calcular_Media_Portugues()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaPortugues = mediaPortugues + NotasPortugues[i];
            }

            mediaPortugues = mediaPortugues / 4;

            return mediaPortugues;
        }

        double mediaFisica = 0;
        public double Calcular_Media_Fisica()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaFisica = mediaFisica + NotasFisica[i];
            }

            mediaFisica = mediaFisica / 4;

            return mediaFisica;
        }

        double mediaQuimica = 0;
        public double Calcular_Media_Quimica()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaQuimica = mediaQuimica + NotasQuimica[i];
            }

            mediaQuimica = mediaQuimica / 4;

            return mediaQuimica;
        }

        double mediaGeografia = 0;
        public double Calcular_Media_Geografia()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaGeografia = mediaGeografia + NotasGeografia[i];
            }

            mediaGeografia = mediaGeografia / 4;

            return mediaGeografia;
        }

        double mediaHistoria = 0;
        public double Calcular_Media_Historia()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaHistoria = mediaHistoria + NotasHistoria[i];
            }

            mediaHistoria = mediaHistoria / 4;

            return mediaHistoria;
        }

        double mediaFilosofia = 0;
        public double Calcular_Media_Filosofia()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaFilosofia = mediaFilosofia + NotasFilosofia[i];
            }

            mediaFilosofia = mediaFilosofia / 4;

            return mediaFilosofia;
        }

        double mediaSociologia = 0;
        public double Calcular_Media_Sociologia()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaSociologia = mediaSociologia + NotasSociologia[i];
            }

            mediaSociologia = mediaSociologia / 4;

            return mediaSociologia;
        }

        double mediaBiologia = 0;
        public double Calcular_Media_Biologia()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaBiologia = mediaBiologia + NotasBiologia[i];
            }

            mediaBiologia = mediaBiologia / 4;

            return mediaBiologia;
        }

        double mediaEducacaoFisica = 0;
        public double Calcular_Media_EducacaoFisica()
        {
            for (int i = 0; i < 4; i++)
            {
                mediaEducacaoFisica = mediaEducacaoFisica + NotasEducacaoFisica[i];
            }

            mediaEducacaoFisica = mediaEducacaoFisica / 4;

            return mediaEducacaoFisica;
        }

        double quantidadeFaltas = 0;
        public double Calcular_Quantidade_Faltas()
        {
            quantidadeFaltas = QuantidadeDiasLetivos - QuantidadePresencas;

            return quantidadeFaltas;
        }

        double calcularPercentualFaltas = 0;
        public double Calcular_Percentual_Faltas()
        {
            calcularPercentualFaltas = (quantidadeFaltas / QuantidadeDiasLetivos) * 100;

            return calcularPercentualFaltas;
        }

        public double Calcular_Percentual_Presenca()
        {
            var calcularPercentualPresenca = 0.0;

            calcularPercentualPresenca = calcularPercentualFaltas - 100;

            return calcularPercentualPresenca;
        }

        int quantidadeMateriasAbaixoMedia = 0;
        bool validarEmExame = false;
        public bool Validar_Em_Exame()
        {
            if (mediaMatematica < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaPortugues < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaFisica < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaQuimica < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaGeografia < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaHistoria < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaFilosofia < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaSociologia < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }
            else if (mediaBiologia < 7)
            {
                quantidadeMateriasAbaixoMedia = quantidadeMateriasAbaixoMedia + 1;
            }

            if (quantidadeMateriasAbaixoMedia <= 3)
            {
                validarEmExame = true;
            }

            return validarEmExame;
        }

        bool validarReprovado = false;
        public bool Validar_Reprovado()
        {
            if (quantidadeMateriasAbaixoMedia > 3 || calcularPercentualFaltas > 25)
            {
                validarReprovado = true;
            }

            return validarReprovado;
        }

        public bool Validar_Aprovado()
        {
            var validarAprovado = false;

            if (validarReprovado == false)
            {
                validarAprovado = true;
            }

            return validarAprovado;
        }

        public double Calcular_Media_Geral()
        {
            var calcularMediaGeral = mediaMatematica + mediaPortugues + mediaFisica + mediaQuimica + mediaGeografia + mediaHistoria + mediaFilosofia + mediaSociologia + mediaBiologia + mediaEducacaoFisica;

            calcularMediaGeral = calcularMediaGeral / 10;

            return calcularMediaGeral;
        }

        //public ConsoleTable Apresentar_Boletim()
        //{
        //    var apresentarBoletim = new ConsoleTable("Matéria", "Nota 1", "Nota 2", "Nota 3", "Nota 4", "Média");
        //    apresentarBoletim.AddRow("Matemática",NotasMatematica[1], NotasMatematica[2], NotasMatematica[3], NotasMatematica[4], mediaMatematica)
        //         .AddRow("Português", NotasPortugues[1], NotasPortugues[2], NotasPortugues[3],NotasPortugues[4], mediaPortugues)
        //         .AddRow("Física", NotasFisica[1], NotasFisica[2], NotasFisica[3], NotasFisica[4], mediaFisica)
        //         .AddRow("Química", NotasQuimica[1], NotasQuimica[2], NotasQuimica[3], NotasQuimica[4], mediaQuimica)
        //         .AddRow("Geografia", NotasGeografia[1], NotasGeografia[2], NotasGeografia[3], NotasGeografia[4], mediaGeografia)
        //         .AddRow("Hitória", NotasHistoria[1], NotasHistoria[2], NotasHistoria[3], NotasHistoria[4], mediaHistoria)
        //         .AddRow("Filosofia", NotasFilosofia[1], NotasFilosofia[2], NotasFilosofia[3], NotasFilosofia[4], mediaFilosofia)
        //         .AddRow("Sociologia", NotasSociologia[1], NotasSociologia[2], NotasSociologia[3], NotasSociologia[4], mediaSociologia)
        //         .AddRow("Biologia", NotasBiologia[1], NotasBiologia[2], NotasBiologia[3], NotasBiologia[4], mediaBiologia)
        //         .AddRow("Educação Fisica", NotasEducacaoFisica[1], NotasEducacaoFisica[2], NotasEducacaoFisica[3], NotasEducacaoFisica[4], mediaEducacaoFisica)
        //         .AddRow("Percentual de presença", "", "", "", "", Calcular_Percentual_Presenca())
        //         .AddRow("Exame", "", "", "", "", Validar_Em_Exame())
        //         .AddRow("Aprovado", "", "", "", "", Validar_Aprovado());

        //    return apresentarBoletim;
        //}

    }
}
