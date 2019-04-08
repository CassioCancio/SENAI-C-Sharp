using System;

namespace Asteríscos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int colunas = 3;
            int linhas = 15;

            for(int i = 1; i <= colunas; i++) {
                for(string j = ""; j.Length <= linhas; j+="*") {
                    System.Console.WriteLine(j);
                }
            }
        }
    }
}
