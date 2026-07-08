namespace Aula22;
public class Program
{
    // Vai começar aqui
    public static void Main()
    {
        //1. Instancia do computador.
        var computerPC = new Computador();

        //2. Setar as informações do computador
        computerPC.Id = 1;
        computerPC.Name = "COMPUTADOR-BRUNO-OLD";
        computerPC.Description = "Processador FX 6core, Placa de Video - R7 350 Radeon 1Gb, 8GB Memoria RAM DD3";
        computerPC.Value = 550.90;
        computerPC.IsSetup = false;

        //3. Mostrar para o Usuario
        Console.WriteLine($"ID: {computerPC.Id}");
        Console.WriteLine($"Nome computador: {computerPC.Name}");
        Console.WriteLine($"Descrição: {computerPC.Description}");
        Console.WriteLine($"Valor: {computerPC.Value}");
        Console.WriteLine($"Tem setup: {computerPC.IsSetup}");

        Console.WriteLine("____________________________________________________________________________________________");

        //4. Outro computador

        var PCNEW = new Computador();
        PCNEW.Id = 2;
        PCNEW.Name = "COMPUTADOR-BRUNO-NEW";
        PCNEW.Description = "Processador i3 10100, Placa de Video - 1660Gtx 4Gb, 16GB Memoria RAM DDR4";
        PCNEW.Value = 3800.90;
        PCNEW.IsSetup = false;

        
        Console.WriteLine($"ID: {PCNEW.Id}");
        Console.WriteLine($"Nome computador: {PCNEW.Name}");
        Console.WriteLine($"Descrição: {PCNEW.Description}");
        Console.WriteLine($"Valor: {PCNEW.Value}");
        Console.WriteLine($"Tem setup: {PCNEW.IsSetup}");


        Console.WriteLine("____________________________________________________________________________________________");

        //5. Criando lista com computadores

        List<Computador> computadors = new List<Computador>();

        computadors.Add( computerPC );
        computadors.Add(PCNEW);

        foreach (Computador comp in computadors)
        {
            Console.WriteLine("EXIBINDO A LISTA DE COMPUTADORES");
            Console.WriteLine($"ID: {comp.Id}");
            Console.WriteLine($"Nome computador: {comp.Name}");
            Console.WriteLine($"Descrição: {comp.Description}");
            Console.WriteLine($"Valor: {comp.Value}");
            Console.WriteLine($"Tem setup: {comp.IsSetup}");
            Console.WriteLine("____________________________________________________________________________________________");

        }





    }
}