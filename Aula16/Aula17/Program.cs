namespace Aula17;
public class Program
{
    public static void Main()

    {
        string separator = "-------------------------------";
        //1. Declaração de inicialização de valores, Aula de LISTA, List
        List<string> fruits = new List<string>() 
        { 
        "Morango",
        "Melancia",
        "Melão"           
        };
        //2. Acessar os valores
        Console.WriteLine(fruits[2]);
        Console.WriteLine(separator);
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(separator);
        //3. Adicionar elementos

        fruits.Add("Manga");
        fruits.Add("Maracuja");
        
        foreach (string fruit in fruits) 
        { 
            Console.WriteLine(fruit); 
        }
        Console.WriteLine(separator);
        //4. Remover o elemento da lista;
        fruits.Remove("Maracuja");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);        
        }
        Console.WriteLine(separator);
        //5. Verificar quantidade de elementos
        Console.WriteLine($"Quantidade de frutas é {fruits.Count}");
        Console.WriteLine(separator);
        //6. Modificar um item da lista
        fruits[3] = "Maracuja";
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine($"Limpando Lista...........");
        //7. Limpar Lista
        fruits.Clear();
        foreach (string fruit in fruits) { Console.WriteLine( fruit);  }
        Console.WriteLine("SEM FRUTAS");
        Console.WriteLine(separator);
        //8. Declarando sem inicializar
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}