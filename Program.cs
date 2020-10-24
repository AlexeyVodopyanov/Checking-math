using System;
using static System.Console;
namespace a1
{
    class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.Blue;
            ForegroundColor = ConsoleColor.White;
            WriteLine("Привет");
            WriteLine("Давай посчитаешь математика");
            ResetColor();
            int a;
            Write("12 * 12 = ");
            a = Convert.ToInt32(ReadLine());
            if (a == 144)
            {
                BackgroundColor = ConsoleColor.Green;
                ForegroundColor = ConsoleColor.White;
                WriteLine("Верно!");
                ResetColor();
            }
            else
            {
                BackgroundColor = ConsoleColor.Red;
                ForegroundColor = ConsoleColor.White;
                WriteLine("Не верно!");
                ResetColor();
            }
        }
    }
}