namespace Aula13;
public class Program
{
    public static void Main()
    {
        //Aprendo mais sobre DO WHILE. No caso igual o WHILE, porem ele vai executar primeiramente do que estiver dentro do DO uma vez e depois consultar no WHILE se a condição dada está OK, caso passe a condição o programa para.
        int numero = 1;
        do
        {
            Console.WriteLine(numero);
            numero++;
        }while (numero <= 4);
    }
}