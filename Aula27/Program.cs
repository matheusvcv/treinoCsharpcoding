using System.Globalization;

namespace Aula27;

public class Program
{
    public static void Main()
    {
        Cake ChocolateCake = new Cake("Morango", "Chocolate", "Coco", 3, "Grande");

        Console.WriteLine(ChocolateCake.Flavor);
        Console.WriteLine(ChocolateCake.Filling);
        Console.WriteLine(ChocolateCake.Coverage);
        Console.WriteLine(ChocolateCake.Layers);
        Console.WriteLine(ChocolateCake.Size);
    }
}