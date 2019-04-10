using System;

namespace Passagens {
    class Program {
        static void Main (string[] args) {
            bool continuar = true;
            string numero;
            int i = 1;
            string[] nome = new string[10];
            int[] passagem = new int[10];
            DateTime[] data = new DateTime[10];
            string teste;
            string test;

            Console.WriteLine ("\n--------------- Cancio's Airlines ---------------");

            while (continuar) {
                Console.WriteLine ("\n Digite os seguintes números para:\n\n 1 - Registrar passagem;\n 2 - Visualizar passagens;\n 0 - Para SAIR do programa;\n");
                numero = Console.ReadLine ();
                switch (numero) {

                    case "1":
                        if (i <= 5) {
                            Console.Write ($"\nInsira o nome do {i}° passageiro: ");
                            nome[i] = Console.ReadLine ();
                            do {
                                Console.Write ($"Insira um número válido da {i}° passagem: ");
                                teste = Console.ReadLine ();
                            } while (!int.TryParse (teste, out passagem[i]));
                            do {
                                Console.Write ($"Insira uma data válida para a {i}° viagem (dd/mm/aaaa): ");
                                test = Console.ReadLine ();
                            } while (!DateTime.TryParse (test, out data[i]));
                            i++;
                        } else {
                            Console.WriteLine ("\n--------------- Número máximo de compras atingido ---------------");
                        }
                        break;

                    case "2":
                        for (int a = 1; a < i; a++) {
                            Console.WriteLine ($"------------------------------------------\nPassageiro {a}: {nome[a]} \nN° da passagem: {passagem[a]}\nData: {data[a]:dd/MM/yyyy}\n------------------------------------------");
                        }
                        Console.WriteLine ("\n--------------- Clique ENTER para continuar ---------------");
                        Console.ReadLine ();
                        break;

                    case "0":
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