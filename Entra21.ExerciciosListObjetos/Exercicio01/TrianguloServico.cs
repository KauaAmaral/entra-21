namespace Entra21.ExerciciosListObjetos.Exercicio01
{
    internal class TrianguloServico
    {
        private LinkedList<Triangulo> triangulos = new LinkedList<Triangulo>();

        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            triangulo.Codigo = codigoAtual;
            codigoAtual = codigoAtual + 1;

            if (triangulo.ValidarTriangulo() == true)
            {

                triangulos.AddLast(triangulo);

                return true;
            }
            return false;
        }

        public void Editar()
        {

        }
    }
}
