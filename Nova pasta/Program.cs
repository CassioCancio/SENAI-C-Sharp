using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 0;
            int [] idades ={1,2,5,10,20,50,100};
            int a;
            int b;
            int c;
            int d;
            int e;
            int f;
            int g;

            Console.WriteLine("Banco Eletrônico");
            Console.WriteLine();
            Console.WriteLine("Digite o saldo que você deseja sacar:");
            Console.WriteLine();
            z = int.Parse(Console.ReadLine());

            a = z/idades[6];
            z = z - idades[6]*a;
            b = z/idades[5];
            z = z - idades[5]*b;
            c = z/idades[4];
            z = z - idades[4]*c;
            d = z/idades[3];
            z = z - idades[3]*d;
            e = z/idades[2];
            z = z - idades[2]*e;
            f = z/idades[1];
            z = z - idades[1]*f;
            g = z/idades[0];
            z = z - idades[0]*g;

            Console.WriteLine();
            Console.WriteLine(a+ " notas de 100 reais");
            Console.WriteLine(b+ " notas de 50 reais");
            Console.WriteLine(c+ " notas de 20 reais");
            Console.WriteLine(d+ " notas de 10 reais");
            Console.WriteLine(e+ " notas de 5 reais");
            Console.WriteLine(f+ " notas de 2 reais");
            Console.WriteLine(g+ " notas de 1 reais");
        }
    }
}
