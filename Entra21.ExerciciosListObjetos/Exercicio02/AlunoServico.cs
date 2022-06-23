namespace Entra21.ExerciciosListObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        public void AdicionarAluno(string nome, int idade, int codigoMatricula, string materiaFavorita, double nota1, double nota2, double nota3)
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

        public bool RemoverAluno(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno alunoAtual = alunos[i];

                if (alunoAtual.Nome == nome)
                {
                    alunos.Remove(alunoAtual);
                    return true;
                }
            }
            return false;
        }

        public bool EditarDadosCadastrais(string nome, int idade, int codigoMatricula, string materiaFavorita)
        {
            Aluno dadosCadastraisParaAlterar = ObterCodigoMatricula(codigoMatricula);

            if (dadosCadastraisParaAlterar == null)
            {
                return false;
            }

            dadosCadastraisParaAlterar.Nome = nome;
            dadosCadastraisParaAlterar.Idade = idade;
            dadosCadastraisParaAlterar.CodigoMatricula = codigoMatricula;
            dadosCadastraisParaAlterar.MateriaFavorita = materiaFavorita;
            return true;
        }

        public bool EditarNotasAlunos(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            Aluno notasParaAlterar = ObterCodigoMatricula(codigoMatricula);

            if (notasParaAlterar == null)
            {
                return false;
            }

            notasParaAlterar.CodigoMatricula = codigoMatricula;
            notasParaAlterar.Nota1 = nota1;
            notasParaAlterar.Nota2 = nota2;
            notasParaAlterar.Nota3 = nota3;
            return true;
        }

        public List<string> ObterNomes()
        {
            var nomes = new List<string>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                nomes.Add(aluno.Nome);
            }
            return nomes;
        }

        public List<double> ObterMedias()
        {
            var medias = new List<double>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                medias.Add(aluno.CalcularMedia());
            }
            return medias;
        }

        public List<string> ObterAprovados()
        {
            var aprovados = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if (aluno.Status == AlunoStatus.Aprovado)
                {
                    aprovados.Add(aluno.Nome);
                }
            }
            return aprovados;
        }

        public List<string> ObterEmExame()
        {
            var EmExame = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if (aluno.Status == AlunoStatus.EmExame)
                {
                    EmExame.Add(aluno.Nome);
                }
            }
            return EmExame;
        }

        public List<string> ObterReprovados()
        {
            var reprovados = new List<string>();

            for (var i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if (aluno.Status == AlunoStatus.Reprovado)
                {
                    reprovados.Add(aluno.Nome);
                }
            }
            return reprovados;
        }

        public List<Aluno> ObterTodosAlunos()
        {
            return alunos;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var media = 0.0;

            for (var i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                if (aluno.CodigoMatricula == codigoMatricula)
                {
                    media = aluno.CalcularMedia();
                }
            }
            return media;
        }

        public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
            var alunoStatus = ObterCodigoMatricula(codigoMatricula);
            return alunoStatus.Status;
        }

        public double ObterMediaIdades()
        {
            var somaMedia = 0.0;

            for (int i = 0; i < alunos.Count; i++)
            {
                var aluno = alunos[i];

                somaMedia += aluno.Idade;
            }
            var media = somaMedia / alunos.Count;

            return media;
        }

        public Aluno ObterCodigoMatricula(int codigoMatricula)
        {
            for (var i = 0; i < alunos.Count; i++)
            {
                var alunoAtual = alunos[i];

                if (alunoAtual.CodigoMatricula == codigoMatricula)
                {
                    return alunoAtual;
                }
            }
            return null;
        }
    }
}
