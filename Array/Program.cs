using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int x = -1;
            int [] idades ={16, 15, 14, 13, 12, 11, 10, 9, 8, 7};

            for (i= 0; i <= 9; i++)
            {
                x++;
                if (idades [x] % 2 != 0)
                {
                    Console.WriteLine(idades [x]);
                }
                else{
                } 
            }
        }
    }
}
