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
            //Lesson1();
            //Lesson2();
            //Lesson3();
            Lesson4();
        }



        public static void Lesson1()
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
        public static void Lesson2()
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
        public static void Lesson3()
        {
            //bool, логика, сравнение, поток выполнения



            //bool логический тип 
            //операторы сравнения чисел

            //bool no = false;
            //bool yes = true;

            Console.WriteLine( 5 == 6);// 5 равно 6?
            Console.WriteLine($"5 > 6: {5 > 6}");
            Console.WriteLine($"5 < 6: {5 < 6}");
            Console.WriteLine($"5 == 6: {5 == 6}");
            Console.WriteLine($"5 >= 6: {5 >= 6}");
            Console.WriteLine($"5 <= 6: {5 <= 6}");
            Console.WriteLine($"5 > 6: {5 > 6}");
            Console.WriteLine($"5 > 6: {5 > 6}");
            //строки не  можем стравнивать 







            //поток выполнения программы 

            //стартовая точка входа 

            //if else 

            if ("22" == "22")
            {
                Console.WriteLine("22 == 22");
            }
            else
            {

            }

            // switch C#



        }
        public static void Lesson4()
        {
            //массивы и циклы

            //составить таблицу умножения 5 на 5 без массива 

            int x1_1, x1_2, x1_3, x1_4, x1_5;
            int x2_1, x2_2, x2_3, x2_4, x2_5;
            int x3_1, x3_2, x3_3, x3_4, x3_5;
            int x4_1, x4_2, x4_3, x4_4, x4_5;
            int x5_1, x5_2, x5_3, x5_4, x5_5;

            x1_1 = 1 * 1; x1_2 = 1 * 2; x1_3 = 1 * 3; x1_4 = 1 * 4; x1_5 = 1 * 5;
            x2_1 = 2 * 1; x2_2 = 2 * 2; x2_3 = 2 * 3; x2_4 = 2 * 4; x2_5 = 2 * 5;
            x3_1 = 3 * 1; x3_2 = 3 * 2; x3_3 = 3 * 3; x3_4 = 3 * 4; x3_5 = 3 * 5;
            x4_1 = 4 * 1; x4_2 = 4 * 2; x4_3 = 4 * 3; x4_4 = 4 * 4; x4_5 = 4 * 5;
            x5_1 = 5 * 1; x5_2 = 5 * 2; x5_3 = 5 * 3; x5_4 = 5 * 4; x5_5 = 5 * 5;

            Console.WriteLine($"\t1\t2\t3\t4\t5\t");

            Console.WriteLine($"\t{x1_1}\t{x1_2}\t{x1_3}\t{x1_4}\t{x1_5}\t");
            Console.WriteLine($"\t{x2_1}\t{x2_2}\t{x2_3}\t{x2_4}\t{x2_5}\t");
            Console.WriteLine($"\t{x3_1}\t{x3_2}\t{x3_3}\t{x3_4}\t{x3_5}\t");
            Console.WriteLine($"\t{x4_1}\t{x4_2}\t{x4_3}\t{x4_4}\t{x4_5}\t");
            Console.WriteLine($"\t{x5_1}\t{x5_2}\t{x5_3}\t{x5_4}\t{x5_5}\t");
            Console.ReadLine();

            //массивы 

            int[] ineDimmention = new int[10];//линейный массив, просто выделили память но не положили пока туда ничего
            double[] doubleArray = { 1.5, 22.11, 9.99 };//выделили память и положили значения

            string stringArray = "Да, это то же массив символов";
            char firstLetter = stringArray[0]; // выбераем первую букву по индексу

            //любой массив имеет длинну
            int arraySize = doubleArray.Length;
            arraySize = stringArray.Length;


            //массивы могу быть N мерными
            int[,] mTable = new int[3, 3]
                {
                    {1,2,3},
                    {4,5,6 },
                    {7,8,9 }
                };

            //трехмерный массив
            double[,,] array3D = new double[3, 3, 3]
                
                    array3D[0,0,0] = 0.5;
                    array3D[0, 0, 1] = 0.9;
                    array3D[1, 1, 1] = 1.2;

            // массивы масивов - зубчатый массивб несеметричный массив

            byte[][] month = new byte[12][];
            
            month[0] = new byte[31]; //январь
            month[1] = new byte[29]; // февраль
            month[2] = new byte[31]; //март
            //...

            //Вариант 2 таблици умножения

            int[,] m = new int[5, 5];
            m[0, 0] = 1 * 1; m[0, 1] = 1 * 2; m[0, 2] = 1 * 3; m[0, 3] = 1 * 4; m[0, 4] = 1 * 5;
            m[1, 0] = 2 * 1; m[1, 1] = 2 * 2; m[1, 2] = 2 * 3; m[1, 3] = 2 * 4; m[1, 4] = 2 * 5;
            m[2, 0] = 3 * 1; m[2, 1] = 3 * 2; m[2, 2] = 3 * 3; m[2, 3] = 3 * 4; m[2, 4] = 3 * 5;
            m[3, 0] = 4 * 1; m[3, 1] = 4 * 2; m[3, 2] = 4 * 3; m[3, 3] = 4 * 4; m[3, 4] = 4 * 5;
            m[4, 0] = 5 * 1; m[4, 1] = 5 * 2; m[4, 2] = 5 * 3; m[4, 3] = 5 * 4; m[4, 4] = 5 * 5;

            Console.WriteLine($"1\t{m[0, 0]}\t{m[0, 1]}\t{m[0, 2]}\t{m[0, 3]}\t{m[0, 4]}");
            Console.WriteLine($"2\t{m[1, 0]}\t{m[1, 1]}\t{m[1, 2]}\t{m[1, 3]}\t{m[1, 4]}");
            Console.WriteLine($"3\t{m[2, 0]}\t{m[2, 1]}\t{m[2, 2]}\t{m[2, 3]}\t{m[2, 4]}");
            Console.WriteLine($"4\t{m[3, 0]}\t{m[3, 1]}\t{m[3, 2]}\t{m[3, 3]}\t{m[3, 4]}");
            Console.WriteLine($"5\t{m[4, 0]}\t{m[4, 1]}\t{m[4, 2]}\t{m[4, 3]}\t{m[4, 4]}");

            //циклы
            //повторить операцию многократно
            
            //возрастающий цикл от 0 до 10 (невключительно)
            for (int i = 0; i < 10; i++)
            {
                if (i == 1) continue;//пропустит выполнение дальнейшего кода и передает к i = 2
                // тут код который выполняется в цикле 
            }

            //делать пока выполняется условие
            int k = 0;
            while (k<10)
            {
                Console.WriteLine(k);
                k++;
            }

            do
            {
                //ко будет выполнятся без проверки условия,т.е код выполнится хотя бы один раз
                break;
            } while (10>11);//делать пока выполняется условие


            
            string[] days = new string[7] {"Пн","Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

            foreach (string day in days)
            {
                Console.WriteLine(day);
            }


            //вариант 3
            Console.WriteLine("Таблица умножения 5 на 5 с массивом - циклы без вложенностей");
            int[,] a = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                m[0, i] = 1 * (i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                m[1, i] = 2 * (i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                m[2, i] = 3 * (i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                m[3, i] = 4 * (i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                m[4, i] = 5 * (i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\t{i+1}");
            }
            Console.WriteLine();//вставляет переход на новую строку

            int[,] z = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int i = 0; i < length; i++)
                {
                    
                }
            }


        }
        public static void Lesson5()
        {
            //методы и области видимости переменных

            //методы, зачем? что бы проще было использовать код, снизить сложность, еденица повторного использования кода, еденица идеи
            //Снизить сложность, смотря на большое кол-во деталей, и многократное использование 
            //
            //static void 


        }
    }
}
