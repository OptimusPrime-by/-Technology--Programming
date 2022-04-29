
//Земля это колыбель человечества. «Я бы не сказал, что у меня мало страхов. На самом деле, я бы хотел, чтобы моих эмоций страха было меньше, потому что они очень отвлекают, и сжигают мою нервную систему». «Когда я что-то говорю, это обычно случается. Может быть,
//не по расписанию, но обычно так бывает». – Илона Маскаа.
// Длинное тире Alt+0151

using System;
using System.Linq;

namespace task
{
    class Program
    {
        static bool Checker(string String)
        {
            string[] separator = { "...", ".", "!", "?" };
            string[] sentences = String.Split(separator, System.StringSplitOptions.None);
            bool check = true;
            if (String.Length > 10)
            {
                Console.WriteLine("Длина строки должна быть не больше 200 символов");
                check = false;
            }

            if (sentences.Last().Length != 0)
            {
                check = false;
                Console.WriteLine("Нет точки в конце");
            }
            else sentences = sentences.Take(sentences.Length - 1).ToArray();

            if (check && sentences.Length == 2)
            {
                check = false;
                Console.WriteLine("Только одно предложение в строке");
            }
            if (check && Char.IsLower(sentences[0].ToCharArray()[0]))
            {
                check = false;
                Console.WriteLine("Предложения должны начинаться с заглавной буквы");
            }

            for (int i = 0; i < String.Length; i++)
            {
                if (check && (String[i] == '.' || String[i] == '?' || String[i] == ',' || String[i] == '!' || String[i] == ';' || String[i] == ':') && String[i - 1] == ' ')
                {
                    check = false;
                    Console.WriteLine("Перед знаком препинания не должно быть пробела");
                }
                /* if (check && String[i] == '-' && String[i + 1] == ' ' && String[i - 1] == ' ')
                 {
                     check = false;
                     Console.WriteLine("Дефис написан неверно");
                 }*/
                if (check && String[i] == '—' && String[i + 1] != ' ' && String[i - 1] != ' ')
                {
                    check = false;
                    Console.WriteLine("Тире написано неверно");
                }

                if (check && String[i] == ' ' && String[i + 1] == ' ')
                {
                    check = false;
                    Console.WriteLine("Два пробела подряд");
                }
            }
            return check;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Решение поставленной задачи: По условию, если L-четная и больше либо равна 10 символам,то удаляем все пробелы");
            
            Console.Write("введите строку: \n");
            string originalString = Console.ReadLine();
            
            bool bol = Checker(originalString);
            if (((originalString.Length % 2) == 0) && (originalString.Length >= 10))

            {

                Console.WriteLine("Кол-во символов в строке:" + originalString.Length);
                Console.WriteLine("Введенная строка: " + originalString);
                originalString = originalString.Replace(" ", "");//тут удаление, точнее замена, не важно:)
                Console.WriteLine("Преобразованная строка: " + originalString);

            }
            else
            {
                Console.WriteLine(originalString.Length);
                Console.WriteLine("Ошибка, так как кол-ко символов нечетное число либо введено число меньше 10 символов");
            }
            





        }


    }
}






//Console.ReadKey();
