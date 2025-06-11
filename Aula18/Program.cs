namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        File.WriteAllText("file.txt", "Hello, world.");

        string path = @"C:\Users\mathe\OneDrive\Área de Trabalho\CSharpProjetos\Aula18\fileName.txt";
        string text = "Hello world!";
        File.WriteAllText(path, text);
    }
 }
