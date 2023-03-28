using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy.Lessons
{
    internal class Lesson2
    {
        public static void lesson2()
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

    }
}
