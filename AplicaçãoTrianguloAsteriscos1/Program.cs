using System;

namespace AplicaçãoTrianguloAsteriscos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            string a = "";
            Console.WriteLine("Bem vindo ao desenhador de triângulos");
            Console.WriteLine("Digite quantos caracteres você deseja na base do triângulo:");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                a += "*";
                Console.WriteLine(a);
            }
        }
    }
}
