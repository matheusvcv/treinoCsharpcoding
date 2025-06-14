using Aula23;

namespace Aula;

public class Program
{
    public static void Main()
    {
        var BancoPraiano = new Bank();
        BancoPraiano.Id = 12;
        BancoPraiano.Name = "Banco Praiano";

        BancoPraiano.RequestNewCard();
    }
}