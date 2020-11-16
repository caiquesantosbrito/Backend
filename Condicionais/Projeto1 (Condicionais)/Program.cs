using System;

namespace Projeto1__Condicionais_
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Para participar do time de CS, o aluno precisa ter média maior ou igual a 80
            // E faltas menor ou igual a 10% dos dias letivos

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Bem vindo a seletiva para o time de Counter-Strike");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Você gostaria de participar? Sim ou Não");
            string resposta = Console.ReadLine();

            if(resposta == "Sim"){
                Console.WriteLine("Que legal! Agora vamos analisar seu currículo");
                Console.WriteLine("Insira sua média escolar");
                int media = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite sua quantidade de faltas");
                int falsas = int.Parse(Console.ReadLine());
                if(media >=50 && falsas <=10){
                    Console.WriteLine("Parabéns, seja bem vindo!");
                }
                else{
                    Console.WriteLine("Que pena, você precisa melhorar sua notas e faltas");
                }
            }else{
                Console.WriteLine("Blz, passar bem!");
            }
            // fim if
        }
    }
}
