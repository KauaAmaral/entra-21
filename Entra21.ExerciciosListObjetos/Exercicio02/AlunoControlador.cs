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
                    //Apagar();
                }
                else if (codigoMenu == 4)
                {
                    //EditarNotas();
                }
                else if (codigoMenu == 5)
                {
                    ApresentarTodosAlunos();
                }
                else if (codigoMenu == 6)
                {
                    //ApresentarNomeTodosAlunos();
                }
                else if (codigoMenu == 7)
                {
                    //ApresentarAprovados();
                }
                else if (codigoMenu == 8)
                {
                    //ApresentarReprovados();
                }
                else if (codigoMenu == 9)
                {
                    //ApresentarEmExame();
                }
                else if (codigoMenu == 10)
                {
                    //ApresentarMediaAluno();
                }
                else if (codigoMenu == 11)
                {
                    //ApresentarStatusAlunos();
                }
                else if (codigoMenu == 12)
                {
                    //ApresentarMediaIdades();
                }
                Console.WriteLine(@"

Aperte qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
        }
        private void ApresentarTodosAlunos()
        {
            Console.Write("Digite a matricula do aluno desejado: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            var aluno = alunoServico.ObterCodigoMatricula(codigoMatricula);

            if (aluno == null)
            {
                Console.WriteLine("Aluno não cadastrado.");

                return;
            }

            Console.Clear();

            Console.WriteLine($@"Nome: {aluno.Nome}
Idade: {aluno.Idade}
Código da Matricula: {aluno.CodigoMatricula}
Materia Favorita: {aluno.MateriaFavorita}
Nota 1: {aluno.Nota1}
Nota 2: {aluno.Nota2}
Nota 3: {aluno.Nota3}");
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
            var nome = Console.ReadLine();

            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Código da matricula: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Matéria Favorita: ");
            var materiaFavorita = Console.ReadLine();

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
            var nome = Console.ReadLine();

            Console.Write("Idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Código da matricula: ");
            var codigoMatricula = Convert.ToInt32(Console.ReadLine());

            Console.Write("Matéria Favorita: ");
            var materiaFavorita = Console.ReadLine();

            var alterou = alunoServico.EditarDadosCadastrais(nome, idade, codigoMatricula, materiaFavorita);

            if (alterou == false)
            {
                Console.WriteLine("Matricula não existe.");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso.");
            }
        }


    }
}
