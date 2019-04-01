using System;

namespace _4_Quarto_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baladation - APP");

            int idade;
            string disp;
            string vip;

            Console.WriteLine("Você tem disponibilidade?");
            disp = Console.ReadLine().ToLower();

            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
            Console.WriteLine("Você é VIP ou pagou?");
            vip = Console.ReadLine().ToLower();
            Console.WriteLine("SEXTOOOOU!");
            }
            else{
            Console.WriteLine("Não foi dessa vez");
            }

        }
    }
}
