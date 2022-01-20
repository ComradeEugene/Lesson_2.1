using System;
using static System.Console;

namespace Lesson_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string FullName = "Ленин Вланимир Ильич";
            string Mail = "RevolutionBoss@mushroom.ru";
            int Age = 35;
            double Programming = 99.9;
            double Mathematics = 100.0;
            double Physics = 100.0;
            double Sum = Physics + Mathematics + Programming;
            double Average = Sum / 3;
            string Form = "ФИО: {0}\nВозраст: {1}\nEmail: {2}\nБаллы по " +
                          "программированию: {3}\nБаллы по математике: {4}" +
                          "\nБаллы по физике: {5}";

            WriteLine(Form,
                      FullName,
                      Age,
                      Mail,
                      Programming,
                      Mathematics,
                      Physics);
            ReadKey();
            WriteLine($"Сумма баллов: {Sum}\nСреднее" +
                      $"арифметическое: {Average}");
            ReadKey();
        }
    }
}
