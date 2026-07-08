namespace Aula03;

public class Program
{

    public static void Main()
    {
        // Variavel conseguimos alterar, os valores nelas descritos.
        int number = 28;
        Console.WriteLine("O valor do numero é: " + number);
        number = 14;
        Console.WriteLine("Agora o valor do numero é: " + number);

        // Valores de constantes não conseguimos alterar 
        const int num = 1000;
        Console.WriteLine("O numero é : " + num);
        // Aqui está comentado pois se colocarmos num = 10; automaticamente ja apresenta um erro e não coseguimos alterar

        // O tipo VAR conseguimos declarar sem ao mesmo informar o tipo primitivo da variavel.

        var nome = "BMF";
        Console.WriteLine(nome);
        // Ao tentar altarar para outro tipo primitivo não irá alterar pois ja foi declarado um primeiro tipo ao digitar "BMF" como STRING

        // Ao contrario o dynamic ele consegue aceitar alteração mesmo que o primeiro tipo primitivo seja string e declararmos um numero nesse variavel.

        dynamic teste = "Bruno";
        Console.WriteLine("Teste para ver o que estava na variavel, a seguir mudará de: "+ teste);
        teste = 28;
        Console.WriteLine("Para: " + teste);

    }
}