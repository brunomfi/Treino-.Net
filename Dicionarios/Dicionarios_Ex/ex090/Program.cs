using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ex90
{
    public class Program
    {
        public static void Main()
        {
            var aluno = new Dictionary<string, object>();
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Media: ");
            double media = Convert.ToDouble(Console.ReadLine());

            aluno.Add("Nome", nome);
            aluno.Add("Media", media);

            if (media >= 6) 
            {
                aluno.Add("Situação", "Aprovado");
            }
            else
            {
                aluno.Add("Situação", "Reprovado");
            }
            foreach (var itens in aluno)
            {
               Console.WriteLine($"{itens.Key} é igual: {itens.Value}");
            }
        }
    }
}