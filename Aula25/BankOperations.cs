namespace Aula25;

public class BankOperations()
{
    decimal balance = 1000;

    public void CheckBalance()
    {
        Console.WriteLine($"\nO seu saldo é R${balance}");
    }

    public void Deposit()
    {
        Console.WriteLine("Informe o valor a ser depositado:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
    }

    public void WithDraw()
    {
        Console.WriteLine("Informe o valor que você gostaria de sacar:");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (amount <= balance)
            {
                Console.WriteLine($"O valor de R$ {amount} retirado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
    }
}