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

        static void Factorial(uint n)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            uint f = 1;
            for (uint i = 1; m >= i; ++i)
            {
                f = f * i;
            }
            Console.WriteLine($"Факториал числа {n} равен {f}");
        }

        static void Main(string[] args)
        {
            Console.Write("n = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Factorial(n);
            Console.ReadLine();
        }
    }
}
