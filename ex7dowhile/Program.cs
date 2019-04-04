using System;

namespace ex7dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;//variável para atribuir um valor verdadeiro ou falso, a fim de utiliza-la no Do/While.

            do
            {
                System.Console.WriteLine("Pai, você já acordou?");
                string resposta = Console.ReadLine();

                jaAcordei = resposta.Contains("que") ? true : false;
            } while (!jaAcordei);
        }
    }
}
