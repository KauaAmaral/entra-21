namespace Entra21.ExerciciosListObjetos.Exercicio02
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public AlunoStatus Status;

        public double CalcularMedia()
        {
            var calcularMedia =( Nota1 + Nota2 + Nota3) / 3;

            return calcularMedia;
        }

        public AlunoStatus ObterStatus()
        {
            if (CalcularMedia() > 7)
            {
                return AlunoStatus.Aprovado;
            }
            else if (CalcularMedia() >= 5 && CalcularMedia() < 7)
            {
                return AlunoStatus.EmExame;
            }
            else
            {
                return AlunoStatus.Reprovado;
            }
        }
    }
}
