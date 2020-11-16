using System;

namespace Projeto2__Idade_
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bem vindo ao calculador de idade");
            Console.WriteLine("--------------------------------");
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            int meses = idade * 12;
            int dias = idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;

            Console.WriteLine("Você viveu:");
            Console.WriteLine(meses+" meses");
            Console.WriteLine(dias+" dias");
            Console.WriteLine(horas+" horas");
            Console.WriteLine(minutos+" minutos");
        }
    }
}
