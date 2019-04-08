using System;

namespace Com_for_agr
{
    class Program
    {
        static void Main(string[] args)
        {
             int z = 0;
            int [] idades ={100,50,20,10,5,2,1};
            int [] oi = new int [7];
            int m = 0;
            int n = 0;
            
            Console.WriteLine("Banco Eletrônico");
            Console.WriteLine();
            Console.WriteLine("Digite o saldo que você deseja sacar:");
            Console.WriteLine();
            z = int.Parse(Console.ReadLine());
            
            for(int i=0; i<=7; i++){
                oi[m]=z/idades[n];
                z = z - oi[m] * idades[n]; 
                m++;
                n++;
            }
            foreach (var idade in oi)
            Console.WriteLine($"{idade}");
            Console.WriteLine("");
    }
            // Console.WriteLine();
            // Console.WriteLine(a+ " notas de 100 reais");
            // Console.WriteLine(b+ " notas de 50 reais");
            // Console.WriteLine(c+ " notas de 20 reais");
            // Console.WriteLine(d+ " notas de 10 reais");
            // Console.WriteLine(e+ " notas de 5 reais");
            // Console.WriteLine(f+ " notas de 2 reais");
            // Console.WriteLine(g+ " notas de 1 reais");
        }
    }
