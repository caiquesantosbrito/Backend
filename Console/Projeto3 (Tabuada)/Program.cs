using System;

namespace Projeto3__Tabuada_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");

            int resultado;

            for(int contador = 10; contador >=0; contador --){
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
            }
        }
    }
}
