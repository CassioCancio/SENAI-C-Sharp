using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra aí meu consagrado!!!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;

            string[] palavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0 ; i++)
            {
                palavrasUsuario[i] = Console.ReadLine();

                if (--maxPalavrasUsuario != 0)
                {
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma bb!!!!");
                }else
                {
                    System.Console.WriteLine("Valeu jovem! Agora deixa cmg rs");
                }
            }

                string[,] matrizPalavras = {
                                                {"melancia","sou","","é","laranja"},
                                                {"de","computador","","comprar","maça"},
                                                {"coisas","","riu","teclado","dele"},
                                                {"feijão","da","garrafa","","celular"},
                                                {"","presunto","gosto","queijo","borracha"}
                };

                for (int i = 0; i < matrizPalavras.GetLength(0); i++){
                    for (int j = 0; j < matrizPalavras.GetLength (0); j++){
                        if("".Equals(matrizPalavras[i,j])){
                            matrizPalavras[i,j] = palavrasUsuario[i];
                        }
                    }
                }

                string frase = "";

                Random r = new Random();
                for(int i = 0; i < maxPalavrasFrase; i++){
                    frase += matrizPalavras[r.Next(matrizPalavras.GetLength(0)),
                                            r.Next(matrizPalavras.GetLength(0))]
                                            + " ";
                }
                Console.WriteLine("Minha frase é: \n" + frase);

        }
    }
}
