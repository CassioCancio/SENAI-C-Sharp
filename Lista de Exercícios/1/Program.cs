using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            int primeiro;
            int segundo;

            Console.WriteLine("Descubra qual número é maior");
            
            Console.WriteLine("Digite o primeiro número");
            primeiro = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            segundo = int.Parse(Console.ReadLine());

            if (primeiro > segundo)
            {
            Console.WriteLine("O primeiro é maior e vale:");
            Console.WriteLine(primeiro);
            }
            else
            {
            Console.WriteLine("O segundo é maior e vale:");
            Console.WriteLine(segundo);
            }
        }
    }
}
