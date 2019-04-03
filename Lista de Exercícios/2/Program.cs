using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            int segundo;

            Console.WriteLine("Será que você pode votar?");

            Console.WriteLine("Digite o seu ano de nascimento");
            segundo = int.Parse(Console.ReadLine());

            if (segundo < 2004)
            {
            Console.WriteLine("Você pode votar :)");
            }
            else
            {
            Console.WriteLine("Você não pode votar :(");
            }
        }
    }
}
