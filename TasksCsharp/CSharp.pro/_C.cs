﻿using System;
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

            //int mult = 1;
            //for (int i = 8; i < 16; i++)
            //{
            //    mult *= i;
            //    Console.WriteLine(mult);
            // }

            ////б) произведение всех целых чисел от a до 20(значение a вводится с клавиатуры; 1 <= a <= 20);

            //Console.WriteLine("Please, enter a: ");
            //int a = int.Parse(Console.ReadLine());
            //int mult = 1;

            //if ((a <= 20) && (a >= 1))
            //{
            //    for (int i = a; i < 21; i++)
            //    {
            //        mult *= i;
            //        Console.WriteLine(mult);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("a should be greater than 1 and less than 20");
            //}

            ////в) произведение всех целых чисел от 1 до b(значение b вводится с клавиатуры; 1 <= b <= 20);

            //Console.WriteLine("Please, enter b");
            //int b = int.Parse(Console.ReadLine());

            //int mult = 1;
            //for (int i = 1; i <= b; i++)
            //{
            //    mult *= i;
            //    Console.WriteLine(mult);
            //}

            ////г) произведение всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).
            //Console.WriteLine("Please, enter a");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please, enter b");
            //int b = int.Parse(Console.ReadLine());

            //int mult = 1;
            //for (int i = a; i <= b; i++)
            //{
            //    mult *= i;
            //    Console.WriteLine(mult);
            //}

            ////C2.3.Найти:


            ////а) среднее арифметическое всех целых чисел от 1 до 1000;
            //double sum = 0;
            //for (double i = 1; i <= 1000; i++)
            //{
            //    Console.WriteLine(Math.Round(((sum += i) / 1000),2));
            //}

            ////б) среднее арифметическое всех целых чисел от 100 до b(значение b вводится с клавиатуры; b > 100);
            //Console.WriteLine();
            //double b = double.Parse(Console.ReadLine());
            //double sum = 0;
            //if (b > 100)
            //{
            //    for (double i = 100; i <= b; i++)
            //    {
            //        Console.WriteLine(Math.Round(((sum += i) / 100), 2));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("b should be greater than 100");
            //}

            ////в) среднее арифметическое всех целых чисел от a до 200(значения a и b вводятся с клавиатуры; a < 200);

            //Console.WriteLine();
            //double a = double.Parse(Console.ReadLine());
            //double sum = 0;
            //if (a < 200)
            //{
            //    for (double i = a; i <= 200; i++)
            //    {
            //        Console.WriteLine(Math.Round(((sum += i) / 200), 2));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("a should be less than 200");
            //}

            ////г) среднее арифметическое всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).
            ///


            //Console.WriteLine("Please, enter a");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b");
            //double b = double.Parse(Console.ReadLine());
            //double sum = 0;
            //if (b > a)
            //{
            //    for (double i = a; i <= b; i++)
            //    {
            //        Console.WriteLine(Math.Round(((sum += i) / b), 2));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("a should be less than 200");
            //}

            ////C2.4.Найти:
            ////а) сумму кубов всех целых чисел от 20 до 40;

            //for (double i = 20; i <= 40; i++)
            //{
            //    double sum = 0;
            //    sum += Math.Pow((i), 3);
            //    Console.WriteLine(sum);
            //}

            ////б) сумму квадратов всех целых чисел от a до 50(значение a вводится с клавиатуры; 0 < a <= 50);
            ////в) сумму квадратов всех целых чисел от 1 до n(значение n вводится с клавиатуры; 1 <= n <= 100);
            ////г) сумму квадратов всех целых чисел от a до b(значения a и b вводятся с клавиатуры; b > a).

            ////C2.5.Дано натуральное число n.Найти сумму:  n2 + (n + 1)2 + … +(2n)2.

            ////C2.6.Вычислить сумму 1 + 1 / 3 + 1 / 32 +  … +1 / 38.Операцию возведения в степень не использовать.

            ////C2.7.Вычислить сумму: 2 / 3 + 3 / 4 + 4 / 5 +… 10 / 11.

            ////C2.8.Вычислить сумму: 1 + 1 / 2 + 1 / 3 + … +1 / n.

            ////C2.9.Вычислить сумму 1 — 1 / 2 + 1 / 3 +  … +(-1)n + 1 1 / n.Условный оператор и операцию возведения в степень не использовать.

            ////C2.10.Вычислить сумму: x + x3 / 3 + … +x11 / 11.Условный оператор и операцию возведения в степень не использовать.

            ////C2.11. «Странный муж». Некий мужчина отправляется на работу, которая находится на расстоянии 1 км от дома.
            ///Дойдя до места работы, он вдруг вспоминает, что перед уходом забыл поцеловать жену, и поворачивает назад.
            ///Пройдя полпути, он меняет решение, посчитав, что правильнее вернуться на работу. 
            ///Пройдя 1 / 3 км по направлению к работе, он вдруг осознает, что будет настоящим подлецом, если так и не поцелует жену.
            ///На этот раз, прежде чем изменить мнение, он проходит 1 / 4 км.Так он продолжает метаться, и после N-этапа, пройдя 1 / N км, снова меняет решение.Определить:
            ////а) на каком расстоянии от дома будет находиться мужчина после 100 - го этапа(если допустить, что такое возможно);
            ////б) какой общий путь он при этом пройдет.

            //for (int i = 1; i < 100; i++)
            //{

            //}
        }
        public static void C3()
        {
            ////C3.1.Даны числа a1, a2, …, a10. Определить их сумму.

            ////C3.2.Даны натуральное число n и вещественные числа a1, a2, …, an.Определить сумму всех вещественных чисел.

            ////C3.3.Известна масса каждого из 12 предметов.Определить общую массу всего набора предметов.

            ////C3.4.Известны оценки абитуриента на четырех экзаменах.Определить сумму набранных им баллов.

            ////C3.5.В ведомости указана зарплата, выплаченная каждому из сотрудников фирмы за месяц.Определить общую сумму выплаченных по ведомости денег.

            ////C3.6.Известна масса каждого предмета, загружаемого в автомобиль.Определить общую массу груза.

            ////C3.7.Известно сопротивление каждого из элементов электрической цепи. Все элементы соединены последовательно. Определить общее сопротивление цепи.

            ////C3.8.Известно сопротивление каждого из элементов электрической цепи. Все элементы соединены параллельно. Определить общее сопротивление цепи.

            ////C3.9.Даны числа a1, a2, …, a6. Определить их произведение.

            ////C3.10.Даны числа a1, a2, …, a10. Определить сумму их квадратов.

            ////C3.11.Даны натуральное число n и вещественные числа a1, a2, …, an.Определить сумму квадратов вещественных чисел.

            ////C3.12.Даны числа a1, a2, …, a10. Определить их среднее арифметическое.

            ////C3.13.Даны натуральное число n и вещественные числа a1, a2, …, an.Определить среднее арифметическое вещественных чисел.

            ////C3.14.Известны оценки по физике каждого из 20 учеников класса. Определить среднюю оценку.

            ////C3.15.Известны оценки ученика по 10 предметам.Определить среднюю оценку.

            ////C3.16.Известны оценки по алгебре каждого ученика класса. Определить среднюю оценку.

            ////C3.17.Известна масса каждого предмета из некоторого набора предметов.Определить среднюю массу.

            ////C3.18.Даны натуральное число n и числа a1, a2, …, an..Определить:
            ////а) | a1 | + | a2 | + … + | an |;
            ////б) | a1 | x | a2 | x … x | an |;
            ////в) a1 + a2, a2 + a3, …, an - 1 + an;
            ////г) a1 — a2, a2 — a3, …, an - 1 — an;
            ////Условный оператор и операцию возведения в степень не использовать.

            ////C3.19.Известны оценки двух учеников по четырем предметам. Определить сумму оценок каждого ученика.

            ////C3.20.Известны результаты двух спортсменов - пятиборцев в каждом из пяти видов спорта в баллах. Определить сумму баллов, полученных каждым спортсменом.

            ////C3.21.Известен возраст(в годах в виде 14, 5 лет и т.п.) каждого ученика двух классов. Определить средний возраст учеников каждого класса. В каждом классе учатся 20 человек.

            ////C3.22.Известно количество осадков, выпавших за каждый день января и марта. Определить среднедневное количество осадков за каждый месяц.

            ////C3.23.Известен рост каждого ученика двух классов.Определить средний рост учеников каждого класса. Численность обоих классов одинаковая.

            ////C3.24.Известны оценки по физике каждого ученика двух классов.Определить среднюю оценку в каждом классе. Количество учащихся в каждом классе одинаковое.

            ////C3.25.В области 10 районов.Заданы площади, засеваемые пшеницей(в гектарах), и средняя урожайность(в центнерах с гектара) в каждом районе.Определить количество пшеницы, собранное в области, и среднюю урожайность по области.

            ////C3.26.В области 12 районов.Известны количество жителей(в тысячах человек) и площадь(в км2) каждого района. Определить среднюю плотность населения по области в целом.

            ////C3.27.В области 12 районов.Известны количество жителей каждого района(в тысячах человек) и плотность населения в нем(тыс.чел./ км2).Определить общую площадь территории области.
        }
        public static void C4()
        {
            ////C4.1.Последовательность Фибоначчи образуется так: первый и второй члены последовательности равны 1, каждый следующий равен сумме двух предыдущих(1, 1, 2, 3, 5, 8, 13, …). Дано натуральное число n(n > 3).
            ////а) Найти k-й член последовательности Фибоначчи.
            ////б) Получить первые n членов последовательности Фибоначчи.
            ////в) Верно ли, что сумма первых n членов последовательности Фибоначчи есть четное число?

            ////C4.2.Рассмотрим последовательность, образованную дробями: 1 / 1,  2 / 1,  3 / 2, …, в которой числитель(знаменатель) следующего члена последовательности получается сложением числителей(знаменателей) двух предыдущих членов.Числители двух первых дробей равны 1 и 2, знаменатели — 1 и 1.
            ////а) Найти k-й член этой последовательности.
            ////б) Получить первые n членов этой последовательности.
            ////в) Верно ли, что сумма первых n членов этой последовательности больше числа А?

            ////C4.3.Одноклеточная амеба каждые 3 часа делится на 2 клетки.Определить, сколько клеток будет через 3, 6, 9, …, 24 часа, если первоначально была одна амеба.

            ////C4.4.Гражданин 1 марта открыл счет в банке, вложив 1000 руб.Через каждый месяц размер вклада увеличивается на 2 % от имеющейся суммы. Определить:
            ////а) прирост суммы вклада за первый, второй, …, десятый месяц;
            ////б) сумму вклада через три, четыре, …, двенадцать месяцев.

            ////C4.5.Начав тренировки, лыжник в первый день пробежал 10 км.Каждый следующий день он увеличивал пробег на 10 % от пробега предыдущего дня.Определить:
            ////а) пробег лыжника за второй, третий, …, десятый день тренировок;
            ////б) какой суммарный путь он пробежал за первые 7 дней тренировок.

            ////C4.6.В некотором году(назовем его условно первым) на участке в 100 гектаров средняя урожайность ячменя составила 20 центнеров с гектара.После этого каждый год площадь участка увеличивалась на 5 %, а средняя урожайность — на 2 %.Определить:
            ////а) урожайность за второй, третий, …, восьмой год;
            ////            б) площадь участка в четвертый, пятый, …, седьмой год;
            ////в) какой урожай будет собран за первые шесть лет.

            ////C4.7.Определить суммарный объем в литрах двенадцати вложенных друг в друга шаров со стенками толщиной 5 мм.Внутренний диаметр внутреннего шара равен 10 см.Принять, что шары вкладываются друг в друга без зазоров.

            ////C4.8.Найти сумму 22 + 23 + 24 + … +210.Операцию возведения в степень не использовать.

            ////C4.9.Дано вещественное число а и натуральное число n.Вычислить значения a1, a2, a3, …, an.Операцию возведения в степень не использовать.

            ////C4.10.Найти сумму: -12 + 22 — 32 + 42 — … +102.Условный оператор не использовать.
        }
        public static void C5()
        {
            ////С5.1.Даны натуральные числа х и у.Вычислить произведение x·y, используя лишь операцию сложения. Задачу решить двумя способами.

            ////С5.2.Составить программу для расчета факториала натурального числа n(факториал числа n равен 1 ·2 · … · n).

            ////С5.3.В некоторых языках программирования(например, в C#) не предусмотрена операция возведения в степень. Составить программу для расчета степени n вещественного числа a (n — натуральное число).

            ////С5.4.Дано пятизначное число.Найти число, получаемое при прочтении его цифр справа налево.

            ////С5.5.Составить программу возведения натурального числа в квадрат, учитывая следующую закономерность:
            ////12 = 1
            ////22 = 1 + 3
            ////32 = 1 + 3 + 5
            ////42 = 1 + 3 + 5 + 7
            ////…
            ////n2 = 1 + 3 + 5 + 7 + 9 + … +(2n — 1).

            ////С5.6.Найти сумму 12 + 22 + 32 + … +102.Операцию возведения в степень не использовать, а учесть особенности получения квадрата натурального числа, отмеченные в предыдущей задаче.

            ////С5.7.Составить программу возведения натурального числа в третью степень, учитывая следующую закономерность:
            ////            13 = 1
            ////23 = 3 + 5
            ////33 = 7 + 9 + 11
            ////43 = 13 + 15 + 17 + 19
            ////53 = 21 + 23 + 25 + 27 + 29.

            ////С5.8.Вычислить сумму 1! + 2! + 3! +  … +n!,  где k! = 1 · 2 · 3 …· k, и k = 1, 2, …, n.Значение n вводится с клавиатуры: 1 < n <= 10.

            ////С5.9.Вычислить сумму  1 + 1 / 1! + 1 / 2! + 1 / 3! + … +1 / n! , где k! = 1 · 2 · 3 · … · k, и k = 1, 2, …, n.Значение n вводится с клавиатуры: 1 < n <= 10.

            ////С5.10.Вычислить сумму 1 + x / 1! + x2 / 2! + x3 / 3! + … +xn / n! , где k!  = 1 · 2 · 3 · … · k, и k = 1, 2, …, n.Значение x и n вводится с клавиатуры: 1 < n <= 10.

            ////С5.11.Дано натуральное число n.Вычислить сумму:  1 / sin1 + 1 / (sin1 + sin2) + … +1 / (sin1 + … +sin n);

            ////С5.12.Дано шестизначное число. Найти сумму его цифр. Величины для хранения всех шести цифр числа не использовать.

            ////С5.13.Дано натуральное число. Найти сумму его последних n цифр. Величины для хранения всех n последних цифр числа не использовать.

            ////С5.14.Около стены наклонно стоит палка длиной 4,5 м.Один ее конец находится на расстоянии 3 м от стены.Нижний конец палки начинает скользить в плоскости, перпендикулярной стене. Определить значение угла между палкой и полом(в градусах) с момента начала скольжения до падения палки через каждые 0,2 м.
        }
    }
}
