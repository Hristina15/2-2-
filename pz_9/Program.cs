using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //16 вариант
            int[,] A = new int[10, 10];
            int[] S = new int[10];
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = rand.Next(100);
                }
            }

            //сумма элемента по столбцу
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    S[i] += A[j, i];
                }
            }

            foreach (int B in S)
            {
                Console.WriteLine(B);
            }
            Console.ReadLine();
        }
    }
}
