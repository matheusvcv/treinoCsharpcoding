namespace Aula03;

public class Program
{
    public static void Main()
    {
        int number = 30;

        number = 20;

        Console.WriteLine("O valor da variável era igual a: " + number);

        number = 10;

        Console.WriteLine("O valor é igual a: " + number);

        const int novoNumber = 1000;

        Console.WriteLine("O valor da constante oe igual a: " + novoNumber);

        var variable = 500;

        var variable2 = "Texto";

        Console.WriteLine(variable + "  " + "variable2");

        dynamic var = 20;

        Console.WriteLine("O valor da Dynamic era :" + var);

        var = "Cachorro";

        Console.WriteLine("O valor da Dynamic agora é :" + var);
    }
}