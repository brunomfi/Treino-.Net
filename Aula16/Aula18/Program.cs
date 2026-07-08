namespace Aula18;

using System.IO;
public class Program
{
    public static void Main()
    {
        //// Aula aborda sobre como trabalhar em arquivos. Utilizando o using System.IO;
        ////1. Criando um arquivo.
        //File.WriteAllText("file.txt", "Bruno de Medeiros Fidelis");
        //Console.WriteLine("Arquivo Criado com sucesso");

        ////2. Criando arquivo em lugar especifico;
        //string local = @"C:\Users\Suporte\Desktop\Bruno Treino\Dotnet\Aula18\ArquivoAula.txt";
        //string content = "Bruno de Medeiros Fidelis";
        //File.WriteAllText(local, content);
        //Console.WriteLine("Arquivo Criado com sucesso");


        ////3. Criando arquivo em lugar especifico em outra extensão, exemplo Word;
        //string local = @"C:\Users\Suporte\Desktop\Bruno Treino\Dotnet\Aula18\";
        //string fileName = "myDocument.Doc";
        //string filePath = local + fileName;
        //string content = "Bruno de Medeiros Fidelis";
        //File.WriteAllText(filePath, content);
        //Console.WriteLine("Arquivo Word Criado com sucesso");


        //4. Atualizando arquivo ja criado;
        string local = @"C:\Users\Suporte\Desktop\Bruno Treino\Dotnet\Aula18\";
        string fileName = "myDocument.Doc";
        string filePath = local + fileName;
        string additionalContent = " || Aprendendo C# e .NET";
        File.AppendAllText(filePath, additionalContent);
        Console.WriteLine("Arquivo Word Atualziado com sucesso");

        //5. Ler o Arquivo
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine($"O arquivo contem o texto: {fileContent}");
    }
}