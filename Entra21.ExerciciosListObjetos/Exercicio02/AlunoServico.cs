namespace Entra21.ExerciciosListObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void AdicionarAluno(string nome, int idade, string materiaFavorita, int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.CodigoMatricula = codigoMatricula;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            alunos.Add(aluno);
        }


    }
}
