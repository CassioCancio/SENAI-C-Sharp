using System;

namespace Passagens {
    class Program {
        static void Main (string[] args) {
            bool continuar = true;
            int numero = 0;
            int i = 1;
            int a = 1;
            string[] nome = new string[10];
            string[] passagem = new string[10];
            DateTime[] data = new DateTime[10];

            Console.WriteLine ("\n--------------- Cancio's Airlines ---------------");

            while (continuar) {
                Console.WriteLine ("\n Digite os seguintes números para:\n\n 1 - Registrar passagem;\n 2 - Visualizar passagens;\n 0 - Para SAIR do programa;\n");
                numero = int.Parse (Console.ReadLine ());
                switch (numero) {
                    case 1:
                        if (i <= 5) {
                            Console.WriteLine ("\nQual o nome do passageiro?");
                            nome[i] = Console.ReadLine ();
                            Console.WriteLine ("\nInsira o número da passagem:");
                            passagem[i] = Console.ReadLine ();
                            Console.WriteLine ("\nInsira a data da viagem:");
                            data[i] = DateTime.Parse(Console.ReadLine ());
                            i++;
                        } else {
                            Console.WriteLine ("\n--------------- Número máximo de compras atingido ---------------");
                        }

                        break;
                    case 2:
                        a = 1;
                        for (a = 1; a < i; a++) {
                        Console.WriteLine ($"--------------------------------\nPassageiro: {nome[a]} \nNúmero da passagem: {passagem[a]}\nNa data: {data[a]:dd:MM:yyyy}\n--------------------------------");
                        }
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine ("\n--------------- Digite um valor válido ---------------");
                        break;
                }
            }

        }
    }
}