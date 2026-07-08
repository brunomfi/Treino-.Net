namespace Aula27;

public class Program
{
    public static void Main()
    {
        //INSTANCIAR
        Cake boloChocolate = new Cake("Chocolate", "Coco", "Chocolate", 2, "Medium");
        Console.WriteLine(boloChocolate.Flavor);
        Console.WriteLine(boloChocolate.Filling);
        Console.WriteLine(boloChocolate.Coverage);
        Console.WriteLine(boloChocolate.Layer);
        Console.WriteLine(boloChocolate.Size);
    }
}