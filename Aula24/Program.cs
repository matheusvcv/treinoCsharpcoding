namespace Aula24;

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        Console.WriteLine("Digite a idade: ");

        int age = Convert.ToInt32(Console.ReadLine());

        bool IfLegalPerson = person.IfLegalPerson(age);

        if (IfLegalPerson == true)
        {
            Console.WriteLine("A pessoa é menor de idade!");
        }
        else
        {
            Console.WriteLine("A pessoa é maior de idade!");
        }
    }
}