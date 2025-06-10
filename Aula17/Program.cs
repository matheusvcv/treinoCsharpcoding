using System.Runtime.CompilerServices;

namespace Aula18;

public class Program
{
    public static void Main()
    {
        string separator = "~~''''~~''''~~''''~~''''~~~''''~~~''''~~";

        Console.WriteLine(separator);

        List<string> lordes = new List<string>()
        {
            "Stark",
            "Lannister",
            "Tully",
        };

        Console.WriteLine(lordes[0]);

        Console.WriteLine(separator);

        foreach (string lorde in lordes)
        {
            Console.WriteLine(lorde);
        }

        Console.WriteLine(separator);

        lordes.Add("Tyrel");
        lordes.Add("Martel");

        foreach (string lorde in lordes)
        {
            Console.WriteLine(lorde);
        }

        Console.WriteLine(separator);

        lordes.Remove("Lannister");
        lordes.Remove("Arryn");

        foreach (String lorde in lordes)
        {
            Console.WriteLine(lorde);
        }

        Console.WriteLine(separator);

        Console.WriteLine(lordes.Count);

        Console.WriteLine(lordes[3]);

        Console.WriteLine(separator);

        lordes[1] = "Blackwood";

        foreach (String lorde in lordes)
        {
            Console.WriteLine(lorde);
        }

        Console.WriteLine(separator);

        lordes.Clear();
       
        foreach (string lorde in lordes)
        {
            Console.WriteLine(lorde);
        }

        Console.WriteLine(separator);
    }
}