namespace Aula25;

public class BankOperations()
{
    decimal balance = 1000;

    public void CheckBalance()
    {
        Console.WriteLine($"\nO seu saldo é R${balance}");
    }

    public void Depoisit()
    {
        Console.WriteLine("Informe o valor a ser depositado: R$ ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount ) && amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
    }
}