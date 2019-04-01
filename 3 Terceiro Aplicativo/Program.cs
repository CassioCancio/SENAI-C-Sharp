using System;

namespace Terceiro_Aplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            string clima;
            string segundo;

            Console.WriteLine("Planejamento do dia");

            Console.WriteLine("Digite a previsão do tempo");
            clima = Console.ReadLine().ToLower();

        
            if (clima.Equals("calor"))
            {
                Console.WriteLine("Vamos à praia");
            } else if (clima.Equals("frio"))
            {
                Console.WriteLine("Vamos à montanha");
            }else{
                Console.WriteLine("Você curte a Steam?");
                segundo = Console.ReadLine();
            
            if (segundo.Equals("sim"))
            {
                Console.WriteLine("Vamos jogar");
            }
            else
            {
                Console.WriteLine("Vamos para a Netflix");
            }
            }
        }
    }
}
