using System;

namespace Lab6
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int[] B = new int[] { 3, 5, 6, 10, 10 };
            // [1, 2, 3, 4, 5]
            //i ^

            // [3, 5, 6, 10, 10]
            //j ^

            int[] RES = new int[10];
            int k = 5;

            for(int i=0; i<5; i++)
            {
                RES[i] = A[i];
            }

            for(int i=0; i<5; i++)
            {
                int b = B[i];
                bool inRes = false;

                for(int j=0; j<9; j++)
                {
                    if (RES[j] == b)
                        inRes = true;
                }
                if(!inRes)
                {
                    RES[k] = b;
                    k++;
                }
            }
            Console.WriteLine(k);

            int[] C = new int[k];
            for (int i = 0; i < k; i++)
            {
                C[i] = RES[i];
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{C[i]}, ");
            }
                
        }
    }
}
