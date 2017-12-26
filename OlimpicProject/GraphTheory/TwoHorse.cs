using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class TwoHorse
    {
        public static void X()
        {

            string[] twohorse = Console.ReadLine().Split(' ');
            string pattern = "abcdefgh"; 
            //создали 2 коней с начальными координатами
            horse H1 = new horse(pattern.IndexOf(twohorse[0][0]), int.Parse(twohorse[0][1].ToString())-1); 
            horse H2 = new horse(pattern.IndexOf(twohorse[1][0]), int.Parse(twohorse[1][1].ToString())-1);

            bool end = false;
            //за 5 шагов точно должны встретится 
            for (int c = 0; c < 5;c++)
            { 
                  end = false;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        //если в обоих есть значения то завершить цикл и вывести 
                        if (H1.Matrix[i,j]!=0 &&H2.Matrix[i,j]!=0)
                        {
                            end = true;
                            i = 99;
                            j = 99;
                        }
                    }
                }
                if (end)
                {
                    //если встретились выветси номер шага
                    Console.WriteLine(c);
                    c = 99;
                }
                else
                {
                    H1.Step();
                    H2.Step();
                }
            }
            if (!end)
            {
                Console.WriteLine(-1);
            }

        }
    }
    class horse
    {
        int A, B;

        int MaxIndex = 1;

       public int[,] Matrix = new int[8, 8];

        public horse(int a, int b)
        {
            A = a;
            B = b;
            Matrix[A, B] = 1;
        }

        internal void Step()
        {
            int[,] NewMatrix = new int[8, 8];
            //проходить по всему масиву и из всех чисел которые равны индексу делать шаг
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                     
                        if (Matrix[i,j]==MaxIndex)
                        {
                        try
                        {
                            NewMatrix[i-1, j-2] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i-1, j+2] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i-2, j-1] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i-2, j+1] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i+1, j+2] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i+1, j-2] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i+2, j-1] = MaxIndex + 1;
                        }
                        catch { }
                        try
                        {
                            NewMatrix[i+2, j+1] = MaxIndex + 1;
                        }
                        catch { } 
                    } 
                }
            }
            Matrix = NewMatrix;
            MaxIndex++;
        }

    }
}
