using System;

namespace AB6_Aufgabe1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, j;


            for (i = 13; i <= 29; i += 4)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for (j = 2; j >= -4; j -= 1)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();

            for (i = 2000; i <= 6000; i += 1000)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            for(j = 5; j <=13; j += 2)
            {
                Console.Write("Z" + j + " ");
            }
            Console.WriteLine();

            for(i = 1; i <= 3; i++)
            {
                Console.Write("ab" + i + " ");
            }

            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
