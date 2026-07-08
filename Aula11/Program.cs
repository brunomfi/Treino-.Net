namespace Aula11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------------Digite o dia da Semana------------");
        Console.WriteLine("------------ DE 1 ate 7 ------------");
        Console.WriteLine("Digite o dia da semana");
        int op = Convert.ToInt32(Console.ReadLine()); 
        switch (op) 
        {
            case 1: 
                Console.WriteLine("SEGUNDA FEIRA");
                break;
            case 2:
                Console.WriteLine("TERÇA FEIRA");
                break;
            case 3:
                Console.WriteLine("QUARTA FEIRA");
                break;
            case 4:
                Console.WriteLine("QUINTA FEIRA");
                break;
            case 5:
                Console.WriteLine("SEXTA FEIRA");
                break;
            case 6:
                Console.WriteLine("SABADO");
                break;
            case 7:
                Console.WriteLine("DOMINGO");
                break;
        }
    }
}