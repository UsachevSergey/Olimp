using System;
using System.Collections.Generic;

namespace OlimpicProject.Combinatorics
{
    class CountTriangle
    {
        public static void X()
        {
            long Size = long.Parse(Console.ReadLine());
            long Result = Size * Size;
            long added = 0;
            long[] remtrianrle = new long[Size];
            remtrianrle[0] = 0;
            //движемся от  size-1 до 0 и добавляем  сумму от 1 до size-1
            for (int i = 1; i < Size; i++)
            {
                remtrianrle[i] = (long)(i) + (long)(remtrianrle[i - 1]);
                added = (long)(i) + (long)(added);
                Result = (long)(added) + (long)(Result);
            }
            long remindex = Size - 3;
            while (remindex > 0)
            {
                Result = (long)(Result) + (long)(remtrianrle[remindex]);
                remindex -= 2;
            }

            // решение вверху не проходит но проходит решение ниже
            //http://ya-znau.ru/znaniya/zn/80
            // Result=Size%2==0?(2*Size*Size*Size+5*Size*Size+2*Size)/8:(2*Size*Size*Size+5*Size*Size+2*Size-1)/8  ;


            Console.WriteLine(Result);
        }

    }




}
