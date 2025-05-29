namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores de Atribuição=====");

        Console.WriteLine("\nO operador '=' serve para atribuir um valor.");

        int valor = 1;

        Console.WriteLine(valor);

        Console.WriteLine("\nO operador '++' serve para incrementar 1.");

        valor++;

        Console.WriteLine(valor);

        Console.WriteLine("\nO operador '+=' serve para atribuir e adicionar e pode ser utilizado em inteiros e strings.");

        Console.WriteLine(valor += 10);

        Console.WriteLine("\nO operador '-=' serve para atribuir e subtrair.");

        Console.WriteLine(valor -= 1);

        string texto = "Olá, ";

        Console.WriteLine(texto);

        texto += "Mundo!";

        Console.WriteLine(texto);

        Console.WriteLine("\nO operador '+*' serve para atribuir e multiplicar.");

        Console.WriteLine(valor *= 10);

        Console.WriteLine("\nO operador '+/' serve para atribuir e dividir.");

        Console.WriteLine(valor /= 2);
    }
}