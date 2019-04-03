using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int oi;
            int oie;
            int ola;

            Console.WriteLine("Reordenador Crescente");

            Console.WriteLine("Insira o primeiro número");
            oi = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            oie = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número");
            ola = int.Parse(Console.ReadLine());
        if (oi > oie > ola)
        {
            Console.WriteLine(oi +"e "+oie+"e "+ola);
        }
        if (oi > ola > oie)
        {
            Console.WriteLine("Insira o primeiro número");
        }
        if (oie > oi > ola)
        {
            Console.WriteLine("Insira o primeiro número");
        }
        if (oie > ola > oi)
        {
            Console.WriteLine("Insira o primeiro número");
        }
        if (ola > oie > oi)
        {
            Console.WriteLine("Insira o primeiro número");
        }
        if (ola > oi > oie)
        {
            Console.WriteLine("Insira o primeiro número");
        }
        }
    }
}
