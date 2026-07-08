// OPERADORES LOGICOS
namespace Aula09;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("VERIFICAR SE ESTÁ LOGADO");

        bool isLogg = true;
        bool isAdmin = false;

        if (isLogg && isAdmin)
        {
            Console.WriteLine("Está Logado com painel ADM concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao ADM não concedido");

        }

        // OPERADOR OR || 

        if (isLogg || isAdmin)
        {
            Console.WriteLine("Acesso ao sistema concedido");


        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }

        if (!isLogg)
        {
            Console.WriteLine("Usuario não logado");

        }
        else 
        {
            Console.WriteLine("Usuario Logado");

        }  
            
            
        }

 }