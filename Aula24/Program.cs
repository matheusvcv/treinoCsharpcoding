namespace Aula24;

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        string nome = person.Name = "Robert Stark";
        Console.WriteLine("Digite a idade: ");

        int age = Convert.ToInt32(Console.ReadLine());

        string response = person.IfLegalPersonRefactorName(age, nome);

        Console.WriteLine(response);
    }
}