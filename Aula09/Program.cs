namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores Lógicos=====");

        Console.WriteLine("Digite um número: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite um número outra vez: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        int result1 = valor1 % 2;
        int result2 = valor2 % 2;

        if (result1 == 0 && result2 == 0)
        {
            Console.WriteLine("Os dois números são par!");
        }
        else
        {
            Console.WriteLine("Um dos números não é par!");
        }

        if (result1 == 0 || result2 == 0)
        {
            Console.WriteLine("Pelo menos um dos números é par!");
        }
        else
        {
            Console.WriteLine("Nenhum dos números é par!");
        }

        if (result1 == 0)
        {
            bool valorPar = true;
            if(!valorPar)
            {
                Console.WriteLine("PS: O primeiro número digitado não é par!");
            }
        }

    }
}