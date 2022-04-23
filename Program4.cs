using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переменная pattern задает регулярное выражение для проверки адреса электронной почты.
            string pattern = @"^((\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)\s*[;,.]{0,1}\s*)+$";

            var data = new string[]
            {
                 "simkavasek@gmail.com",
                 "archi@mail.com",
                "bob@yahoo.com",
                "+13435465566",
                "sam@yandex.ru",
                "+43743989393",
                ".gmcrmig@mao.ru",
                "(j,,,,,,,ke)",
                "(4hmx@gmai.com",
                "9vasek.by@gmai.com"

            };
        // Ну тут вы выводим в консоль просто данную фразу
        Console.WriteLine("Email List");
            //мы проходим по массиву строк и определяем,
            //какие строки соответствуют этому шаблону, то есть представляют валидный адрес электронной почты. 
            //Для проверки соответствия строки шаблону используется метод IsMatch. Последний параметр указывает, что регистр можно игнорировать.
            for (int i = 0; i < data.Length; i++)
            {
                if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(data[i]);
                }

            }
        }
    } }
            
       