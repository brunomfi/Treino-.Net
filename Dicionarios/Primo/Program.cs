using System;
using System.Net.Mime;

namespace Primo;
public class Program
{
    int cont = 0;
    public static void Main(string[] args)
    {
        Console.WriteLine("VERICAR SE NUMERO E PRIMO");
        int num = Convert.ToInt32(Console.ReadLine());
        int cont = 0;

        if (num % 2 == 0)
        {
            cont++;
            if (cont == 2) 
            { 
                Console.WriteLine($"Numero {num} é PRIMO"); 
            }
            else 
            { 
                Console.WriteLine($"Numero {num} não é PRIMO");
                Console.WriteLine($"Tem {cont} numeros ");
            }
           
           

        }
        

        


    }
}