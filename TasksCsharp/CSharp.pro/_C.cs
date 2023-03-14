using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp.CSharp.pro
{
    internal class _C
    {
        public static void C1()
        {
            ////C1.1.Напечатать ряд чисел 20 в виде:
            ////20 20 20 20 20 20 20 20 20 20.
            ///
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("20 ");
            //}
            //Console.WriteLine(".");

            ////C1.2.Составить программу вывода любого числа любое заданное число раз в виде, 
            ///аналогичном показанному в предыдущей задаче.

            //Console.WriteLine("Please, enter any number");
            //double number = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter how mutch times to ");
            //double n = double.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(number);
            //}

            ////C1.3.Напечатать «столбиком»:
            ////а) все целые числа от 20 до 35;
            ///

            //for (int i = 20; i < 36; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////б) квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);
            ///
            //Console.WriteLine("Please, enetr b: ");
            //int b = int.Parse(Console.ReadLine());
            //for (int i = 10; i < b; i++)
            //{
            //    //Console.WriteLine(i * i + " ");

            //    Console.WriteLine(Math.Pow(i,2));
            //}

            ////в) третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);

            //Console.WriteLine("Please, enetr a: ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i = 50; i > a; i--)
            //{


            //    Console.WriteLine(Math.Pow(i, 3));
            //}


            ////г) все целые числа от a до b(значения a и b вводятся с клавиатуры; b < a).

            //Console.WriteLine("Please, enter a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b:");
            //int b = int.Parse(Console.ReadLine());

            //if (b> a)
            //{
            //    Console.WriteLine("b should be greater than a");    
            //}
            //else
            //{
            //    for (int i = a; i > b; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////C1.4.Напечатать числа следующим образом:
            ////а)
            ////10 10.4
            ////11 11.4
            ////25 25.4

            //for (int i = 10; i <= 25; i++)
            //{
            //    Console.WriteLine($"{i} {i}.4");
            //    //OR
            //    Console.WriteLine($"{i} {i + 0.4}");
            //}

            //б)
            //25 25.5 24.8
            //26 26.5 25.8
            //...
            //35 35.5 34.8

            //for (int i = 25; i <= 35; i++)
            //{

            //    //OR
            //    Console.WriteLine($"{i} {i + 0.5} {i - 0.2}");
            //}

            ////C1.5.Напечатать числа следующим образом:
            ////а)
            ////21 19.2
            ////20 18.2
            ////...
            ////10 8.2

            //for (int i = 21; i >= 10; i--)
            //{
            //    Console.WriteLine($"{i} {i - 1.8}");
            //}
            ////б)
            ////45 44.5 44.2
            ////44 43.5 43.2
            ////...
            ////25 24.5 24.2

            //for (int i = 45; i >= 25; i--)
            //{
            //    Console.WriteLine($"{i} {i - 0.5} {i - 0.8}");
            //}

            ////C1.6.Напечатать числа следующим образом:
            ////а)

            ////21 20.4
            ////22 21.4
            ////...
            ////35 34.4
            ///
            /// 
            //for (int i = 21; i <= 35; i++)
            //{
            //    Console.WriteLine($"{i} {i - 0.6}");
            //}
            ////б)

            ////16 15.5 16.8
            ////17 16.5 17.8
            ////...
            ////24 23.5 24.8
            ///
            //for (int i = 16; i <= 24; i++)
            //{
            //    Console.WriteLine($"{i} {i - 0.5} {i + 0.8}");
            //}

            //C1.7.Одна штука некоторого товара стоит 55,99 руб.Напечатать таблицу стоимости 2, 3, …, 20 штук этого товара.

            //for (int i = 1; i <= 20; i++)
            //{
            //    double price = 55.99;
            //    Console.WriteLine($"The price for the qty = {i} will be {Math.Round(price*i)} rub");
            //}

            //C1.8.Напечатать таблицу соответствия между весом в фунтах и весом в килограммах для значений 1, 2, …, 10 фунтов(1 фунт = 453 г).
            //for (int i = 1; i <= 10; i++)
            //{
            //    double kg = 453;
            //    Console.WriteLine($"{i} pound = {i*kg} g ");
            //}

            ////C1.9.Напечатать таблицу перевода расстояний в дюймах в сантиметры для значений 10, 11, …, 22 дюйма(1 дюйм = 25, 4 мм).
            //for (int i = 10; i < 23; i++)
            //{
            //    double mm = 25.4;
            //    Console.WriteLine($"{i}d = {i * mm} mm");
            //}

            //C1.10.Напечатать таблицу перевода 1, 2, … 20 долларов США в рубли по текущему курсу(значение курса вводится с клавиатуры).

            //Console.WriteLine("Please, enter the exchange rate: ");
            //double rate = double.Parse(Console.ReadLine());
            //for (int i = 1; i < 21; i++)
            //{
            //    Console.WriteLine($"{i}$ = {Math.Round((i*rate),2)} rub");
            //}

            //C1.11.Считая, что Земля — идеальная сфера с радиусом R = 6370 км,
            //определить расстояние до линии горизонта от точки с высотой над Землей, равной 1, 2, … 10 км.

            //double r = 6370;
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"When h = {i}, then S={Math.Round((Math.Pow(Math.Pow((r + i), 2) - Math.Pow(r, 2), 2)),2)}");

            //}

            //C1.12.Плотность воздуха убывает с высотой по закону p = p0e - hz ,
            //где p — плотность на высоте h метров, p0 = 1,29 кг / м3, z = 1,25·10 - 4.Напечатать таблицу зависимости плотности от высоты для значений от 0 до 1000 м через каждые 100 м.

            //const double p0 = 1.29;
            //const double z = 0.000125;
            //double p, m;

            //for (int h = 0; h <= 1000; h += 100)
            //{
            //    m = - h* z;
            //    p = p0 * Math.Exp(m);
            //    System.Console.WriteLine(«h =» +h + » p = « +p);
            //}

            //C1.13.Напечатать таблицу умножения на 7:

            //1 х 7 = 7
            //2 х 7 = 14
            //...
            //9 х 7 = 63

            //for (int i = 1; i < 10; i++)
            //{

            //    Console.WriteLine($"{i} x 7 = {i*7}");
            //}

            //C1.14.Напечатать таблицу умножения на 9:
            //for (int i = 1; i < 10; i++)
            //{

            //    Console.WriteLine($"{i} x 9 = {i * 9}");
            //}

            //C1.15.Напечатать таблицу умножения на число n(значение n вводится с клавиатуры; 1 <= n <= 9).
            //Console.WriteLine("Please, enter n:");
            //int n = int.Parse(Console.ReadLine());
            //if ((n >= 1) && (n <= 9))
            //{
            //    for (int i = 1; i < 10; i++)
            //    {
            //        Console.WriteLine($"{i} x {n} = {i * n}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("n should be less than 9 and greater than 1");

            //}

            //C1.16.Напечатать «столбиком» значения sin(2) , sin(3) , …, sin(20).
            //for (int i = 2; i < 21; i++)
            //{
            //    Console.WriteLine($"sin({i})");
            //}

            //C1.17.Вывести «столбиком» значения sin(0,1),  sin(0, 2) , …,  sin(1, 6).

            //for (Double i = 0.1; i < 1.7; i += 0.1)
            //{
            //    Console.WriteLine($"sin({i})");
            //}

            //C1.18.Напечатать таблицу стоимости 50, 100, 150, …, 1000 г сыра(стоимость 1 кг сыра вводится с клавиатуры).
            //Console.WriteLine("Please, enter price for the cheese: ");
            //double price = double.Parse(Console.ReadLine());
            //for (int i = 50; i < 1050; i+= 50)
            //{
            //    Console.WriteLine($"If you will buy {i}g of cheese, the price will be = {Math.Round(((i * price) / 1000),2)} rub");
            //}

            //C1.19.Напечатать таблицу стоимости 100, 200, 300, …, 2000 г конфет(стоимость 1 кг конфет вводится с клавиатуры).
            //Console.WriteLine("Please, enter price for the candies: ");
            //double price = double.Parse(Console.ReadLine());
            //for (int i = 100; i < 2100; i += 100)
            //{
            //    Console.WriteLine($"If you will buy {i}g of candies, the price will be = {Math.Round(((i * price) / 1000), 2)} rub");
            //}


            //C1.20.Вывести «столбиком» следующие числа: 2,1,  2,2,  2,3,  …,  2,8.
            //for (double i = 2.1; i < 2.9; i+=0.1)
            //{
            //    Console.WriteLine(i);
            //}

            //C1.24.Вывести «столбиком» следующие числа: 3,2,  3,2,  3,3,  …,  3,9.
            //for (double i = 3.2; i < 3.9; i += 0.1)
            //{
            //    Console.WriteLine(i);
            //}

            //C1.25.Вывести «столбиком» следующие числа: 2,2,  2,4,  2,6,  …, 4,2.
            //for (double i = 2.2; i < 4.3; i += 0.1)
            //{
            //    Console.WriteLine(i);
            //}

            //C1.22.Вывести «столбиком» следующие числа: 4,4,  4,6,  4,8,  …, 6,4.
            //for (double i = 4.4; i < 6.5; i += 0.2)
            //{
            //    Console.WriteLine(i);
            //}
        }

        public static void C2()
        {
            ////C2.1.Найти:
            ////а) сумму всех целых чисел от 100 до 500;
            //int sum = 0;
            //for (int i = 100; i < 501; i++)
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}

            ////б) сумму всех целых чисел от a до 500(значение a вводится с клавиатуры; a < 500);
            //Console.WriteLine("Please, enter a: ");
            //int a = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = a; i < 501; i++)
            //{
            //    if (a < 500)
            //    {
            //        sum += i;
            //        Console.WriteLine(sum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("a should be less than 500");
            //    }
            //}
            ////в) сумму всех целых чисел от –10 до b(значение b вводится с клавиатуры; b >–10);

            //Console.WriteLine("Please, enter b: ");
            //int b = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = -10; i <= b; i++)
            //{
            //    if (b > -10)
            //    {
            //        sum += i;
            //        Console.WriteLine(sum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("b should be greater than -10");
            //    }
            //}

            ////г) сумму всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).
            ///
            //Console.WriteLine("Please, enter a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b: ");
            //int b = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}


            ////C2.2.Найти:
            ////а) произведение всех целых чисел от 8 до 15;
            ///
            //int mult = 1;
            //for (int i = 8; i < 16; i++)
            //{
            //    mult*=i;
            //    Console.WriteLine(mult);
            //}
            ////б) произведение всех целых чисел от a до 20(значение a вводится с клавиатуры; 1 <= a <= 20);

            Console.WriteLine("Please, enter a: ");
            int a = int.Parse(Console.ReadLine());
            int mult = 1;

            if ((a <= 20) && (a >= 1))
            {
                for (int i = a; i < 21; i++)
                {
                    mult *= i;
                    Console.WriteLine(mult);
                }
            }
            else
            {
                Console.WriteLine("a should be greater than 1 and less than 20");
            }

            ////в) произведение всех целых чисел от 1 до b(значение b вводится с клавиатуры; 1 <= b <= 20);
            ////г) произведение всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).

            ////C2.3.Найти:
            ////а) среднее арифметическое всех целых чисел от 1 до 1000;
            ////б) среднее арифметическое всех целых чисел от 100 до b(значение b вводится с клавиатуры; b > 100);
            ////в) среднее арифметическое всех целых чисел от a до 200(значения a и b вводятся с клавиатуры; a < 200);
            ////г) среднее арифметическое всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).

            ////C2.4.Найти:
            ////а) сумму кубов всех целых чисел от 20 до 40;
            ////б) сумму квадратов всех целых чисел от a до 50(значение a вводится с клавиатуры; 0 < a <= 50);
            ////в) сумму квадратов всех целых чисел от 1 до n(значение n вводится с клавиатуры; 1 <= n <= 100);
            ////г) сумму квадратов всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).

            ////C2.5.Дано натуральное число n.Найти сумму:  n2 + (n + 1)2 + … +(2n)2.

            ////C2.6.Вычислить сумму 1 + 1 / 3 + 1 / 32 +  … +1 / 38.Операцию возведения в степень не использовать.

            ////C2.7.Вычислить сумму: 2 / 3 + 3 / 4 + 4 / 5 +… 10 / 11.

            ////C2.8.Вычислить сумму: 1 + 1 / 2 + 1 / 3 + … +1 / n.

            ////C2.9.Вычислить сумму 1 — 1 / 2 + 1 / 3 +  … +(-1)n + 1 1 / n.Условный оператор и операцию возведения в степень не использовать.

            ////C2.10.Вычислить сумму: x + x3 / 3 + … +x11 / 11.Условный оператор и операцию возведения в степень не использовать.

            ////C2.11. «Странный муж». Некий мужчина отправляется на работу, которая находится на расстоянии 1 км от дома.Дойдя до места работы, он вдруг вспоминает, что перед уходом забыл поцеловать жену, и поворачивает назад.Пройдя полпути, он меняет решение, посчитав, что правильнее вернуться на работу. Пройдя 1 / 3 км по направлению к работе, он вдруг осознает, что будет настоящим подлецом, если так и не поцелует жену.На этот раз, прежде чем изменить мнение, он проходит 1 / 4 км.Так он продолжает метаться, и после N-этапа, пройдя 1 / N км, снова меняет решение.Определить:
            ////а) на каком расстоянии от дома будет находиться мужчина после 100 - го этапа(если допустить, что такое возможно);
            ////б) какой общий путь он при этом пройдет.
        }
    }
}
