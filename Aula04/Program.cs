namespace Aula04;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("---------- CADASTRO DE USUARIO ----------");
        // Solicitamos o nome do usuario
        Console.WriteLine("Digite seu nome: ");
        var name = Console.ReadLine(); // Aqui seria o para o usuario digitar
        // Console.WriteLine("Nome digitado é : " +name);

        // Solicitar a IDADE:
        Console.WriteLine("Digite sua Idade:");
        var idade = Console.ReadLine();

        Console.WriteLine($"O nome do Usuario é {name} com idade de {idade} anos");

    }
}