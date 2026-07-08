namespace Aula15;
public class Program
{
    public static void Main()
    {
        //Foreach, funciona para coloções (listas)
        List<int> numberList = new List<int>() {2,2,3,4,5,6,7,8,9,10 };
        foreach (int number in numberList) 
        { 
            //FAÇA ALGO
            Console.WriteLine(number);
        
        }
    }
}