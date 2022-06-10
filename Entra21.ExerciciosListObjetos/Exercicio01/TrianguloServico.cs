namespace Entra21.ExerciciosListObjetos.Exercicio01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            if (triangulo.ValidarTriangulo() == false)
            {
                return false;
            }

            triangulo.Codigo = codigoAtual;
            codigoAtual = codigoAtual + 1;

            triangulos.Add(triangulo);

            return true;
        }

        public bool Editar(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if (trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return true;
        }

        public bool Apagar(int codigoParaApagar)
        {
            Triangulo trianguloParaApagar = ObterPorCodigo(codigoParaApagar);

            if (trianguloParaApagar == null)
            {
                return false;
            }

            triangulos.Remove(trianguloParaApagar);

            return true;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }
    }
}
