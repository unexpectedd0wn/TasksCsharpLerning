using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy.Lessons
{
    internal class Lesson3
    {
        public static void lesson3()
        {
            //строки
            Console.OutputEncoding = Encoding.UTF8;
            //тип соответсвует одной и единственной букве 
            //2 байта
            //пишется в одинарных
            //char с = 'a';

            ////тип данных который позволяет много букв
            ////строка пишется в двойных
            ////
            //string str = "пример";
            //Console.WriteLine(str.Length);//6
            //Console.WriteLine($"Размер в байтах = {str.Length*2}");
            ////string состоит из char и каждому char можно обратится по индексу 
            ////все массивы начинаются с 0
            //Console.WriteLine(str[0]);

            //операции со строкой

            ////конкатинация
            //string t1 = "Привет";
            //string t2 = "Мир";
            //string t12 = t1 + t2;
            //Console.WriteLine(t12);

            //string userInput = Console.ReadLine();
            ////может вызвать оишбку если пользователь ввел не число
            ////int input = int.Parse(userInput);
            ////Console.WriteLine(input);

            ////сроки в числа
            //int input;
            //int.TryParse(userInput, out input);
            //Console.WriteLine(input);

            //числа в строки
            int age = 20;

            //string q = "Вам " + 20 + " лет";
            string q1 = "Вам " + age + " лет";

            //string q2 = age;//не работает несовместимы типы
            //string q3 = age.ToString();//вот такое работает

            //вытащить нужный подстроку
            Console.WriteLine(q1.Substring(4,2));
            //индекс подстроки
            Console.WriteLine(q1.IndexOf("20"));

            //новый вариант
            string qqq = $"Вам {age} лет";

            //старый вариант 
            qqq = string.Format("Вам {0} лет {1}", age, "!");

            string.IsNullOrEmpty("111");
            string.IsNullOrEmpty("");

        }
    }
}
