using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pz_14
{
    class Program
    {
        const string path = @"C:\Users\Христина>\Desktop\"; // указываем файл
        static void Main(string[] args)
        {
            // 16 Вариант
            Console.Write("Введите имя файла:");
            string str = Console.ReadLine();

            FileStream file = new FileStream(path + str + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //Создаем файл на чтение
            StreamWriter writer = new StreamWriter(file);

            string[] srt = new string[6];
            srt[0] = Console.ReadLine();
            int min_lenght_of_srt = srt[0].Length;
            for (int i = 1; i < 6; i++)
            {
                srt[i] = Console.ReadLine();
                if (srt[i].Length < min_lenght_of_srt)
                    min_lenght_of_srt = srt[i].Length;
            }

            for (int i = 0; i < 6; i++)
                writer.WriteLine(srt[i].Remove(min_lenght_of_srt - 1));
            writer.Close();

            
        }
    }
}
