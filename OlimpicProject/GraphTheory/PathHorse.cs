using System;
using System.Collections;

namespace OlimpicProject.GraphTheory
{
    class PathHorse
    {
        public static void X()
        {

            int Size = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[Size, Size];
            int startI = -123;
            int startJ = -123;
            int endI = -123;
            int endJ = -123;
            string[,] MatrixResult = new string[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                string currentStr = Console.ReadLine();
                for (int j = 0; j < Size; j++)
                {
                    if (currentStr[j].ToString() == "@")
                    {
                        if (startI == -123)
                        {
                            startI = i;
                            startJ = j;
                            Matrix[i, j] = 1;
                        }
                        else
                        {
                            endI = i;
                            endJ = j;
                        }
                    }
                    else if (currentStr[j].ToString() == "#")
                    {
                        Matrix[i, j] = -1;
                    }
                    MatrixResult[i, j] = currentStr[j].ToString();
                }
            }//данные внесены

            Queue QI = new Queue();
            Queue QJ = new Queue();
            Queue QCost = new Queue();
            QI.Enqueue(startI);
            QJ.Enqueue(startJ);
            QCost.Enqueue(2);

            bool yes = false;
            //пока в очереди есть чтото 
            while (QI.Count > 0)
            {
                int i = (int)QI.Dequeue();
                int j = (int)QJ.Dequeue();
                int cost = (int)QCost.Dequeue();

                for (int x = -2; x < 3; x++)
                {
                    for (int y = -2; y < 3; y++)
                    {
                        if (Math.Abs(x) + Math.Abs(y) == 3)
                        {
                            try
                            {
                                if (Matrix[i + x, j + y] == 0)
                                {
                                    Matrix[i + x, j + y] = cost;
                                    QI.Enqueue(i + x);
                                    QJ.Enqueue(j + y);
                                    QCost.Enqueue(cost + 1);
                                }
                            }
                            catch { }
                        }
                    }
                }
                if (Matrix[endI, endJ] != 0)
                {
                    yes = true;
                    break;

                }
            }
            //всё раставлено теперь востановить путь

            int lastcost = Matrix[endI, endJ];

            while (lastcost > 1)
            {

                for (int x = -2; x < 3; x++)
                {
                    for (int y = -2; y < 3; y++)
                    {
                        if (Math.Abs(x) + Math.Abs(y) == 3)
                        {
                            try
                            {
                                if (Matrix[endI + x, endJ + y] == lastcost - 1)
                                {
                                    endI += x;
                                    endJ += y;
                                    MatrixResult[endI, endJ] = "@";
                                    lastcost--;
                                    x = 11111;
                                    y = 11111;
                                    break;
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            //тут должно быть востановлено

            if (yes)
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        Console.Write(MatrixResult[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Impossible");
            }


        }
    }
}