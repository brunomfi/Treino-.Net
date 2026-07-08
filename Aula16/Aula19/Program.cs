namespace Aula19;
using System.IO;
public class Program
{
    public static void Main()

    {   
        //1 Estrutura 
        string local = @"C:\Users\Suporte\Desktop\Bruno Treino\Dotnet\Aula19\"; // Local onde criaremos, usamos local para facilitar
        string arqName = "Lista_Compras.txt"; // nome do arquivo, usamos arqName como variavel para facilitar
        string filePath = local + arqName; // aqui juntamos os dados acima.

        List <string> ListaCompras = new List<string>();

        //2 Logica 

        if (File.Exists(filePath))
        {
            ListaCompras.AddRange(File.ReadAllLines(filePath));
        }
        
            while (true)
            {
                Console.WriteLine("\n==== LISTA DE COMPRAS ====");
                Console.WriteLine("1 - Adicionar Item");
                Console.WriteLine("2 - Remover Item");
                Console.WriteLine("3 - Exibir Item");
                Console.WriteLine("4 - Sair e Salvar .txt");
                
                Console.WriteLine("OPÇÃO:");

                string escolha = Console.ReadLine();

                switch (escolha)

                {
                case "1":
                        Console.WriteLine("Digite o nome do Item: ");
                        string itemInsert = Console.ReadLine();
                    
                    for (int i = 0; i < ListaCompras.Count;i++) // VERIFICA SE O ITEM JA ESTÁ NA LISTA SE TIVER, EXLUI E ADD O OUTRO
                    {
                        if (ListaCompras[i] == itemInsert)
                        {
                            Console.WriteLine($"Item ja adicionado, removendo item {ListaCompras[i]}");
                            ListaCompras.Remove(ListaCompras[i]);
                        }
                    }

                    if (!string.IsNullOrEmpty(itemInsert)) // SE LISTA ESTÁ VAZIA
                        {
                            ListaCompras.Add(itemInsert);
                            Console.WriteLine($"Item inserido : '{itemInsert}' com sucesso ");
                        }
                    else
                        {
                            Console.WriteLine("Item não pode ser Nulo");
                        }                                          
                    break;
                case "2":
                    
                        Console.WriteLine("Digite o CODIGO do item para remover: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        
                        if (ListaCompras.Remove(ListaCompras[id - 1]))
                        {
                            Console.WriteLine($"Item '{id}' removido com sucesso");

                        }
                        else
                        {
                        Console.WriteLine($"Item do ID:'{id}' não encontado");
                        };
                    break;
                    case "3":
                    Console.WriteLine($"=======LISTA ATUALIZADA========");
                    //VERIFICAÇÃO DOS ITENS
                    for (int i = 0; i < ListaCompras.Count; i++)

                    {

                        Console.WriteLine($"{i + 1} - {ListaCompras[i]}");
                    }
                    break;
                    case "4":
                    File.WriteAllLines(filePath, ListaCompras);
                    Console.WriteLine("Lista Salva com sucesso, saindo");
                        return;
                default:
                    Console.WriteLine("Opção invalida");
                break;
            }
                    
                
            
        }
    }
}