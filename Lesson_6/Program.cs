using System;
using System.IO;
using System.Text;

namespace Lesson_6_new
{
    class Program
    {
        static void ReadDataStaff()
        {
            using (StreamReader sr = new StreamReader(@"C:\SkillBox\data.txt"))
            {
                string line;
                string[] pattern = new string[]
            { "ID: ",
              "дата и время: ",
              "Ф.И.О: ",
              "возраст: ",
              "рост: ",
              "дата рождения: ",
              "место рождения: "};
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.Write($"{pattern[0]}{data[0]}" + " ");
                    Console.Write($"{pattern[1]}{data[1]}" + " ");
                    Console.Write($"{pattern[2]}{data[2]}" + " ");
                    Console.Write($"{pattern[3]}{data[3]}" + " ");
                    Console.Write($"{pattern[4]}{data[4]}" + " ");
                    Console.Write($"{pattern[5]}{data[5]}" + " ");
                    Console.Write($"{pattern[6]}{data[6]}");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
        static void WriteDataStaff()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\SkillBox\data.txt", true, Encoding.Unicode))
            {
                string info = string.Empty;
                Console.WriteLine("Введите ID:");
                info += $"{Console.ReadLine()}" + "#";

                string timenow = DateTime.Now.ToString();
                Console.WriteLine($"Введите Дату и время добавления записи:\n{timenow}");
                info += $"{(timenow)}" + "#";

                Console.WriteLine("Введите Ф.И.О:");
                info += $"{Console.ReadLine()}" + "#";

                Console.WriteLine("Введите возраст:");
                info += $"{Console.ReadLine()}" + "#";

                Console.WriteLine("Введите рост:");
                info += $"{Console.ReadLine()}" + "#";

                Console.WriteLine("Введите дату рождения:");
                info += $"{Console.ReadLine()}" + "#";

                Console.WriteLine("Введите место рождения:");
                info += $"{Console.ReadLine()}";
                sw.WriteLine(info);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Введите 1 или 2.\n1 — вывести данные на экран\n2 — заполнить данные и добавить новую запись \nВвод: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ReadDataStaff();
                        break;
                    case 2:
                        WriteDataStaff();
                        break;
                }
            }
        }
    }
}
