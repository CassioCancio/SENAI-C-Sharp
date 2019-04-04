using System;

namespace Estatística
{
    class Program
    {
        static void Main(string[] args)
        {
            int masc = 0;
            int femin = 0;
            int mediaIM = 0;

            Console.WriteLine("Quantos são maiores de idade?");

            for (int i = 0; i < 10; i++)
            {
            Console.WriteLine("Digite o sexo (M ou F)");
            string sexo = Console.ReadLine();

            if(sexo.Equals("m"))
            {
                ++masc;
                
                Console.WriteLine("Digite a idade");
                int numM = int.Parse(Console.ReadLine());

                mediaIM += numM;

                Console.WriteLine("Digite o seu peso");
                int pesoM = int.Parse(Console.ReadLine());
            }
            if(sexo.Equals("f"))
            {
                ++femin;
                
                Console.WriteLine("Digite a idade");
                int num = int.Parse(Console.ReadLine());
            
                Console.WriteLine("Digite o seu peso");
                int peso = int.Parse(Console.ReadLine());
            }
            }
                Console.WriteLine("A quantidade de homens é "+masc);
                Console.WriteLine("A quantidade de mulheres é "+ femin);

                Console.WriteLine("A média das idades femininas é");
                Console.WriteLine("A média das idades masculinas é");

                Console.WriteLine("A média dos pesos femninos é");
                Console.WriteLine("A média dos pesos masculinos é");
        }
    }
}