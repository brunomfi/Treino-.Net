namespace Dicionarios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var estados = new Dictionary<string, string>();
            var brasil = new List< string>();

            for (int i = 0; i < 3; i++) {
                
                Console.WriteLine("Digite a Sigla do estado: ");

                string sigla = Console.ReadLine ();

                Console.WriteLine("Digite o nome do estado: ");
                string nomeEstado = Console.ReadLine ();

                estados.Add (sigla, nomeEstado);
                

            }


            foreach (var estado in estados) 
            { 
                Console.WriteLine($"Sigla: {estado.Key}, Nome do Estado e: {estado.Value}");
            }
        }
    }
}   