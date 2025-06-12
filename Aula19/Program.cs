namespace Aula19;

using System.IO;

public class NewBaseType
{
    public static void Main()
    {
        string path = @"C:\Users\mathe\OneDrive\Área de Trabalho\CSharpProjetos\Aula19\";
        string fileName = "ShoppingList.txt";
        string pathFileName = path + fileName;

        List<string> shoppingList = new List<string>();

        if (File.Exists(pathFileName))
        {
            shoppingList.AddRange(File.ReadAllLines(pathFileName));
        }

        while (true)
        {
            Console.WriteLine("---Lista de Compras---");
            Console.WriteLine("1 - Para adicionar um item digite 1.");
            Console.WriteLine("2 - Para remover um item digite 2.");
            Console.WriteLine("3 - Para ecibir a lista digite 3.");
            Console.WriteLine("4 - Digite 4 para sair.");
            Console.WriteLine("Escolha uma opção para continuar.");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o item que quer adicionar: ");
                    string itemInsert = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);
                        Console.WriteLine($"Item '{itemInsert}' adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro! O item não pode ser vazio.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o item que quer remover:");
                    string itemRemove = Console.ReadLine();

                    if (shoppingList.Remove(itemRemove))
                    {
                        Console.WriteLine($"Item '{itemRemove}' removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemRemove}' não foi encontrado!");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n Itens na sua lista de compras: ");

                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista de compras está vazia.");
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        }
                    }
                    break;

                case "4":
                    File.WriteAllLines(pathFileName, shoppingList);
                    Console.WriteLine("Lista salva com sucesso. Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        }

    }
}

