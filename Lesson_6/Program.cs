using System;
using System.IO;

namespace Lesson_6
{
    class Program
    {
        static string[] Read()
        {
            string[] lines = File.ReadAllLines(@"C:\SkillBox\data.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{lines[i]}");
            }
            Console.ReadKey();
            return lines;
        }
        static string[] Write(string[] a)
        {
            File.AppendAllLines(@"C:\SkillBox\data.txt", a);
            return a;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("СПРАВОЧНИК СОТРУДНИКОВ.\nВведите 1 / 2 \n1 — вывести данные на экран\n2 — заполнить данные и добавить новую запись \nВвод:");
                int choice = int.Parse(Console.ReadLine());
                string[] arrayData = new string[] { "Введите ID:", "Введите Дату и время добавления записи:", "Введите Ф.И.О:", "Введите возраст:", "Введите рост:", "Введите дату рождения:", "Введите место рождения:" };
                string[] arrayNewdata = new string[arrayData.Length];
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Read();
                        break;
                    case 2:
                        for (int i = 0; i <= arrayData.Length - 1; i++)
                        {
                            Console.WriteLine($"{arrayData[i]}");
                            string a = Console.ReadLine();
                            arrayNewdata[i] = a;
                        }
                        Write(arrayNewdata);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
