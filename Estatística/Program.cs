using System;

namespace Estatística {
    class Program {
        static void Main (string[] args) {
            int masc = 0;
            int femin = 0;
            float numM = 0;
            float numF = 0;
            float pesoM = 0;
            float pesoF = 0;
            float mediaIM = 0;
            float mediaIMF;
            float mediaIF = 0;
            float mediaIFF;
            float mediaPM = 0;
            float mediaPMF;
            float mediaPF = 0;
            float mediaPFF;
            bool confirmacao = true;
            bool confirmaca = true;
            bool confirmac = true;
            bool confirma = true;
            
            Console.WriteLine ("Calculadora de estatística");
            for (int i = 0; i < 2; i++) {
                Console.WriteLine ("Digite o sexo (M ou F) da pessoa {0}", i + 1);
                string sexo = Console.ReadLine ().ToLower ();
                if (sexo.Equals ("m")) {
                    ++masc;
                    confirmaca = true;
                    while (confirmaca) {
                        Console.WriteLine ("Digite o idade da pessoa");
                        string pe = Console.ReadLine ();
                        if (float.TryParse (pe, out numM)) {
                            confirmaca = false;
                        } else {
                            Console.WriteLine ("Valor inválido");
                        }
                    }
                    mediaIM += numM;
                    confirmacao = true;
                    while (confirmacao) {
                        Console.WriteLine ("Digite o peso da pessoa");
                        string p = Console.ReadLine ();
                        if (float.TryParse (p, out pesoM)) {
                            confirmacao = false;
                        } else {
                            Console.WriteLine ("Valor inválido");
                        }
                    }
                    mediaPM += pesoM;
                    Console.WriteLine ("Dado salvo");
                } else if (sexo.Equals ("f")) {
                    ++femin;
                    while (confirma) {
                        Console.WriteLine ("Digite o idade da pessoa");
                        string ph = Console.ReadLine ();
                        if (float.TryParse (ph, out numF)) {
                            confirma = false;
                        } else {
                            Console.WriteLine ("Valor inválido");
                        }
                    }
                    mediaIF += numF;
                    while (confirmac) {
                        Console.WriteLine ("Digite o peso da pessoa");
                        string pf = Console.ReadLine ();
                        if (float.TryParse (pf, out pesoF)) {
                            confirmac = false;
                        } else {
                            Console.WriteLine ("Valor inválido");
                        }
                    }
                    mediaPF += pesoF;
                    Console.WriteLine ("Dado salvo");
                } else {
                    --i;
                    Console.WriteLine ("Digite um valor válido");
                }
            }
            mediaIMF = mediaIM / masc;
            mediaIFF = mediaIF / masc;
            mediaPMF = mediaPM / masc;
            mediaPFF = mediaPF / masc;
            Console.WriteLine ("A quantidade de homens é " + masc);
            Console.WriteLine ("A quantidade de mulheres é " + femin);
            Console.WriteLine ("A média das idades masculinas é " + mediaIMF);
            Console.WriteLine ("A média das idades femininas é " + mediaIFF);
            Console.WriteLine ("A média dos pesos masculinos é " + mediaPMF);
            Console.WriteLine ("A média dos pesos femninos é " + mediaPFF);
        }
    }
}