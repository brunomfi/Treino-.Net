

using Banco_Treino;
namespace Banco_BMF
{
    
    public class BancoTerminal
    {
        BancoOperation bankbmf = new BancoOperation();

        public void Option()
        {

            while (true) 
            {
                Console.WriteLine("ESCOLHA UMA OPÇÃO PARA O BANCO BMF" +
                    "\n 1 - DEPOSITO" +
                    "\n 2 - SAQUE " +
                    "\n 3 - SALDO" +
                    "\n 0 - SAIR" +
                    "DIGITE UMA OPÇÂO:");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op) 
                {

                    case 1:
                        bankbmf.Deposit();
                    break;
                    case 2:
                        bankbmf.Retirada(); break;
                    case 3:
                        bankbmf.VerValor(); break;


                }
                
            }
        
        }
            

    }
}
