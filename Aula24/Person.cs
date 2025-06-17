namespace Aula24;

public class Person
{
    public string Name;
    public int Age;

    public bool IfLegalPerson(int age)
    {
        if (age < 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string IfLegalPersonRefactor(int age)
    {
        string result = string.Empty;

        if (age >= 18)
        {
            result = "A pessoa é maior de idade.";
            return result;
        }
        else
        {
            result = "A pessoa é menor de idade.";
            return result;
        }
    }
}