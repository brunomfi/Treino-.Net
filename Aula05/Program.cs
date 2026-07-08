namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------------CALCULADORA SIMPLES------------");
        Console.WriteLine("Digite um numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite outro numero: ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        Console.WriteLine($"A soma de {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"A Subtração de {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"A Multiplicação de {num1} x {num2} = {num1 * num2}");
        Console.WriteLine($"A Divisão de {num1} / {num2} = {num1 / num2}");
        Console.WriteLine($"O modulo de {num1} % {num2} = {num1 % num2}");









    }
}