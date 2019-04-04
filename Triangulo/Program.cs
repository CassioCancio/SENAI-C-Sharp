using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int defr = 0;
            string estrela = "";

            Console.WriteLine("Desenhista de triângulos \n");
            Console.WriteLine("Quantos * de altura vc quer no seu triângulo?");
            defr = int.Parse(Console.ReadLine());

            for(int i= 0; i < defr; i++)
            {
                estrela += "*";
                Console.WriteLine(estrela);
                
            
            }
        }
    }
}
