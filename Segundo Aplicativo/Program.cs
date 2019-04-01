using System;

namespace Segundo_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               Calculadora de média               ");

            float primeira= 9;
            float segunda= 10;
            float terceira= 5;

            float soma;

            soma = primeira + segunda + terceira;

            float media = soma/3;

            Console.WriteLine("A soma das notas é: "+soma+" e a média é: "+media);
        }
    }
}
