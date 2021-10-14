using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //16 вариант

            int[] a = new int[10];
            int[] result = new int[10];
            var rand = new Random();
            //Задаем интервал 
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0, 50);
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }


            int[] tmp1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                tmp1[i] = a[i];
            }
            //Отсартируем по возрастанию и убыванию
            Array.Sort(tmp1);
            for (int i = 0; i < tmp1.Length; i++)
            {
                result[i] = tmp1[i];
            }

            int[] tmp2 = new int[5];
            for (int i = 0; i < a.Length / 2; i++)
            {
                tmp2[i] = a[i + 5];
            }

            Array.Sort(tmp2);
            tmp2 = tmp2.Reverse().ToArray();
            for (int i = 0; i < tmp2.Length; i++)
            {
                result[i + 5] = tmp2[i];
            }

            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
