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


            int[] Z = new int[35];
            int S = 0, P = 0, R = 0;
            Random rnd = new Random();
            Console.Write("Массив: ");
            for (int i = 0; i < Z.Length; i++)
            {
                Z[i] = rnd.Next(0, 35);
                Console.Write(Z[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < Z.Length; i++)
                if (((Z[i] % 2) == 0) && (Z[i] < 3))
                    S += Z[i];

            for (int i = 0; i < Z.Length; i++)  // Длинна текста (кол-во символов)
                if (((Z[i] % 2) != 0) && (Z[i] > 1))
                    P += Z[i];
            R = P + S;
            Console.WriteLine("Сумма = " + R);


            Console.WriteLine("Сеанс окончен");
            Console.WriteLine("Удачного дня");
        }
    }







}