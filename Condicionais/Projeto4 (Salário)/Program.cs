using System;

namespace Projeto4__Salário_
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Reajustaremos o salários menores que 500 reais");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("O seu salário é menor que 500 reais?");
            string resposta = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------");

            if(resposta == "Sim"){
                Console.WriteLine("Muito bem, digite o valor do seu salário");
                int salario = int.Parse(Console.ReadLine());
                if(salario <=499){
                    double aumento = salario * 0.30;
                    double reajuste = salario + aumento;

                    Console.WriteLine("Seu salário teve um aumento de:");
                    Console.WriteLine(aumento+" reais");
                    Console.WriteLine("Seu novo salário será:");
                    Console.WriteLine(reajuste+" reais");
                }
            }else{
                Console.WriteLine("Bem, então não iremos reajustar-lo");
            }
        }
    }
}
