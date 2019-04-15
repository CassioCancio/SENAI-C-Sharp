using System;

namespace OO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao AmaralBank");
            
            ContaCorrente conta1 = new ContaCorrente();

            System.Console.WriteLine("Digite o nome do titular");
            conta1.titular = Console.ReadLine();
            System.Console.WriteLine("Número da Agência");
            conta1.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Número da conta");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);

            ContaCorrente conta2 = new ContaCorrente();

            System.Console.WriteLine("Digite o nome do titular");
            conta2.titular = Console.ReadLine();
            System.Console.WriteLine("Número da Agência");
            conta2.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Número da conta");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta2.Depositar(1000);
            
            
            System.Console.WriteLine($"---------------------------");
            System.Console.WriteLine($"Titular: {conta1.titular}");
            System.Console.WriteLine($"Agencia: {conta1.agencia}");
            System.Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta1.saldo}");
            System.Console.WriteLine($"---------------------------");

            System.Console.WriteLine($"---------------------------");
            System.Console.WriteLine($"Titular: {conta2.titular}");
            System.Console.WriteLine($"Agencia: {conta2.agencia}");
            System.Console.WriteLine($"Número da conta: {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo: {conta2.saldo}");
            System.Console.WriteLine($"---------------------------");

            bool resultadoTransferencia = true;

            do
            {
            Console.WriteLine("Quanto deseja tranferir para de conta 1 para conta 2");
            double valorTransferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir(valorTransferencia, conta2);
            } while (resultadoTransferencia != true);

            System.Console.WriteLine($"----------Resultado após transferência----------");
            System.Console.WriteLine($"Saldo conta 1: {conta1.saldo}");
            System.Console.WriteLine($"Saldo conta 2: {conta2.saldo}");
        }
    }
}

