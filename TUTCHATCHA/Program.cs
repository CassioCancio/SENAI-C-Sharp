using System;

namespace TUTCHATCHA
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=0;

            Console.WriteLine("Quantos são maiores de idade?");

            for (int i = 0; i < 10; i++)
            {
            Console.WriteLine("Digite a idade");
            int num = int.Parse(Console.ReadLine());
            if (num>18)
            {
                ++cont;
            }
            }
            Console.WriteLine("O número de pessoas maiores de idade é "+cont);
        }
    }
}
