using System.Net;

namespace Aula11a;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Dias da Semana Com Base em um número=====");

        bool continua = true;

        while (continua == true)
        {
            Console.WriteLine("Escolha um número de 1 a 7, e descubra a qual dia da semana ele é referente:");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("O dia é Domingo.");
                    break;

                case 2:
                    Console.WriteLine("O dia é Segunda");
                    break;

                case 3:
                    Console.WriteLine("O dia é Terça");
                    break;

                case 4:
                    Console.WriteLine("O dia é Quarta");
                    break;

                case 5:
                    Console.WriteLine("O dia é Quinta");
                    break;

                case 6:
                    Console.WriteLine("O dia é Sexta");
                    break;

                case 7:
                    Console.WriteLine("O dia é Sábado");
                    break;

                default:
                    Console.WriteLine("Você escolheu uma opção inválida.");
                    break;
            }
        }
    }
}