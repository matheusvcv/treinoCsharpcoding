using System.Data;

namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===== Operadores Relacionais =====");

        Console.WriteLine("\nDigite um número:");

        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nDigite um número mais uma vez:");

        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nOperador de Igualdade ==");

        if (valor1 == valor2)
        {
            Console.WriteLine(valor1 + " é igual a " + valor2);
        }
        else
        {
            Console.WriteLine(valor1 + " é diferente " + valor2);
        }

        Console.WriteLine("\nOperador de diferença !=");

        if (valor1 != valor2)
        {
            Console.WriteLine(valor1 + " é diferente de " + valor2);
        }
        else
        {
            Console.WriteLine(valor1 + " não é diferente de " + valor2);
        }

        Console.WriteLine("\nOperador Maior que >");

        if (valor1 > valor2)
        {
            Console.WriteLine(valor1 + " é maior que " + valor2);
        }
        else
        {
            Console.WriteLine(valor1 + " não é maior que " + valor2);
        }

        Console.WriteLine("\nOperador Menor que <");

        if (valor1 < valor2)
        {
            Console.WriteLine(valor1 + " é menor que " + valor2);
        }
        else
        {
            Console.WriteLine(valor1 + " não é menor que " + valor2);
        }

        Console.WriteLine("\nOperador Maior ou Igual");

        if (valor1 >= valor2)
        {
            Console.WriteLine(valor1 + " é maior ou igual a " + valor2);
        }
        else
        {
            Console.WriteLine(valor1 + " não é maior ou igual a " + valor2);
        }

        Console.WriteLine("\nOperador Menor ou Igual");

        if (valor1 <= valor2)
        {
            Console.WriteLine(valor1 + " é menor ou igual a " + valor2);
        }
        else
        {
            Console.WriteLine(valor1 + " não é menor ou igual a " + valor2);
        }
    }
}