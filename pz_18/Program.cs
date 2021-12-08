using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_18
{
    class Program
    {
        //16 вариант
        static float ArithmeticProgression(int n) // 1 задание
        { // создаем новый метод, в котором расчитываем арифметическую прогерессию
            if (n == 1) return 7;
            else if (n > 0) return ArithmeticProgression(n - 1) - 0.1f;
            else return ArithmeticProgression(n + 1) + 0.1f;
        }
        static float GeometricProgression(int k) // 2 задание
        { // создаем новый метод, в котором расчитываем геометрическую прогерессию
            if (k == 1) return 13;
            else if (k > 0) return GeometricProgression(k - 1) * 3;
            else return GeometricProgression(k + 1) * 3;
        }
        static void MyAscRec(int m, int b)
        { //3 задание

            if (m < b) return;
            MyAscRec(m - 1, b);
            Console.WriteLine(m);
        }
        static double Summ(int s) // 4 задание
        {
            if (s <= 1) return s;
            return s + Summ(s - 1);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1, введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ArithmeticProgression(n));

            Console.WriteLine("Задание 2, введите число: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ArithmeticProgression(k));

            Console.WriteLine(" 3 задание \n ");
            Console.WriteLine("Введи 1 число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи 2 число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            MyAscRec(m, b);
            Console.ReadLine();

            Console.WriteLine(" Задание 4, введите число: ");
            int s = 4;
            Console.WriteLine(Summ(s));
            Console.ReadLine();
        }
    }   
}
