﻿using System;
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

            int number1 = 2, number2 = 13, number3 = 17;
            string str = "kg";
            Console.WriteLine($"{number1} {str}\n{number2} {number3}");

        }
    }
}
