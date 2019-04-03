using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

        int primeiro;
        double varejo;
        double atacado;

        Console.WriteLine("Calculadora de compras de maça por atacado");

        Console.WriteLine("Digite quantas maças você comprará?");
        primeiro = int.Parse(Console.ReadLine());

        atacado = primeiro * 0.30;
        varejo = primeiro * 0.25;

        if (primeiro > 11)
        {
        Console.WriteLine("Você pagará o valor de atacado");
        Console.WriteLine("R$ "+varejo);
        }
        else{
        Console.WriteLine("Você pagará o valor de varejo");
        Console.WriteLine("R$ "+atacado);
        }
        }
    }
}
