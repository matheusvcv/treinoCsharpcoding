﻿namespace Aula14a;

public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,6}");
            }

            Console.WriteLine();
        }
    }
}