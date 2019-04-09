using System;

namespace Com_for_agr {
    class Program {
        static void Main (string[] args) {

            int[] valores = { 100, 50, 20, 10, 5, 2, 1 };
            int[] numero_de_notas = new int[7];
            int saque;
            int i;
            DateTime data = DateTime.Now;
            string teste;

            do {
                Console.WriteLine ("---------------------- Banco Eletrônico -----------------------");
                Console.WriteLine ("Digite um valor válido para sacar (Ele deve ir de 1 a 1000000):");
                teste = Console.ReadLine ();
                if (int.TryParse (teste, out saque)) { saque = int.Parse (teste); }
            } while (saque < 1 || saque > 1000000);

            for (i = 0; i <= 6; i++) {
                numero_de_notas[i] = saque / valores[i];
                saque = saque % valores[i];
            }

            i = 0;
            Console.WriteLine ("\nVocê receberá:");

            foreach (var resultado_final in numero_de_notas) {
                Console.WriteLine ($"{resultado_final} notas de {valores[i]} às {data:HH:MM}");
                i++;
            }
        }
    }
}