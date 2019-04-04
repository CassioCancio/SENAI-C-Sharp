using System;

namespace Múltiplos_de_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            Console.WriteLine("Chatisse");
             while (cont <=97){
                Console.WriteLine(cont);
                Console.WriteLine("--");
                Console.WriteLine(1+cont);
                Console.WriteLine("--");
                Console.WriteLine(2+cont);
                Console.WriteLine("--");
                Console.WriteLine("PI");
                Console.WriteLine("--");
                cont+=4;
            }
        }
    }
}
