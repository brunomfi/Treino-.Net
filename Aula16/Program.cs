namespace Aula16;
public class Program
{
    public static void Main()
    {
        string separator = "--------------------------------------------------";
        //1. Declaração de Array
        string[] fruits = { "Banana", "Maçã", "Morango", "Manga" };
        //2. Acessar os valores 
        Console.WriteLine($"A fruta é {fruits[1]}");
        Console.WriteLine(separator);

        Console.WriteLine("Ver todas as frutas com FOREACH");
        foreach (string fruit in fruits)


        {
            Console.WriteLine(fruit);

        }

        //3. Mostra quantidade de itens. 
        Console.WriteLine(separator);
        Console.WriteLine("Verifica quantidade de itens na lista");
        Console.WriteLine($"Quantida de frutas é: {fruits.Length}");
        Console.WriteLine(separator);
        //4. Alterar os valores de uma Lista;

        Console.WriteLine($"Fruta antes da alteração é : {fruits[0]}");
        fruits[0] = "Melão";
        Console.WriteLine($"Fruta depois da alteração é : {fruits[0]}");
        Console.WriteLine(separator);
        //5. Declaração sem iniciar;
        int [] numbers = new int[3];
        numbers[0] = 10; numbers[1] = 20; numbers[2] = 30;

        foreach (int number in numbers)
        

        {
            
            Console.WriteLine(numbers);
        }


    }

}