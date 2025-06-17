namespace Aula24;

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        Console.WriteLine("Digite a idade: ");

        int age = Convert.ToInt32(Console.ReadLine());

        string response = person.IfLegalPersonRefactor(age);

        Console.WriteLine(response);
    }
}