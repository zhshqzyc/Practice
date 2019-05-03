using System;

namespace PrintPattern
{
    class PrintPattern
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = n;
            while (m > 0)
            {
                PrintNumbers(n,m);
                Console.Write("$");
                m--;
            }
            Console.WriteLine(); 
        }

        static void PrintNumbers(int n, int m)
        {
            int length = m;
            while (n > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(n + " ");
                }
                n--;
            }
        }
    }
}
