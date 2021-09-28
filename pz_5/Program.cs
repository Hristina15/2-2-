using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первое задание (16 вариант)
            Console.WriteLine("Первое задание");
            for (int i = 10; i <= 90; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            

            // Второе задание 
            Console.WriteLine("Второе задание");
            char a = 'Б';
            for (int i = 0; i < 6; i++)
            {
                Console.Write(a++);
            }
            Console.WriteLine();

            //Третье задание
            Console.WriteLine("Третье задание");
            for (int i = 0; i < 7; i++);
            {
                Console.WriteLine("#####");
            }
            Console.WriteLine();

            //Четвертое задание
            Console.WriteLine("Четвертое задание");
            for (int j = 0; j <= 100; j++)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine(j + " ");
                }
            }
            Console.WriteLine();

            //Пятое задание
            Console.WriteLine("Пятое задание");
            for (int i = 3, j = 60; i - j != 57; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }
            Console.ReadLine();
        }
    }
}
