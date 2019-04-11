using System;

namespace Boletim {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[11];
            string[] sobrenome = new string[11];
            float[] nota_1 = new float[11];
            float[] nota_2 = new float[11];
            float soma = 0;
            float[] quociente = new float[11];
            int b = 0;
            int c = 0;
            int a = 1;
            string teste;
            string test;
            bool continuacao = true;
            bool validacao_inicial = true;
            string digito = "";
            string resposta = "";

            Console.WriteLine ($"\n--- Seja Bem-Vindo ao Aplicativo de Boletins ---");
            while (continuacao) {
                validacao_inicial = true;
                while (validacao_inicial) {
                    Console.WriteLine ($"\n----------------------------------------------");
                    if (a < 11) {
                    Console.WriteLine ($"  Digite 1 para iniciar o boletim do aluno {a}");
                    }
                    if (a > 1) {
                        Console.WriteLine ($"  Digite 2 para visualizar os resultados");
                    }
                    Console.WriteLine ($"  Digite 0 para sair do programa");
                    Console.WriteLine ($"----------------------------------------------\n");
                    digito = Console.ReadLine ();
                switch (digito) {
                    case "1":
                        if (a < 11) {
                            b = 0;
                            c = 0;
                            Console.Write ($"\nDigite o primeiro nome do aluno {a}: ");
                            nome[a] = Console.ReadLine ();
                            Console.Write ($"Digite o sobrenome do aluno {a}: ");
                            sobrenome[a] = Console.ReadLine ();
                            do {
                                if (c >= 1) {
                                    Console.WriteLine ($"\n------------- Valor inválido, digite novamente -------------\n");
                                }
                                Console.Write ($"Digite a primeira nota do {a}° aluno: ");
                                teste = Console.ReadLine ();
                                c++;
                            } while (!float.TryParse (teste, out nota_1[a]));
                            do {
                                if (b >= 1) {
                                    Console.WriteLine ($"\n------------- Valor inválido, digite novamente -------------\n");
                                }
                                Console.Write ($"Digite a segunda nota do {a}° aluno: ");
                                test = Console.ReadLine ();
                                b++;
                            } while (!float.TryParse (test, out nota_2[a]));
                            Console.WriteLine ($"\n------------- Aluno Cadastrado -------------");
                            soma = nota_1[a] + nota_2[a];
                            quociente[a] = soma / 2;
                            a++;
                        }
                        else{
                            Console.WriteLine ($"------ O número máximo de alunos cadastrados foi atingido -----");
                        }
                    break;
                    case "2":
                        for (int p = 1; p < a ; p++) {
                            Console.WriteLine ("---------------------------------------------");
                            Console.WriteLine ($"Aluno: {nome[p]} {sobrenome[p]}");
                            if (quociente[p] >= 50){
                                resposta = "Aprovado";
                            }
                            else{
                                resposta = "Reprovado";
                            }
                            Console.WriteLine ($"Média: {quociente[p]}");
                            Console.WriteLine ($"Estado: {resposta}");
                            Console.WriteLine ("---------------------------------------------");
                        }
                            Console.WriteLine ("Clique ENTER para continuar...");
                            Console.ReadLine ();
                    break;
                    case "0":
                        Console.WriteLine ($"\n---- Agradecemos pela preferência ----\n");
                        continuacao = false;
                        validacao_inicial = false;
                    break;
                    default:

                        Console.WriteLine ($"---- Dígito Inválido ----");

                    break;
}}}}}}