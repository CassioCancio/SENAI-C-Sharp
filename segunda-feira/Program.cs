using System;

namespace segunda_feira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Tsuka's Bank");

            conta conta1 = new conta();

            Console.WriteLine("Digite o nome do titular:");
            conta1.titular = Console.ReadLine();
            Console.WriteLine("Digite o número de agência:");
            conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta:");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.saldo = 1000;
            conta1.Depositar(1000);
            Console.WriteLine("Digite quantos reais você quer sacar:");
            bool resultado = conta1.Sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Titular: {conta1.titular}");
            Console.WriteLine($"Agência: {conta1.agencia}");
            Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            Console.WriteLine($"Saldo: R$ {conta1.saldo}");
            Console.WriteLine("----------------------------");

            conta conta2 = new conta();

            Console.WriteLine("Digite o nome do titular:");
            conta2.titular = Console.ReadLine();
            Console.WriteLine("Digite o número de agência:");
            conta2.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta:");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta1.saldo = 4000;
            conta2.Depositar(3000);
            Console.WriteLine("Digite quantos reais você quer sacar:");
            bool resultado = conta2.Sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Titular: {conta2.titular}");
            Console.WriteLine($"Agência: {conta2.agencia}");
            Console.WriteLine($"Número da conta: {conta2.numeroConta}");
            Console.WriteLine($"Saldo: R$ {conta2.saldo}");
            Console.WriteLine("----------------------------");
        }
    }
}
