using System;

namespace Segundo_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               Calculadora de média               ");

            int faltas;
            float primeira;
            float segunda;
            float terceira;
            float soma;

            Console.WriteLine("Digite a primeira nota");
            primeira = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            segunda = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            terceira = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de faltas");
            faltas = int.Parse(Console.ReadLine());

            soma = primeira + segunda + terceira;

            double media = soma / 3;


            if (media < 5 || faltas > 25)
            {
                Console.WriteLine("Aluno Reprovado");
            }
            else if (media < 9)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("É isso aí Jovem!");
            }

            Console.WriteLine("A soma das notas é: " + soma + " e a média é: " + media);
        }
    }
}
