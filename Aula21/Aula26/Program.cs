namespace Aula26;

public class Program
{   

    //Aula sobre construtores
    public static void Main()
    {
        //INSTANCIAR
        Cake bolo = new Cake();
        Console.WriteLine($"Sabor: { bolo.Flavor}");
        Console.WriteLine($"Recheio: {bolo.Filling}");
        Console.WriteLine($"Camadas: {bolo.Layer}");
        Console.WriteLine($"Tamanho: {bolo.Size}");


    }
}