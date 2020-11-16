using System;

namespace Projeto3__Nascimento_
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o ano em que nasceu: ");
            int ano_que_nasceu = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o ano atual: ");
            int ano_atual = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            int anos = ano_atual - ano_que_nasceu;
            int semanas = anos * 52;

            Console.WriteLine("Você tem:");
            Console.WriteLine(anos+" anos"); 
            Console.WriteLine("Você viveu:");
            Console.WriteLine(semanas+" semanas");
        }
    }
}
