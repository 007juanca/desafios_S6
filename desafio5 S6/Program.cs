namespace desafio5_S6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Caja> cajas = new List<Caja>();
            int cantidadCajas = 0;
            double totalVolumen = 0;

            // Pedir la cantidad de cajas que desea ingresar
            Console.Write("Ingrese la cantidad de cajas: ");
            cantidadCajas = int.Parse(Console.ReadLine());

            // Pedir las medidas de cada caja
            for (int i = 0; i < cantidadCajas; i++)
            {
                Caja caja = new Caja();

                Console.Write("Ingresar el alto de la caja " + (i + 1) + ": ");
                caja.Alto = double.Parse(Console.ReadLine());

                Console.Write("Ingresar el ancho de la caja " + (i + 1) + ": ");
                caja.Ancho = double.Parse(Console.ReadLine());

                Console.Write("Ingresar el largo de la caja " + (i + 1) + ": ");
                caja.Largo = double.Parse(Console.ReadLine());

                cajas.Add(caja);
            }

            // Calcular el volumen de cada caja
            foreach (Caja caja in cajas)
            {
                totalVolumen += caja.CalcularVolumen();
            }

            // Calcular el volumen promedio
            double volumenPromedio = totalVolumen / cantidadCajas;

            // Mostrar el total de volumen y el volumen promedio en la consola
            Console.WriteLine("El volumen total de las cajas es: " + totalVolumen);
            Console.WriteLine("El volumen promedio de las cajas es: " + volumenPromedio);
        }
    
    }
}