using System;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            int[,] A = new int[,] {
                { 1, 1, 2, 4, 5 },
                {-1, 3, 4, 0,-3 },
                {-3,-8, 2, 5,-1 }
            };
            int maxColum = 0;
            int maxPositive = 0;

            for(int i=0; i<5; i++)
            {
                int k = 0;

                for (int j=0; j<3; j++)
                {
                    Console.Write($"{A[j, i]}\t");
                    if (A[j, i] > 0)
                        k++;
                }

                if (k > maxPositive)
                {
                    maxPositive = k;
                    maxColum = i;
                }

                Console.Write($"\t\tk={k}\n");             
            }

            Console.WriteLine($"{maxColum}");            
        }
    }
}
