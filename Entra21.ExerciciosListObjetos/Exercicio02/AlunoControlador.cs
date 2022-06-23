namespace Entra21.ExerciciosListObjetos.Exercicio02
{
    internal class AlunoControlador
    {
        private AlunoServico alunoServico = new AlunoServico();

        public void GerenciarMenu()
        {
            var codigoMenu = 0;

            while (codigoMenu != 13)
            {
                Console.Clear();

                codigoMenu = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigoMenu == 1)
                {
                    Cadastrar();
                }
                else if (codigoMenu == 2)
                {
                    EditarCadastro();
                }
                else if (codigoMenu == 3)
                {
                    Apagar();
                }
                else if (codigoMenu == 4)
                {
                    EditarNotas();
                }
                else if (codigoMenu == 5)
                {
                    ApresentarTodosAlunos();
                }
                else if (codigoMenu == 6)
                {
                    ApresentarNomeTodosAlunos();
                }
                else if (codigoMenu == 7)
                {
                    ApresentarAprovados();
                }
                else if (codigoMenu == 8)
                {
                    ApresentarReprovados();
                }
                else if (codigoMenu == 9)
                {
                    ApresentarEmExame();
                }
                else if (codigoMenu == 10)
                {
                    ApresentarMediaAluno();
                }
                else if (codigoMenu == 11)
                {
                    ApresentarStatusAlunos();
                }
                else if (codigoMenu == 12)
                {
                    ApresentarMediaIdades();
                }
                Console.WriteLine(@"

Aperte qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
        }
        private void ApresentarTodosAlunos()
        {
            var alunos = alunoServico.ObterTodosAlunos();

            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");

                return;
            }

            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine($@"Nome: {alunos[i].Nome}
Idade: {alunos[i].Idade}
Código da Matricula: {alunos[i].CodigoMatricula}
Materia Favorita: {alunos[i].MateriaFavorita}
Nota 1: {alunos[i].Nota1}
Nota 2: {alunos[i].Nota2}
Nota 3: {alunos[i].Nota3}");
            }
        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"Menu:
1- Cadastrar
2- Editar cadastro do aluno
3- Apagar
4- Ediar notas do aluno
5- Listar todos alunos
6- Listar nome de todos alunos
7- Listar aprovados
8- Listar reprovados
9- Listar em exame
10 - Apresentar media do aluno
11- Apresentar status do aluno
12- Apresentar media das idades

13- Sair");

            int codigoMenu = SolicitarCodigoMenu();
            return codigoMenu;
        }
        private int SolicitarCodigoMenu()
        {
            var codigoMenu = 0;

            while (codigoMenu < 1 || codigoMenu > 13)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigoMenu = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Digite um código válido:");
                }
            }
            return codigoMenu;
        }
        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine().Trim().ToLower();

            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Código da matricula: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Matéria Favorita: ");
            var materiaFavorita = Console.ReadLine().Trim().ToLower();

            Console.Write("Nota 1: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            alunoServico.AdicionarAluno(nome, idade, codigoMatricula, materiaFavorita, nota1, nota2, nota3);
        }
        private void EditarCadastro()
        {
            ApresentarTodosAlunos();

            Console.Write("Matricula do aluno desejado: ");
            var matriculaAluno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            var nome = Console.ReadLine().Trim().ToLower();

            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Código da matricula: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Matéria Favorita: ");
            var materiaFavorita = Console.ReadLine().Trim().ToLower();

            var alterou = alunoServico.EditarDadosCadastrais(nome, idade, codigoMatricula, materiaFavorita);

            if (alterou == false)
            {
                Console.WriteLine("Matricula não existe.");
                return;
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso.");
            }
        }
        private void EditarNotas()
        {
            ApresentarTodosAlunos();

            Console.Write("Matricula do aluno desejado: ");
            var matriculaAluno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Novo código da matricula: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nota 1: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());

            var alterou = alunoServico.EditarNotasAlunos(codigoMatricula, nota1, nota2, nota3);

            if (alterou == false)
            {
                Console.WriteLine("Matricula não existe.");
                return;
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso.");
            }
        }
        private void Apagar()
        {
            ApresentarTodosAlunos();

            Console.Write("Nome do aluno desejado: ");
            var nome = Console.ReadLine();

            var alunoApagado = alunoServico.RemoverAluno(nome);

            if (alunoApagado == true)
            {
                Console.WriteLine("Aluno removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Nenhum aluno registrado com esse nome.");
                return;
            }
        }
        private void ApresentarNomeTodosAlunos()
        {
            var alunos = alunoServico.ObterTodosAlunos();
            var nomeAlunos = alunoServico.ObterNomes();

            if (alunos.Count() == 0)
            {
                Console.Write("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine(@"Nomes dos alunos:
");

            for (var i = 0; i < alunos.Count(); i++)
            {
                Console.WriteLine(nomeAlunos[i]);
            }
        }
        private void ApresentarAprovados()
        {
            var alunos = alunoServico.ObterTodosAlunos();
            var aprovados = alunoServico.ObterAprovados();

            if (alunos.Count == 0)
            {
                Console.Write("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine(@"Lista de alunos aprovados:
");

            for (var i = 0; i < alunos.Count(); i++)
            {
                Console.WriteLine(aprovados[i]);
            }
        }
        private void ApresentarReprovados()
        {
            var alunos = alunoServico.ObterTodosAlunos();
            var reprovados = alunoServico.ObterReprovados();

            if (alunos.Count == 0)
            {
                Console.Write("Nenhum aluno cadastrado.");
                return;
            }
            else if (reprovados.Count == 0)
            {
                Console.Write("Nenhum aluno reprovado.");
                return;
            }

            Console.WriteLine(@"Lista de alunos reprovados:
");

            for (int i = 0; i < alunos.Count(); i++)
            {
                Console.WriteLine(reprovados[i]);
            }
        }
        private void ApresentarEmExame()
        {
            var alunos = alunoServico.ObterTodosAlunos();
            var emExame = alunoServico.ObterReprovados();

            if (alunos.Count == 0)
            {
                Console.Write("Nenhum aluno cadastrado.");
                return;
            }
            else if (emExame.Count == 0)
            {
                Console.Write("Nenhum aluno em exame.");
                return;
            }

            Console.WriteLine(@"Lista de alunos em exame:
");

            for (int i = 0; i < alunos.Count(); i++)
            {
                Console.WriteLine(emExame[i]);
            }
        }
        private void ApresentarMediaIdades()
        {
            var alunos = alunoServico.ObterTodosAlunos();
            var mediaIdades = alunoServico.ObterMediaIdades();

            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine(@$"Media de idades: {mediaIdades}");
        }
        private void ApresentarMediaAluno()
        {
            ApresentarTodosAlunos();

            Console.Write("Matricula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            var verificarSeExiste = alunoServico.ObterCodigoMatricula(codigoMatricula);

            var mediaAluno = alunoServico.ObterMediaPorCodigoMatricula(codigoMatricula);

            if (verificarSeExiste == null)
            {
                Console.WriteLine("Matricula não existe.");
                return;
            }

            Console.WriteLine(@$"Media: {mediaAluno}");
        }
        private void ApresentarStatusAlunos()
        {
            ApresentarTodosAlunos();

            Console.Write("Matricula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            var verificarSeExiste = alunoServico.ObterCodigoMatricula(codigoMatricula);

            var statusAluno = alunoServico.ObterStatusPorCodigoMatricula(codigoMatricula);

            if (verificarSeExiste == null)
            {
                Console.WriteLine("Matricula não existe.");
                return;
            }

            Console.WriteLine(@$"Status: {statusAluno}");
        }
    }
}

