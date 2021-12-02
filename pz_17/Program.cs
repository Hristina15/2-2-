using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    class Program
    {
        //16 вариант

        static ulong Factorial(uint n)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; m >= i; ++i)
            {
                f = f * i;
            }
            return Convert.ToUInt64(f);
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");
            Console.ReadLine();
        }
    }
}
