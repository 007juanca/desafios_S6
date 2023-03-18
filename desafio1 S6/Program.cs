using System;

class Desafio1
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero positivo: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Los números pares del 2 hasta {0} son:", num);

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadLine();
    }
}
