using System;

namespace Asteríscos
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 3;
            int colunas = 2;

            for(int i= 1; i <= linhas; i++) {
                for(int j= 1; j <= linhas; j++) {
                    System.Console.WriteLine($"[{i},{j}]");
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
