using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SBeregovoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lesson2();
            //Lesson3();
        }

        public static void Lesson2()
        {
            //примытивные типы данных

            //
            //int x = 10;
            ////выделить память int и положить переменную x число 
            ////сколько выделить памяти отвечает int 
            ////можем полоть отризацательное
            //int y = -20;

            ////1 байт
            //byte b = 255;//max 
            ////byte c = 256;//value can not be covnverted to byte
            ////byte bminus = -255;//нельзя записать отризательное число и предпологается строгоположительное число
            ////sbyte sb = 255; //знаковый байт, может быть отризательным, но не может быть размером 255, вмещает 8 bit, но 8 символ хранит информацию о знаке
            ////sbyte sb = 127;//max
            ////sbyte sb = -127; но можем написать вот так 

            ////2 байта
            ////short s = short.MaxValue;32767 знаковый тип
            ////ushort us = ushort.MaxValue;65535 беззнаковый тип

            ////4 байта
            //int i = int.MinValue;//беззнаковое
            //uint ui = uint.MaxValue;//знаковое

            ////8 байт
            //long l = long.MaxValue;//беззнаковое (2 раза больше)
            //ulong ul = ulong.MaxValue;//знаковое


            //int sum = 100 + 200;
            ////byte sum1 = 100 + 200;//не работает, нарушили размерность, превысили лимит который может влезть 

            ////в int не может быть сохранена дробная часть 
            ////для дробных частей можно использовать float или double

            ////4 байта
            //float f = float.MaxValue;

            ////8 байт
            //double d = double.MaxValue;




        }
        public static void Lesson3()
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
            Console.WriteLine(q1.Substring(4, 2));
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
