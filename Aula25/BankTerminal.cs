namespace Aula25;
public class BankTerminal
{
    BankOperations bank = new BankOperations();
    public void start()
    {
        var InExecution = true;

        while (InExecution)
        {
            DisplayMenu();
            string option = Console.ReadLine();

            if (option == "1")
            {
                bank.CheckBalance();

            }
            else if (option == "2")
            {
                bank.Deposit();

            }
            else if (option == "3")
            {
                bank.WithDraw();

            }
            else
            {
                Console.WriteLine("Operação inválida. Tente novamente.");
            }
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("=====Bank=====");
        Console.WriteLine("1 - Checar Saldo;");
        Console.WriteLine("2 - Depositar;");
        Console.WriteLine("3 - Sacar;");
        Console.WriteLine("4 - Sair;");
    }
  
}

