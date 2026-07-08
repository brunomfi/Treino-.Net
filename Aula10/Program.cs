namespace Aula10;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o primeiro numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //SELECIONAR A OPÇÃO DA CAULCULADORA

        Console.WriteLine("ESCOLHA OPÇÃO:\n" +
            "[1] = SOMAR\n" +
            "[2] = SUBTRAIR\n" +
            "[3] = MULTIPLICAR\n" +
            "[4] = DIVIDIR\n" +
            "[5] = MODULO\n" +
            "OPÇÃO: ");
        int op = Convert.ToInt32(Console.ReadLine());

        if (op < 1 || op > 6)
        {
            Console.WriteLine("OPÇÃO INVALIDA");
        }
        else
        {
            if (op == 1)
            {
                Console.WriteLine($"A soma de {num1} + {num2} = {num1 + num2}");
            }
            else if (op == 2)
            {
                Console.WriteLine($"A subtração de {num1} - {num2} = {num1 - num2}");
            }
            else if (op == 3)
            {
                Console.WriteLine($"A multiplicação de {num1} X {num2} = {num1 * num2}");
            }
            else if (op == 4)
                if (num1 != 0  || num2 != 0)
                {
                    Console.WriteLine($"A divisão de {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Não é possivel dividir numero por 0");
                }



            else if (op == 5)
                {
                    Console.WriteLine($"O modulo de {num1} % {num2} = {num1 % num2}");
                }
        }
    }
}
