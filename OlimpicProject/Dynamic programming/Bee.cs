using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bee
{
    public static void X()
    {
        long S = long.Parse(Console.ReadLine());
        long size = S * 2 - 1;
        long[,] Matrix = new long[size, size];
        ///заполняем первоначальную матрицу так чтобы недопустимые клетки были равны  99999999;
        for (long i = 0; i < size; i++)
        { 
            for (long j = 0; j < size; j++)
            { 
                if (size/2>i)
                {
                    if (size/2<j && j-i>=S)
                    {
                        Matrix[i, j] = 99999999;
                    }
                }
                else if (size / 2 < i)
                {
                    if (size / 2 > j && i-j>=S)
                    {
                        Matrix[i, j] = 99999999;
                    } 
                } 
            }
        } 


        for (long i = 0; i < size; i++)
        {
            for (long j = 0; j < size; j++)
            {
                
                if (Matrix[i, j] != 99999999 )
                {
                    long left = 0;
                    long up = 0;
                    long upleft = 0;
                    try
                    {
                        if (Matrix[i, j - 1] != 99999999)
                        {
                            left = Matrix[i, j - 1];
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i - 1, j] != 99999999)
                        {
                            up = Matrix[i - 1, j];
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i - 1, j - 1] != 99999999)
                        {
                            upleft = Matrix[i - 1, j - 1];
                        }
                    }
                    catch { }

                    if (i==0 && j==0)
                    {
                        up = 1;
                    }
                    Matrix[i, j] = up + left + upleft;
                }


            }
        }


        Console.WriteLine(Matrix[size-1,size-1]);
    }
}