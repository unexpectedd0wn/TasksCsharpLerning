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

            //Console.WriteLine("Please, enter a");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b");
            //double b = double.Parse(Console.ReadLine());

            //if (a != 0)
            //{
            //    Console.WriteLine($"The result is, x = {-Math.Abs(b)/a}");
            //}
            //else
            //{
            //    Console.WriteLine("a could not be equal 0");
            //}


            //S2.11.Даны катеты прямоугольного треугольника.Найти его гипотенузу.

            //Console.WriteLine("Please, enter a");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b");
            //double b = double.Parse(Console.ReadLine());

            //double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"The result is, c = {result}");


            //S2.12.Найти площадь кольца по заданным внешнему и внутреннему радиусам.

            //double pi = 3.14;
            //Console.WriteLine("Please, enter R");
            //double R = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter r");
            //double r = double.Parse(Console.ReadLine());

            //Console.WriteLine($"The result is, S = {pi * (Math.Pow(R,2)- Math.Pow(r, 2))}");


            //S2.13.Даны катеты прямоугольного треугольника.Найти его периметр.

            //Console.WriteLine("Please, enter a");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b");
            //double b = double.Parse(Console.ReadLine());

            //double p = Math.Sqrt(Math.Pow(a,2)+ Math.Pow(a, 2)) + a + b;
            //Console.WriteLine($"The result is, P = {p}");

            //S2.13А.Даны два числа.Найти среднее арифметическое и среднее геометрическое их модулей.

            //Console.WriteLine("Please, enter a");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter b");
            //double b = double.Parse(Console.ReadLine());

            //double avg = (a+ b)/2;
            //double geo = Math.Round(Math.Sqrt(Math.Abs(a)* Math.Abs(b)),2);

            //Console.WriteLine($"The result is, avg = {avg} and geo = {geo}");

            //S2.14.Даны основания и высота равнобедренной трапеции.Найти ее периметр.

            //Console.WriteLine("Please, enter H: ");
            //double h = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter F1: ");
            //double f1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter F2: ");
            //double f2 = double.Parse(Console.ReadLine());
            //double p = Math.Round(2 * h + (f1 * f2), 2);
            //Console.WriteLine($"The perimtr is: {p}");

            //S2.14А.Даны стороны прямоугольника.Найти его периметр и длину диагонали.
            //Console.WriteLine("Please, enter s1");
            //double s1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter s2");
            //double s2 = double.Parse(Console.ReadLine());
            //double p = 2 * (s1 + s2);
            //double d = Math.Sqrt(Math.Pow(s1,2) + Math.Pow(s2,2));

            //Console.WriteLine($"perimetr is: {p} and diagonal is: {d}");

            //S2.15.Даны два числа.
            //Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.

            //Console.WriteLine("Please, enter a 1st number");
            //double n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter a 2nd number");
            //double n2 = double.Parse(Console.ReadLine());

            //double amount = Math.Round(n1 + n2);

            //if (n2 > n1)
            //{
            //    double dif = n2 - n1;
            //}
            //else
            //{
            //    double dif = n1 - n2;
            //}

            //double mult = n1 * n2;

            //S2.16.Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.
            //int a, b, c, Sside, S;
            //Console.WriteLine("Please, enter side a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter side b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter side c: ");
            //c = int.Parse(Console.ReadLine());
            //Sside = 2(a * b + a * c);
            //S = 2(a * b + a * c + b * c);
            //Console.WriteLine($"The result is: S = {S}, and S of the side is {Sside}");

            //S2.17.Известны координаты на плоскости двух точек.Составить программу вычисления расстояния между ними.
            //int x1, x2, y1, y2, l;
            //string c1, c2;
            //Console.WriteLine("Please, enter a coordinates for 1st point (x,y)");
            //c1 = Console.ReadLine();
            //x1 = Convert.ToInt32(c1.Split(',')[0]);
            //y1 = Convert.ToInt32(c1.Split(',')[0]);
            //Console.WriteLine("Please, enter a coordinates for 2nd point (x,y)");
            //c2 = Console.ReadLine();
            //x2 = Convert.ToInt32(c1.Split(',')[0]);
            //y2 = Convert.ToInt32(c1.Split(',')[0]);
            //l = Math.Sqrt((Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2));
            //Console.WriteLine($"The result is: {l}");

            //S2.18.Даны основания и высота равнобедренной трапеции.Найти периметр трапеции.
            //int a,b,c,P;
            //string value;
            //Console.WriteLine("Please, enter hight, base 1 and base 2,comma separated like (1,2,3) :");
            //value = Console.ReadLine();
            //a = Convert.ToInt32(value.Split(',')[0]);
            //b = Convert.ToInt32(value.Split(',')[1]);
            //c = Convert.ToInt32(value.Split(',')[2]);

            //P = 2*a + b + c;

            //Console.WriteLine(P);

            //S2.19.Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.
            //double a, b, angle, S;
            //string input;
            //Console.WriteLine("Please, enter  base1, base 2 and angle, comma separated, for example (1,2,3)");

            //input = Console.ReadLine();
            //a = Convert.ToDouble(input.Split(',')[0]);
            //b = Convert.ToDouble(input.Split(',')[1]);
            //angle = Convert.ToDouble(input.Split(',')[2]);

            //S = 0.5 * (Math.Pow((b),2) - Math.Pow((a),2)) * Math.Tan(angle);

            //Console.WriteLine(S);

            //S2.20.Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.
            //Console.WriteLine("Please, enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //double a = Math.Sqrt(x2-x1)

            //S2.21.Выпуклый четырехугольник задан координатами своих вершин.Найти площадь этого четырехугольника как сумму площадей треугольников.

            //Console.WriteLine("Please, enter the coordinates of the A vertex of the quadrilateral (x,y): ");
            //string vertex1 = Console.ReadLine();
            //double x1 = Convert.ToDouble(vertex1.Split(',')[0]);
            //double y1 = Convert.ToDouble(vertex1.Split(',')[1]);
            //Console.WriteLine("Please, enter the coordinates of the B vertex of the quadrilateral (x,y): ");
            //string vertex2 = Console.ReadLine();
            //double x2 = Convert.ToDouble(vertex2.Split(',')[0]);
            //double y2 = Convert.ToDouble(vertex2.Split(',')[1]);
            //Console.WriteLine("Please, enter the coordinates of the C vertex of the quadrilateral (x,y): ");
            //string vertex3 = Console.ReadLine();
            //double x3 = Convert.ToDouble(vertex2.Split(',')[0]);
            //double y3 = Convert.ToDouble(vertex2.Split(',')[1]);
            //Console.WriteLine("Please, enter the coordinates of the D vertex of the quadrilateral (x,y): ");
            //string vertex4 = Console.ReadLine();
            //double x3 = Convert.ToDouble(vertex2.Split(',')[0]);
            //double y4 = Convert.ToDouble(vertex2.Split(',')[1]);


            //S2.22.Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

            //const double candyPrice = 236.45;
            //const double bisquitPrice = 174.36;
            //const double applePrice = 54.20;

            //Console.WriteLine("How many kilos of candys do you want to buy: ");
            //double candyWeight = double.Parse(Console.ReadLine());
            //Console.WriteLine("How many kilos of bisquit do you want to buy: ");
            //double bisquitWeight = double.Parse(Console.ReadLine());
            //Console.WriteLine("How many kilos of apples do you want to buy: ");
            //double appleWeight = double.Parse(Console.ReadLine());

            //double candyTotalPrice = Math.Round((candyPrice * candyWeight),2);
            //double bisquitTotalPrice = Math.Round((bisquitPrice * bisquitWeight),2);
            //double appleTotalPrice = Math.Round((applePrice * appleWeight),2);

            //Console.WriteLine($"The Total price for {candyWeight} candys is {candyTotalPrice}\nThe Total price for {bisquitWeight} candys is {bisquitTotalPrice}\nThe Total price for {appleWeight} candys is {appleTotalPrice}");



            //S2.23.Известна стоимость монитора, системного блока, клавиатуры и мыши.
            //Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?

            //Console.WriteLine("Please, enter price for monitor: ");
            //decimal monitorPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter price for block: ");
            //decimal blockPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter price for keyboard: ");
            //decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter price for mause: ");
            //decimal mausePrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("How many computers do you want to buy: ");
            //int computersN = int.Parse(Console.ReadLine());

            //decimal totalPrice = (monitorPrice + blockPrice + keyboardPrice + mausePrice)*computersN;
            //Console.WriteLine($"The total price for {computersN} will be {totalPrice}");

            //S2.24.Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.  —  решение

            //Console.WriteLine("Please, enter Tanya's age");
            //int tanyaAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please, enter Mitya's age");
            //int mityaAge = int.Parse(Console.ReadLine());
            //int ageAverage = (tanyaAge + mityaAge) / 2;
            //int diferenceTanya = tanyaAge - ageAverage;
            //int diferenceMitya = mityaAge - ageAverage;

            //Console.WriteLine($"The average Ages is: {ageAverage}\n The difference between Tanya's age and aveerage is: {diferenceTanya} \n The difference between Mitya's age and aveerage is: {diferenceMitya}");



            //S2.25.Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/ час.Определить, через какое время автомобили встретятся, если расстояние между ними было S км.

            //Console.WriteLine($"Please, enter 1st vehicle speed (km/h): ");
            //double v1 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Please, enter 2nd vehicle speed (km/h): ");
            //double v2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Please, enter distance (km): ");
            //double S = double.Parse(Console.ReadLine());
            //double Vc = v1 + v2;
            //double t = S / Vc;
            //Console.WriteLine($"The time whene vehicles will meet is: {t}");

            //S2.26.Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/ час(V1 > V2).
            //Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил
            //второй на S км.

                //Console.WriteLine("Please, enter V1: ");
                //double v1 = double.Parse(Console.ReadLine());
                //Console.WriteLine("Please, enter V2: ");
                //double v2 = double.Parse(Console.ReadLine());

                //const t = 30;

            ////S2.27.Известно значение температуры по шкале Цельсия.Найти соответствующее  значение температуры по шкале: а) Фаренгейта; б) Кельвина.Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.

                //double tempertureCe, tempertureFa, tempertureKe;
                //const double valueKe = 273.15;
                //Console.WriteLine("Please, enter temperature in celsius: ");
                //tempertureCe = double.Parse(Console.ReadLine());
                //tempertureFa = tempertureCe * 1.8 + 32;
                //tempertureKe = (((tempertureFa - 32) * 5) / 9) + valueKe;
                //Console.WriteLine($"The result is: \ntemperature in fahrenheit is: {tempertureFa}\ntemperature in Kelvin is: {tempertureKe}");

            ////S2.28.У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов по Фаренгейту».
            ////Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См.предыдущую задачу).

                //const double tempertureF = 450;
                //double tempertureC = Math.Round(((tempertureF - 32) / 1.8), 2);
                //Console.WriteLine($"450 degrees Fahrenheit, equals degrees Celsius = {tempertureC}");
        }
        public static void S3()
        {
            ////S3.1 Составить программу обмена значениями двух переменных величин.

                //double a = 4, b = 3;
                //(a, b) = (b, a);
                //Console.WriteLine($"The result is: a = {a}, b = {b}");

            ////S3.2.Cоставить программу обмена значениями трех переменных величин а, b, c по
            ////следующим двум схемам: — есть решение.
            ////а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            ////б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

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


            ////S3.3.Дано вещественное число а.Пользуясь только операцией умножения, получить:

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

            ////S3.4.Дано вещественное число a.Пользуясь только операцией умножения, получить:
                //double r, a = 2;
                //а) a3 и a10 за четыре операции;
                //2^3 = 8,2^10 = 1024

                //r = a * a;//4
                //r *= a;//8
                //r *= r * r;//512
                //r = r * a;//1024
                //Console.WriteLine(r);

            ////б) a4 и a20 за пять операций;
                //2^4 = 16,2^20 = 1048576

                //r = a * a;//4
                //r *= a * a;//16
                //r *= r * a;//512
                //r *= r * a;//524288
                //r = r * a;//1048576
                //Console.WriteLine(r);

            ////в) a5 и a13 за пять операций;
                //2^5 = 32,2^13 = 8192

                //r = a * a;//4
                //r *= r * a;//32
                //r *= r * a;//2048
                //r *= a;//4096
                //r *= a;//8192
                //Console.WriteLine(r);

            ////г) a5 и a19 за пять операций;
                //2^5 = 32,2^19 = 524288

                //r = a * a;//4
                //r *= r * a;//32
                //r *= r * r;//32768
                //r *= a * a;//131072
                //r *= a * a;//524288
                //Console.WriteLine(r);

            ////д) a2, a5 и a17 за шесть операций;
                //2^2 = 4,2^5 = 32,2^17 = 131072

                //r = a * a;//4
                //r *= r * a;//32
                //r *= r * a;//2048
                //r *= a * a;//8192
                //r *= a * a;//32768
                //r *= a * a;//131072
                //Console.WriteLine(r);


            ////е) a4 , a12 и a28 за шесть операций.
                //2^4 = 16,2^12 = 4096,2^28 = 268435456

                //r = a * a;//4
                //r *= a * a;//16
                //r *= r * r;//4096
                //r *= a;//8192
                //r *= a;//16384
                //r *= r;//268435456
                //Console.WriteLine(r);



            ////S3.5.Чему будет равно 1010 по Вашему алгоритму ?

                //double r, a = 10;
                ////10 000 000 000

                //r = a*a;//100
                //Console.WriteLine(r);
                //r *= r;//10000
                //Console.WriteLine(r);
                //r *= r;//100000000
                //Console.WriteLine(r);
                //r *= a*a;//10 000 000 000
                //Console.WriteLine(r);
        }
    }
}
