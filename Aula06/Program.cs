using System.ComponentModel.Design;

namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------Verificar se o numero é PAR---------");
        Console.WriteLine("Digite um numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"O numero {num} é PAR");
        }
        else
        {
            Console.WriteLine($"O numero {num} é IMPAR");
        }
    }
}