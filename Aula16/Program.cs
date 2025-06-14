using System.Runtime.InteropServices;

namespace Aula16;

public class Program
{
    public static void Main()
    {
        string separator = "-----------------------";
        string[] fruits = { "Apple", "Banana", "Cashew", "Mango" };

        Console.WriteLine(fruits[0]);
        Console.WriteLine(separator);
        Console.WriteLine(fruits[3]);
        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        Console.WriteLine("\nO número de índices é: " + fruits.Length);

        fruits[0] = "grape";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        int[] inteiros = new int[3];

        Console.WriteLine("\nO número de índices é: " + inteiros.Length);

        foreach (int inteiro in inteiros)
        {
            Console.WriteLine(inteiro);
        }

        inteiros[0] = 32;
        inteiros[1] = 54;
        inteiros[2] = 1980;

        Console.WriteLine(separator);



    }
}