namespace Aula12;

public class Program
{
    public static void Main()
    { // ENTENDENDO FUNCIONAMENTO DO WHILE NO C#
        // Ex1
        // int i = 0;
        //while (i <= 1000)
        //{
               // console.WriteLine(i);
                    //i++;

        //}

        //EX2
        double budget = 100;
        while (budget > 0) { 
            Console.WriteLine(budget);
            budget--;
        
        }
        Console.WriteLine("Saldo insuficiente");
    }
}