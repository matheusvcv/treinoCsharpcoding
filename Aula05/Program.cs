namespace Aula05;

class Program
{
    public static void Main()
    {
        Console.WriteLine("---Calculadora Simples---");

        Console.WriteLine("Digite o Primeiro Valor:");

        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o Segundo Valor:");

        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A some dos dois valores é: " + (valor1 + valor2));
        Console.WriteLine("A subtração do valor 1 do valor dois é: " + (valor1 - valor2));
        Console.WriteLine("A multiplicação do valor 1 pelo valor 2 é: " + valor1 * valor2);
        Console.WriteLine("A divisão di valor1 pelo valor2 é: " + valor1 / valor2);
        Console.WriteLine("O resto da divisão do valor 1 pelo valor 2 é: " + valor1 % valor2);
    }
}