using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro;

            Console.WriteLine("LOGIN");
            Console.WriteLine("Digite sua senha");
            primeiro = int.Parse(Console.ReadLine());

            if (primeiro == 1234)
            {
            Console.WriteLine("Acesso Permitido");
            }
            else
            {
            Console.WriteLine("Acesso Negado");
            }
        }
    }
}
