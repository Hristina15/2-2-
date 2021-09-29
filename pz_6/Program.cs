using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 16 вариант
            int x = -2;
            int t = int.Parse(Console.ReadLine());
            while (x <= 12)
            {
                if (x < 0)
                {
                    Console.WriteLine(t);
                }
                else if (x >= 10)
                {
                    Console.WriteLine(t * 2);
                }    
                else
                {
                    Console.WriteLine(t * x);
                }
                x += 2;
            }
            Console.ReadLine();
        }
    }
}
