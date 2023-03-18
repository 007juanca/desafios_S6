using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresar un número entero positivo: ");
        int num = int.Parse(Console.ReadLine());

        bool esPrimo = true;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("{0} es un número primo", num);
        }
        else
        {
            Console.WriteLine("{0} no es un número primo", num);
        }

        Console.ReadLine();
    }
}
