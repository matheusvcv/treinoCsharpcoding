namespace Aula11;

public class Program
{
    public static void Main()
    {
        int number = 2;

        switch (number)
        {
            case 1:
                Console.WriteLine("\nO número é 1;");
                break;

            case 2:
                Console.WriteLine("\nOnúmero é 2;");
                break;
        }

        bool BoolValue = true;

        switch (BoolValue)
        {
            case true:
                Console.WriteLine("\nO valor é true;");
                break;

            case false:
                Console.WriteLine("\nO valor é false;");
                break;
        }
    }
}