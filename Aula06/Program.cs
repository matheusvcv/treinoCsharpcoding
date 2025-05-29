namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Descubra se o número é par ou ímpar =====");
        Console.WriteLine("Digite um número: ");

        int numero = Convert.ToInt32(Console.ReadLine());

        int result = numero % 2;

        if (result == 0)
        {
            Console.WriteLine("O número é  par!");
        }
        else
        {
            Console.WriteLine("O número é ímpar!");
        }
    }
}