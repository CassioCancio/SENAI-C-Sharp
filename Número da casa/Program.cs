using System;

namespace Número_da_casa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x = -1;
            // int y = -1;
            int [] idades = new int [3];

            for (i= 0; i <= 2; i++)
            {
                x++;
                Console.WriteLine("Digite o número da sua casa");
                idades[x] = int.Parse(Console.ReadLine());
            }
            // i = 0;
            Console.WriteLine();
            Console.WriteLine("Os números são:\n");
        //     for (i= 0; i <= 2; i++)
        //     {
        //         y++;
        //         Console.WriteLine(idades[y]);
        // }
            foreach (var idade in idades)
            Console.WriteLine($"{idade}");
            Console.WriteLine("");
    }

}
}