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
            string hora;

            Console.WriteLine("Você tem disponibilidade?");
            disp = Console.ReadLine().ToLower();

            if (disp.Equals("sim"))
            {
                Console.WriteLine("Você quer ir a uma balada à noite ou numa matinê?");
                hora = Console.ReadLine().ToLower();
                Console.WriteLine("Qual a sua idade?");
                idade = int.Parse(Console.ReadLine());
                if (idade < 18 && hora.Equals("noite"))
                {
                    Console.WriteLine("Não foi dessa vez, você não tem idade para essa festa :(");
                }
                else
                {
                    Console.WriteLine("Você é VIP ou pagou?");
                    vip = Console.ReadLine().ToLower();
                    Console.WriteLine("SEXTOOOOU!");
                    if (vip.Equals("vip"))
                    {
                        Console.WriteLine("Aí sim, ainda vai de VIP");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não foi dessa vez, sem horário não tem nem como");
            }
        }
    }
}
