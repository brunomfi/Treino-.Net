
using System.Security.Cryptography.X509Certificates;

namespace Banco_Treino
{
    public class BancoOperation

    {
        string Well;
        double valorConta = 0;
        public void Wellcome()
        {
            Console.WriteLine("Bem vindo ao ==$$ Banco BMF $$==");

        }

        public void Deposit()
        {
            Console.WriteLine("Informe o valor para Deposito R$: ");
            double valorDep = Convert.ToDouble(Console.ReadLine());
            valorConta += valorDep;
            Console.WriteLine($"Depositado com sucesso R$ {valorDep}");
        }

        public void Retirada()
        {
            Console.WriteLine("Informe o valor para retirada R$: ");
            double retira = Convert.ToDouble(Console.ReadLine());
            if (retira <= valorConta)
            {
                Console.WriteLine($"O valor de R$ {retira} foi retirado com sucesso");
                valorConta -= retira;

            }
            else
            {
                Console.WriteLine($"Impossivel, valor R$ {retira}maior que valor em conta");
            }
        

        }
        public void VerValor() 
        {
            Console.WriteLine($"O valor total do seu banco é: {valorConta} ");
        }


    }
}
