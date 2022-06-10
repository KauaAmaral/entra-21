namespace Entra21.ExerciciosListObjetos.Exercicio01
{
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            var codigo = 0;

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    Cadastrar();
                }
                else if (codigo == 2)
                {
                    Editar();
                }
                else if (codigo == 3)
                {
                    Apagar();
                }
                else if (codigo == 4)
                {
                    ApresentarTriangulos();
                }
                else if (codigo == 5)
                {
                    ApresentarTriangulo();
                }
                Console.WriteLine(@"

Aperte qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu: 
1- Cadastrar
2- Editar
3- Apagar
4- Listar Triangulos
5- Apresentar produto desejado
6- Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Digite um menu válido:");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.Write("Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var adicionar = trianguloServico.Adicionar(lado1, lado2, lado3);

            if (adicionar == false)
            {
                Console.Write("Não forma um triangulo!");
            }
            else
            {
                Console.Write("Triangulo cadastrado com sucesso!");
            }
        }
        private void Editar()
        {
            ApresentarTriangulos();

            Console.Write("Digite o codigo do triangulo que deseja editar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 1: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lado 1: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var editar = trianguloServico.Editar(codigo, lado1, lado2, lado3);

            if (editar == false)
            {
                Console.Write("Codigo não encontrado!");
            }
            else
            {
                Console.Write("Triangulo editado com sucesso!");
            }

        }
        private void Apagar()
        {
            ApresentarTriangulos();

            Console.Write("Digite o codigo do triangulo que deseja apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = trianguloServico.Apagar(codigo);

            if (registroApagado == true)
            {
                Console.Write("Registro removido co sucesso!");
            }
            else
            {
                Console.Write("Nenhum triangulo com o código informado!");
            }
        }
        private void ApresentarTriangulos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.Write("Nenhum triangulos cadastrado.");

                return;
            }

            Console.WriteLine("Lista de triangulos.");

            for (var i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($@"
Código: {trianguloAtual.Codigo}
Lado1: {trianguloAtual.Lado1}
Lado2: {trianguloAtual.Lado2}
Lado3: {trianguloAtual.Lado3}
");
            }
        }
        private void ApresentarTriangulo()
        {
            Console.Write("Digite o código do triangulo a ser mostrado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine("Produto não cadastrado.");

                return;
            }

            Console.Clear();

            Console.WriteLine($@"Código: {triangulo.Codigo}
Lado1: {triangulo.Lado1}
Lado2: {triangulo.Lado2}
Lado3: {triangulo.Lado3}");
        }







    }
}
