using System.Runtime.Intrinsics.X86;

namespace Aula11b;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Avaliação de Notas=====");

        bool continua = true;

        while (continua == true)
        {
            Console.WriteLine("Digite sua nota entre 0 e 10:");
            int nota = Convert.ToInt32(Console.ReadLine());

            switch (nota)
            {
                case 10:
                case 9:
                    Console.WriteLine("Seu desempenho foi ótimo.");
                    break;

                case 8:
                case 7:
                    Console.WriteLine("Seu desempenho foi bom.");
                    break;

                case 6:
                case 5:
                    Console.WriteLine("Seu desempenho foi regular");
                    break;

                case 4:
                case 3:
                    Console.WriteLine("Seu desempenho foi ruim");
                    break;

                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Seu desempenho foi abaixo do esperado.");
                    break;

                default:
                    Console.WriteLine("O número que você digitou não é uam nota válida.");
                    break;
            }
        }
    }
}