using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            bool usuario = true;

            Console.WriteLine("");
            Console.WriteLine("Bem-vindo à Calculadora de Tabuadas");

            do{

            Console.WriteLine("");
            Console.WriteLine("Insira o n° da tabuada");
            int num = int.Parse(Console.ReadLine());

            while (cont <=10){
                Console.WriteLine("----------------");
                Console.WriteLine(num+" x "+cont+" = "+num*cont);
                cont++;
            Console.WriteLine("");
            Console.WriteLine("Deseja calcular outra tabuada?");
            string resposta = Console.ReadLine();
            usuario = resposta.Equals("sim") ? true : false;
            cont = 0;
            }
            }while(cont <=10);

        }
    }
}
