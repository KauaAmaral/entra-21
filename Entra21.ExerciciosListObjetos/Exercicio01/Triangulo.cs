namespace Entra21.ExerciciosListObjetos.Exercicio01
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {


            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return true;
            }
            return false;
        }
    }
}
