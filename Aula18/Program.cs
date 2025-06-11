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

        string pathA = @"C:\Users\mathe\OneDrive\Área de Trabalho\CSharpProjetos\Aula18\";
        string fileName = "MeuArquivo.Doc";

        string filePath = pathA + fileName;

        string conteudoAdicional = " o Rato roeu a roupa do rei de Roma.";

        string conteudoAdicional2 = " novo texto verdade adicional teste.";

        File.AppendAllText(filePath, conteudoAdicional);

        File.AppendAllText(filePath, conteudoAdicional2);

        File.ReadAllText(filePath);
    }
}