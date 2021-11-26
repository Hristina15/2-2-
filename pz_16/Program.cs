using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_16
{
    class Program
    {
        static void InvertDigit(ref int K) //создаем новый метод, в котром создаем параметр целого числа
        {
            // 16 вариант
            string str = Convert.ToString(K);
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            K = int.Parse(str);
        }
        static void Main(string[] args) //в этом медоте меняется порядок следований цифр из пяти данных целых чисел
        {
            int m;
            for(int i = 0; i<5;i++)
            {
                m = int.Parse(Console.ReadLine());
                InvertDigit(ref m);
                Console.WriteLine(m);
                Console.ReadLine();
            }
        }
    }
}
