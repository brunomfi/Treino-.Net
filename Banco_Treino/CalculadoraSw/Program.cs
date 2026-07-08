namespace Calculadora;
public class Program
{
    public static void Main()
    {
        bool continua = true ;
        while (continua)
        {
            
            Console.WriteLine("------------ CALCULADORA SIMPLES ------------" +
                "\nESCOLHA UMA OPÇÃO" +
                "\n[1] - SOMA" +
                "\n[2] - SUBTRAÇÃO" +
                "\n[3] - MULTIPLICAÇÃO" +
                "\n[4] - DIVISÃO" +
                "\n[0] - SAIR" +
                "\nESCOLHA UMA OPÇÃO");
            int opcao = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Digite um numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            switch (opcao) 

            {
                case 1:
                    Console.WriteLine($"A soma é {num1 + num2}");
                    break;           
            
                case 2:
                    Console.WriteLine($"A subtração é {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"A multiplicação é {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"A divisão é {num1 / num2}");
                    break;
                case 0:
                    continua = false;
                    break;
               
            }
            Console.WriteLine("Deseja continuar S/N ?");
            string res = (Console.ReadLine());
            if (res != "S" && res != "s") 
            {
                continua = false;
            }


        }
    }
}