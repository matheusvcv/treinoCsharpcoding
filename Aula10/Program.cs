using System.Linq.Expressions;

namespace Aula10;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Calculadora Simples=====");

        Console.WriteLine("\nDigite um número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha uma operação com base no número:");
        Console.WriteLine("1 - Soma (+);");
        Console.WriteLine("2 - Subtração (-);");
        Console.WriteLine("3 - Multiplicação (*);");
        Console.WriteLine("4 - Divisão (/);");

        int operacao = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("\nDigite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (operacao == 1)
        {
            result = num1 + num2;

        } else if (operacao == 2)
        {
            result = num1 - num2;

        } else if (operacao == 3)
        {
           result = num1 * num2;

        } else if (operacao == 4)
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Não é possível dividir um número por 0.");
                return;
            }
        }

        Console.WriteLine("\n O resultado é: " + result);
    }
}