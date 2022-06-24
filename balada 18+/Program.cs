using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balada_18_
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string nome;

            Console.WriteLine("Bem vindo a Balada do Guilhermito.\r\nPrecisa ser maior de idade para entrar.\r\nQual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Agora fala sua idade");
            idade = int.Parse(Console.ReadLine());

            if(idade < 18){
                Console.WriteLine("desculpe "+nome+" mas voce nao pode entrar,voce e menor de idade.");
            }else
            {
                Console.WriteLine("Pode entrar, divirta-se "+nome);
            }
            Console.ReadKey();

        }
    }
}
