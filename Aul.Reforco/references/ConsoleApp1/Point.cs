
namespace ConsoleApp1
{
    internal struct Point
    {

        // serve como caixa ou seja, ele cria uma copia caso um receba o outro como exemplo x = y.  
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

    }
}
