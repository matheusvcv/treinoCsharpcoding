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
    }
}