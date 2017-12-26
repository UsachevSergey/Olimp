using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class MythicalChess
    {
        public static void X()
        { 
            string[] Input = Console.ReadLine().Split(' ');
            int[,] Matrix = new int[9, 9];
            string pattern = "ABCDEFGHI";
            int StartI = int.Parse(Input[0][1].ToString()) - 1; 
            int StartJ =pattern.IndexOf( Input[0][0].ToString()) ; 
            int EndI = int.Parse(Input[1][1].ToString()) - 1; 
            int EndJ = pattern.IndexOf(Input[1][0].ToString());
            //координаты получены.
            //до точки нельзя дойти если начальная точка белая (i+j%2 =1) и 
            //кончная точка белая и до конечной не дойдет за шаг
            //или 
            //начальная точка черная а конечная точка белая 

            //начинаем заполнять
            List<int> I = new List<int>() { StartI };
            List<int> J = new List<int>() { StartJ };
            Matrix[I[0], J[0]] = 1;

            while (I.Count>0)
            {
                int i = I[0]; I.RemoveAt(0);
                int j = J[0]; J.RemoveAt(0);

                //если стоит на белой то походить как конь
                if ((i+j)%2==1)
                {
                    try
                    {
                        if (Matrix[i + 2, j + 1] == 0)
                        {
                            Matrix[i + 2, j + 1] = Matrix[i, j] + 1;
                            I.Add(i + 2);
                            J.Add(j + 1);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i + 2, j - 1] == 0)
                        {
                            Matrix[i + 2, j - 1] = Matrix[i, j] + 1;
                            I.Add(i + 2);
                            J.Add(j - 1);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i - 2, j + 1] == 0)
                        {
                            Matrix[i - 2, j + 1] = Matrix[i, j] + 1;
                            I.Add(i - 2);
                            J.Add(j + 1);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i - 2, j - 1] == 0)
                        {
                            Matrix[i - 2, j - 1] = Matrix[i, j] + 1;
                            I.Add(i - 2);
                            J.Add(j - 1);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i + 1, j + 2] == 0)
                        {
                            Matrix[i + 1, j + 2] = Matrix[i, j] + 1;
                            I.Add(i + 1);
                            J.Add(j + 2);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i + 1, j - 2] == 0)
                        {
                            Matrix[i + 1, j - 2] = Matrix[i, j] + 1;
                            I.Add(i + 1);
                            J.Add(j - 2);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i - 1, j + 2] == 0)
                        {
                            Matrix[i - 1, j + 2] = Matrix[i, j] + 1;
                            I.Add(i - 1);
                            J.Add(j + 2);
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i - 1, j - 2] == 0)
                        {
                            Matrix[i - 1, j - 2] = Matrix[i, j] + 1;
                            I.Add(i - 1);
                            J.Add(j - 2);
                        }
                    }
                    catch { } 
                }
                //если как слон
                else
                {
                    for (int a = 1; a < 10; a++)
                    {
                        try
                        {
                            if (Matrix[i + a, j + a] == 0)
                            {
                                Matrix[i + a, j + a] = Matrix[i, j] + 1;
                                I.Add(i + a);
                                J.Add(j + a);
                            }
                        }
                        catch { }
                        try
                        {
                            if (Matrix[i + a, j - a] == 0)
                            {
                                Matrix[i + a, j - a] = Matrix[i, j] + 1;
                                I.Add(i + a);
                                J.Add(j - a);
                            }
                        }
                        catch { }
                        try
                        {
                            if (Matrix[i - a, j + a] == 0)
                            {
                                Matrix[i - a, j + a] = Matrix[i, j] + 1;
                                I.Add(i - a);
                                J.Add(j + a);
                            }
                        }
                        catch { }
                        try
                        {
                            if (Matrix[i - a, j - a] == 0)
                            {
                                Matrix[i - a, j - a] = Matrix[i, j] + 1;
                                I.Add(i - a);
                                J.Add(j - a);
                            }
                        }
                        catch { }
                    }
                }

                if (Matrix[EndI, EndJ]!=0)
                {
                    break;
                }
            }

            Console.WriteLine(Matrix[EndI,EndJ]-1);
             
        }



    }
}
