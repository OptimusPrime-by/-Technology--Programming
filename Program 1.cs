using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace name
{

    class Program
    {
        private static object random;


        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine(Console.LargestWindowHeight);
            Console.WriteLine(Console.LargestWindowWidth);

            Console.SetWindowSize(40, 30);
            Console.BackgroundColor = (ConsoleColor)r.Next(0, 16);
            Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
            Console.Clear();

            Console.Title = "name";

            Console.WriteLine("Введите свою фамилию:");
            String? Firstname = Console.ReadLine();
            Console.WriteLine("Введите свое имя:");
            String? name = Console.ReadLine();
            Console.WriteLine($"Привет {Firstname} {name}");
            Console.Title = Firstname + " " + name;
            Console.Beep();
            Thread.Sleep(3000);

            Console.WriteLine("Caps Losk: " + (Console.CapsLock ? "On" : "off"));
            Console.WriteLine("Num Lock: " + (Console.NumberLock ? "On" : "off"));
            /*Cursor.Hide(false);*/
            Console.WriteLine("Определим координаты точки пересечения двух. Для этого введите данные a,b,c,d,где (a≠c): ");

            double a, b, c, d;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c (которое не равно a): ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите d: ");
            d = Convert.ToDouble(Console.ReadLine());

            if (a != c)
            {
                double x = Math.Abs(b - d) / (a - c);
                double y = c * x + d;
                Console.WriteLine("x= " + x);
                Console.WriteLine("y= " + y);
            }
            else
            {
                Console.WriteLine(" Указано же, что a недолжно быть таким же как с");
            }

            Console.WriteLine("Сеанс окончен");
            Console.WriteLine("Удачного дня");
        }
    }







}