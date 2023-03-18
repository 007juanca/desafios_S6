namespace desafio4_S6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo miRectangulo = new Rectangulo(4.0, 6.0);

            Console.WriteLine(miRectangulo.Largo + "x" + miRectangulo.Alto);
            Console.WriteLine("La superficie frontal es: " + miRectangulo.SuperficieFrontal);
        }
    }
}