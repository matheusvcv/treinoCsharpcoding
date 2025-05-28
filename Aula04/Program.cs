namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("----------CADASTRO DE USUÁRIO----------");

        Console.WriteLine("Digite Seu Nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite Sua Idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O nome é: " + nome + "e a idade é: " + idade);
    }
}