using System;

namespace SENAIzinho_Manha {
    class Program {
        static void Main (string[] args) {
            Aluno[] alunos = new Aluno[10];
            int alunosCadastrados = 0;
            Sala[] salas = new Sala[5];
            int salasCadastradas = 0;
            bool querSair = false;

            System.Console.WriteLine ("===================================");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine ("        *** SENAIzinho ***         ");
            Console.ResetColor ();
            System.Console.WriteLine ("         Seja bem-vindo(a)         ");
            System.Console.WriteLine ("===================================");

            do {
                System.Console.WriteLine ("===================================");
                System.Console.WriteLine ("|| Digite sua opção:             ||");
                System.Console.WriteLine ("||  1 - Cadastrar Aluno          ||");
                System.Console.WriteLine ("||  2 - Cadastrar Sala           ||");
                System.Console.WriteLine ("||  3 - Alocar Aluno             ||");
                System.Console.WriteLine ("||  4 - Remover Aluno            ||");
                System.Console.WriteLine ("||  5 - Verificar Salas          ||");
                System.Console.WriteLine ("||  6 - Verificar Alunos         ||");
                System.Console.WriteLine ("||  0 - Sair                     ||");
                System.Console.WriteLine ("===================================");

                System.Console.Write ("Código: ");
                string codigo = Console.ReadLine ();

                switch (codigo) {
                    case "1":
                        if (alunosCadastrados < 11) {
                            Aluno aluno = new Aluno ();

                            System.Console.WriteLine ("Digite o nome do aluno");
                            aluno.nome = Console.ReadLine ();

                            System.Console.WriteLine ("Digite a data de nascimento (dd/mm/aaaa)");
                            aluno.dataNascimento = DateTime.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite o nome do curso");
                            aluno.curso = Console.ReadLine ();

                            // Console.WriteLine("Digite o numero da sala");
                            // aluno.numeroSala = int.Parse(Console.ReadLine());

                            alunos[alunosCadastrados] = aluno;

                            alunosCadastrados++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine ("Cadastro de Aluno concluído!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                        } else {
                            System.Console.WriteLine ("------ Número máximo de cadastros realizados -----");
                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        }
                        break;

                    case "2":
                        Sala sala = new Sala ();

                        System.Console.WriteLine ("Digite o número da sala");
                        sala.numeroSala = int.Parse (Console.ReadLine ());

                        System.Console.WriteLine ("Digite a capacidade total");
                        sala.capacidadeTotal = int.Parse (Console.ReadLine ());

                        sala.capacidadeAtual = sala.capacidadeTotal;

                        sala.alunos = new string[sala.capacidadeTotal];

                        salas[salasCadastradas] = sala;

                        salasCadastradas++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine ("Cadastro de Sala concluído!");
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();
                        break;

                    case "3":
                        if (alunosCadastrados == 0) {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine ("    --- Nenhum aluno cadastrado ---      ");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        } else if (salasCadastradas == 0) {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine ("    --- Nenhum sala cadastrado ---      ");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAluno = Console.ReadLine ();
                        Aluno alunoRecuperado = null;
                        foreach (var item in alunos) {
                            if (item != null && nomeAluno.Equals (item.nome)) {
                                alunoRecuperado = item;
                                break;
                            }
                        }

                        if (alunoRecuperado == null) {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine ($"Aluno {nomeAluno} não encontrado!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        System.Console.WriteLine ("Digite o número da sala");
                        int NumeroSala = int.Parse (Console.ReadLine ());
                        Sala salaRecuperada = null;
                        foreach (Sala item in salas) {
                            if (item != null && NumeroSala.Equals (item.numeroSala)) {
                                salaRecuperada = item;
                                break;
                            }
                        }

                        if (salaRecuperada == null) {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            System.Console.WriteLine ($"Sala {NumeroSala} não encontrada!");
                            Console.ResetColor ();

                            System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                            Console.ReadLine ();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine (salaRecuperada.AlocarAluno (alunoRecuperado.nome));
                        Console.ResetColor ();

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        Console.ReadLine ();

                        break;
                    case "4":

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeRemover = Console.ReadLine ();
                        foreach (var item in alunos) {
                            if (item != null && nomeRemover.Equals (item.nome)) {
                                item.nome = "";
                                item.dataNascimento = new DateTime ();
                                item.curso = "";

                                Console.ForegroundColor = ConsoleColor.Green;
                                System.Console.WriteLine ("--- Aluno removido com sucesso ---");
                                Console.ResetColor ();
                                continue;
                            } else {

                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.WriteLine ($"Aluno {nomeRemover} não encontrado!");
                                Console.ResetColor ();
                                System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                                Console.ReadLine ();

                                continue;
                                break;
                            }
                        }

                        // if (alunoRecuperado == null) {
                        //     Console.ForegroundColor = ConsoleColor.DarkRed;
                        //     System.Console.WriteLine ($"Aluno {nomeAluno} não encontrado!");
                        //     Console.ResetColor ();

                        //     System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        //     Console.ReadLine ();
                        //     continue;
                        // }

                        // System.Console.WriteLine ("Digite o número da sala");
                        // int NumeroSala = int.Parse (Console.ReadLine ());
                        // Sala salaRecuperada = null;
                        // foreach (Sala item in salas) {
                        //     if (item != null && NumeroSala.Equals (item.numeroSala)) {
                        //         salaRecuperada = item;
                        //         break;
                        //     }
                        // }

                        // if (salaRecuperada == null) {
                        //     Console.ForegroundColor = ConsoleColor.DarkRed;
                        //     System.Console.WriteLine ($"Sala {NumeroSala} não encontrada!");
                        //     Console.ResetColor ();

                        //     System.Console.WriteLine ("Aperte ENTER para voltar ao menu");
                        //     Console.ReadLine ();
                        //     continue;
                        // }
                        break;

                    case "5":
                        foreach (var item in salas) {
                            if (item != null) {
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Número da sala: {item.numeroSala}");
                                System.Console.WriteLine ($"Vagas disponíveis: {item.capacidadeAtual}");
                                System.Console.WriteLine ($"Alunos: {item.ExibirAlunos()}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }

                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();
                        break;

                    case "6":
                        foreach (var item in alunos) {
                            if (item != null && item.nome != ""){
                                System.Console.WriteLine ("-----------------------------------------------------");
                                System.Console.WriteLine ($"Nome do aluno: {item.nome}");
                                System.Console.WriteLine ($"Curso: {item.curso}");
                                System.Console.WriteLine ("-----------------------------------------------------");
                            }
                        }
                        System.Console.WriteLine ("Aperte ENTER para voltar ao menu principal");
                        Console.ReadLine ();

                        break;

                    case "0":
                        System.Console.WriteLine ("\n------ Obrigado por usar o programa ------\n");
                        querSair = true;
                        break;

                    default:
                        System.Console.WriteLine ("\n------ Digite um valor válido ------\n");
                        Console.ReadLine ();
                        break;

                }
            } while (!querSair);
        }
    }

}