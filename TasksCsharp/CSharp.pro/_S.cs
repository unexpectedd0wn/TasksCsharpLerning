using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksCsharp.CSharp.pro
{
    internal class _S
    {
        public static void S1()
        {
            ////S1.1. Вывести на экран число  с точностью до сотых.

                //double number = 12.4558788;
                //Console.WriteLine(Math.Round(number,2));// the result is 12.45

            ////S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.

                //double e = 2.71828182845904;
                //Console.WriteLine(Math.Round(e,1)); // the result is 2.7

            ////S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры.Выводимому числу должно предшествовать сообщение «Вы ввели число».

                //Console.WriteLine("Please, enter any number");
                //double input = double.Parse(Console.ReadLine());
                //Console.WriteLine($"You entered the number: {input}");

            ////S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры.После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

                //Console.WriteLine("Please, enter any number");
                //double input = double.Parse(Console.ReadLine());
                //Console.WriteLine($"{input} - the number you have entered ");

            ////S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

                //int a = 1, b = 13, c = 49;
                //Console.WriteLine($"{a} {b} {c}"); //the result is 1 13 49

            ////S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

                //int a = 7, b = 15, c = 100;
                //string result = string.Join("  ",a,b,c);
                //Console.WriteLine(result);

            ////S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

                //Random random = new Random();
                //int a = random.Next(), b = random.Next(), c = random.Next();
                //string result = string.Join("  ",a,b,c);
                //Console.WriteLine(result);

            ////S1.8. Составить программу вывода на экран в одну строку четырех любых чисел с одним пробелом между ними.

                //Random random = new Random();
                //int a = random.Next(), b = random.Next(), c = random.Next(), d = random.Next();
                //string result = string.Join(" ", a, b, c, d);
                //Console.WriteLine(result);
                ////OR
                //Console.WriteLine($"{a} {b} {c} {d}");

            ////S1.9. Вывести на экран числа 50 и 10 одно под другим.

                //int number1 = 50, number2 = 10;
                //Console.WriteLine($"{number1}\n{number2}");

            ////S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.

                //int number1 = 50, number2 = 10, number3 = 21;
                //Console.WriteLine($"{number1}\n{number2}\n{number3}");

            ////S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.

                //Random random = new Random();
                //int number1 = random.Next(1,20), number2 = random.Next(1, 20), number3 = random.Next(1, 20), number4 = random.Next(1, 20);
                //Console.WriteLine($"{number1}\n{number2}\n{number3}\n{number4}");

            ////S1.12. Составить программу вывода на экран следующей информации:
            ////5 10
            ////7 см

                //int number1 = 5, number2 = 10, number3 = 7;
                //string str = "cm";
                //Console.WriteLine($"{number1} {number2}\n{number3} {str}");

            ////S1.13. Составить программу вывода на экран следующей информации:
            ////2 кг
            ////13 17

                //int number1 = 2, number2 = 13, number3 = 17;
                //string str = "kg";
                //Console.WriteLine($"{number1} {str}\n{number2} {number3}");

        }

        public static void S2()
        {
            //S2.1.Составить программу:
            //а) вычисления значения функции y = 7x2 + 3x + 6 при любом значении x;
            //б) вычисления значения функции x = 12a2 + 7a + 12 при любом значении а.

            //Random random = new Random();
            //double x = random.NextDouble();
            //double a = random.NextDouble();

            //double resulty = Math.Round((7 * x * 2 + 3 * x + 6),2);
            //double resultx = Math.Round((12 * a * 2 + 7 * a + 12),2);

            //Console.WriteLine($"The result is:\n1){resulty}\n2){resultx}");

            //S2.2.Дана сторона квадрата. Найти его периметр. — решение.

            //Console.WriteLine("Please, enter a side of the square");
            //double side = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Perimeter is: {side*4}");


            //S2.3.Дан радиус окружности. Найти ее диаметр. — решение.

            //Console.WriteLine("Please, enter a radius of the circle");
            //double radius = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Diameter is: {radius * 2}");

            //S2.4.Считая, что Земля — идеальная сфера с радиусом R = 6350 км,
            //определить расстояние до линии горизонта от точки В с заданной высотой h = AB над Землей.

            //double R = 6350;

            //Console.WriteLine("Please, enter h:");
            //double h = double.Parse(Console.ReadLine());
            //double result = Math.Round(Math.Sqrt(Math.Pow((R + h), 2) - Math.Pow(R, 2)));

            //Console.WriteLine($"The result is: {result}");


            //S2.5.Дана длина ребра куба.Найти объем куба и площадь его боковой поверхности. — решение

            //Console.WriteLine("Please, enter L:");
            //double l = double.Parse(Console.ReadLine());
            //double v = Math.Round(Math.Pow(l,3));
            //double s = Math.Round(Math.Pow(l, 2));
            //Console.WriteLine($"The result is:\nV = {v} and S = {s}");

            ////S2.6.Дан радиус окружности. Найти длину окружности и площадь круга.
            //double pi = 3.14;
            //Console.WriteLine("Please, enter R");
            //double r = double.Parse(Console.ReadLine());
            //double l = Math.Round(2 * (pi * r));
            //double s = Math.Round(Math.Pow((pi * r),2));
            //Console.WriteLine($"The result is: L = {l} and S = {s}");

            // S2.7.Даны два целых числа.Найти: а) их среднее арифметическое; б) их среднее геометрическое.
            //Console.WriteLine("Please, enter 1st namer: ");
            //double number1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter 2nd number");
            //double number2 = double.Parse(Console.ReadLine());

            //double avg = (number1 + number2) / 2;
            //double gavg = Math.Sqrt(number1 * number2);

            //Console.WriteLine($"The result is: Math avg = {avg} and Gavg = {gavg}");

            //S2.8.Известны объем и масса тела. Определить плотность материала этого тела.

            //Console.WriteLine("Please, enter m:");
            //double m = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter V:");
            //double v = double.Parse(Console.ReadLine());

            //double p = m / v;
            //Console.WriteLine($"The result is: P = {p}");

            //S2.9.Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.

            //Console.WriteLine("Please, enter the number of inhabitants in the state: ");
            //double inhab = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter the size of its territory: ");
            //double size = double.Parse(Console.ReadLine());
            //double pop = Math.Round((inhab/size),2);

            //Console.WriteLine($"The population density equals: {pop} ");


            //S2.10.Составить программу решения линейного уравнения ax + b = 0(a ≠ 0).


            //S2.11.Даны катеты прямоугольного треугольника.Найти его гипотенузу.

            //S2.12.Найти площадь кольца по заданным внешнему и внутреннему радиусам.

            //S2.13.Даны катеты прямоугольного треугольника.Найти его периметр.

            //S2.13А.Даны два числа.Найти среднее арифметическое и среднее геометрическое их модулей.

            //S2.14.Даны основания и высота равнобедренной трапеции.Найти ее периметр.

            //S2.14А.Даны стороны прямоугольника.Найти его периметр и длину диагонали.

            //S2.15.Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.

            //S2.16.Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.

            //S2.17.Известны координаты на плоскости двух точек.Составить программу вычисления расстояния между ними.

            //S2.18.Даны основания и высота равнобедренной трапеции.Найти периметр трапеции.

            //S2.19.Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.

            //S2.20.Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.

            //S2.21.Выпуклый четырехугольник задан координатами своих вершин.Найти площадь этого четырехугольника как сумму площадей треугольников.

            //S2.22.Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

            //S2.23.Известна стоимость монитора, системного блока, клавиатуры и мыши.
            //Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?


            //S2.24.Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.  —  решение

            //S2.25.Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/ час.Определить, через какое время автомобили встретятся, если расстояние между ними было S км.

            //S2.26.Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/ час(V1 > V2).Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.

            //S2.27.Известно значение температуры по шкале Цельсия.Найти соответствующее  значение температуры по шкале: а) Фаренгейта; б) Кельвина.Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.

            //S2.28.У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов по Фаренгейту». Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См.предыдущую задачу).
        }

        public static void S3()
        {
            //S3.1 Составить программу обмена значениями двух переменных величин.

            //double a = 4, b = 3;
            //(a, b) = (b, a);
            //Console.WriteLine($"The result is: a = {a}, b = {b}");

            //S3.2.Cоставить программу обмена значениями трех переменных величин а, b, c по
            //следующим двум схемам: — есть решение.
            //а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            //б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

            //double a = 1, b = 2, c = 3, buffer;

            //Кольцеое присваивание

            //buffer = a;
            //a = b;
            //b = c; 
            //c = buffer;
            //Console.WriteLine($"The result is: a = {a}, b = {b}, c = {c}");


            //buffer = a;
            //a = c;
            //c = b;
            //b = buffer;
            //Console.WriteLine($"The result is: a = {a}, b = {b}, c = {c}");


            //S3.3.Дано вещественное число а.Пользуясь только операцией умножения, получить:

            //Операторы составного присваивания
            //int r, a = 2;
            //а) a4 за две операции;
            //r = a * a; //4
            //Console.WriteLine(r);
            //r *= r;//16
            //Console.WriteLine(r);
            //б) a6 за три операции; // 64
            //r = a * a; //4
            //r = r * a; //8
            //r *= r; //64
            //Console.WriteLine(r);
            //в) a7 за четыре операции;//128
            //r = a * a; //4
            //r = r * a; //8
            //r *= r; //64
            //r = r * a;//128
            //Console.WriteLine(r);
            //г) a8 за три операции;//256
            //r = a * a;//4
            //r *= r; //16
            //r = r * r;//256
            //Console.WriteLine(r);
            //д) a9 за четыре операции;//512
            //r = a * a;//4
            //r *= r; //16
            //r = r * r;//256
            //r = r * a;
            //Console.WriteLine(r);
            //е) a10 за четыре операции. //1024
            //r = a * a;//4
            //r *= r; //16
            //r *= a;//32
            //r = r * r;//1024
            //Console.WriteLine(r);

            //S3.4.Дано вещественное число a.Пользуясь только операцией умножения, получить:
            //double r, a = 2;
            //а) a3 и a10 за четыре операции;
            //2^3 = 8,2^10 = 1024

            //r = a * a;//4
            //r *= a;//8
            //r *= r * r;//512
            //r = r * a;//1024
            //Console.WriteLine(r);

            //б) a4 и a20 за пять операций;
            //2^4 = 16,2^20 = 1048576

            //r = a * a;//4
            //r *= a * a;//16
            //r *= r * a;//512
            //r *= r * a;//524288
            //r = r * a;//1048576
            //Console.WriteLine(r);

            //в) a5 и a13 за пять операций;
            //2^5 = 32,2^13 = 8192

            //r = a * a;//4
            //r *= r * a;//32
            //r *= r * a;//2048
            //r *= a;//4096
            //r *= a;//8192
            //Console.WriteLine(r);

            //г) a5 и a19 за пять операций;
            //2^5 = 32,2^19 = 524288

            //r = a * a;//4
            //r *= r * a;//32
            //r *= r * r;//32768
            //r *= a * a;//131072
            //r *= a * a;//524288
            //Console.WriteLine(r);

            //д) a2, a5 и a17 за шесть операций;
            //2^2 = 4,2^5 = 32,2^17 = 131072

            //r = a * a;//4
            //r *= r * a;//32
            //r *= r * a;//2048
            //r *= a * a;//8192
            //r *= a * a;//32768
            //r *= a * a;//131072
            //Console.WriteLine(r);


            //е) a4 , a12 и a28 за шесть операций.
            //2^4 = 16,2^12 = 4096,2^28 = 268435456

            //r = a * a;//4
            //r *= a * a;//16
            //r *= r * r;//4096
            //r *= a;//8192
            //r *= a;//16384
            //r *= r;//268435456
            //Console.WriteLine(r);
            


            //S3.5.Чему будет равно 1010 по Вашему алгоритму ?

        }
    }
}
