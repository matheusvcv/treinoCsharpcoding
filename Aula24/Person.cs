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
}