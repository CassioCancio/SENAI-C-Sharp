using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool usuario = true;
            bool resposta = true;
            bool respost = true;
            bool respos = true;
            bool respo = true;
            
            while(resposta)
            {
            while(respost)
            {
            while(respos)
            {
            while(respo)
            {

            Console.WriteLine("\n---------------------------------------------------- Menu ----------------------------------------------------");

            Console.WriteLine("\n Digite \n\n 1 - Para ir ao LOGIN\n 2 - Para ir aos CONTATOS\n 3 - Para ir à LISTA DE COMENTÁRIOS\n 9 - Para SAIR do programa\n");
            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Área de LOGIN \n \nDeseja voltar ao menu?");
                    resposta = bool.Parse(Console.ReadLine());
                    usuario = resposta.Equals("sim") ? true : false;

                    break;

                case 2:
                    Console.WriteLine("Área de CONTATOS \n \nDeseja voltar ao menu?");
                    respost = bool.Parse(Console.ReadLine());
                    usuario = respost.Equals("sim") ? true : false;

                    break;

                case 3:
                    Console.WriteLine("Área de COMENTÁRIOS \n \nDeseja voltar ao menu?");
                    respos = bool.Parse(Console.ReadLine());
                    usuario = respos.Equals("sim") ? true : false;

                    break;

                case 9:
                    usuario = false;
                    break;

                default:
                    Console.WriteLine("Você digitou um número inválido \n \nDeseja voltar ao menu?");
                    respo = bool.Parse(Console.ReadLine());
                    usuario = respo.Equals("sim") ? true : false;

                    break;
            }
            }
            }
            }
            }
        }
    }
}
