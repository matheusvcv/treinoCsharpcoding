namespace Aula22;

public class Program
{
    public static void Main()
    {
        Cake StrawberryCake = new Cake();

        StrawberryCake.Id = 1;
        StrawberryCake.Name = "Bolo de Morango";
        StrawberryCake.Description = "Bolo macio feito por chefes qualificados com sabor morango.";
        StrawberryCake.Value = 30;
        StrawberryCake.IsFilling = true;

        Console.WriteLine("O id é: " + StrawberryCake.Id);
        Console.WriteLine("O Nome é: " + StrawberryCake.Name);
        Console.WriteLine("A descrição é: " + StrawberryCake.Description);
        Console.WriteLine("Preço do bolo: " + StrawberryCake.Value);
        Console.WriteLine("O bolo é recheado? " + StrawberryCake.IsFilling);

        Console.WriteLine("===============");

        Cake ChocolatCake = new Cake();

        ChocolatCake.Id = 2;
        ChocolatCake.Name = "Bolo de Chocolate";
        ChocolatCake.Description = "Bolo macio feito por chefes qualificados com sabor chocolate.";
        ChocolatCake.Value = 45;
        ChocolatCake.IsFilling = false;

        Console.WriteLine("O id é: " + ChocolatCake.Id);
        Console.WriteLine("O Nome é: " + ChocolatCake.Name);
        Console.WriteLine("A descrição é: " + ChocolatCake.Description);
        Console.WriteLine("Preço do bolo: " + ChocolatCake.Value);
        Console.WriteLine("O bolo é recheado? " + ChocolatCake.IsFilling);

        Console.WriteLine("===============");


        List<Cake> CakeList = new List<Cake>();

        CakeList.Add(StrawberryCake);
        CakeList.Add(ChocolatCake);

        foreach (Cake cake in CakeList)
        {
            Console.WriteLine("O id é: " + cake.Id);
            Console.WriteLine("O Nome é: " + cake.Name);
            Console.WriteLine("A descrição é: " + cake.Description);
            Console.WriteLine("Preço do bolo: " + cake.Value);
            Console.WriteLine("O bolo é recheado? " + cake.IsFilling);   
        }
    }
}