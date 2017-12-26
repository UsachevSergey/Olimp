using System;
using System.Collections.Generic; 

namespace OlimpicProject.GraphTheory
{
    class Lines
    {
        public static void X()
        {

            int Size = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[Size, Size];

            List<int> LastI = new List<int>();
            List<int> LastJ = new List<int>();
            List<int> LastCost = new List<int>();


            int PointEndI = 0;
            int PointEndJ = 0;
            //матрица которую надо будет вывести
            string[,] MatrixResult = new string[Size, Size];


            for (int i = 0; i < Size; i++)
            {
                string CurrentStr = Console.ReadLine();

                for (int j = 0; j < Size; j++)
                {
                   MatrixResult[i, j] = CurrentStr[j].ToString();

                    if (CurrentStr[j] == 'O')
                    {
                        Matrix[i, j] = 99999;
                    }
                    else if (CurrentStr[j] == 'X')
                    {
                        LastI.Add(i);
                        LastJ.Add(j);
                        LastCost.Add(1);
                        Matrix[i, j] = 1;
                    }
                    else if (CurrentStr[j] == '@')
                    {
                        PointEndI = i;
                        PointEndJ = j;
                    }
                }
            }
            //матрица заполнена
            //пускаем волну и ищем кратчайший путь
            while (LastI.Count > 0)
            {
                int currentI = LastI[0]; LastI.RemoveAt(0);
                int currentJ = LastJ[0]; LastJ.RemoveAt(0);
                int currentCost = LastCost[0] + 1; LastCost.RemoveAt(0);
                try
                {
                    if (Matrix[currentI + 1, currentJ] == 0)
                    {
                        Matrix[currentI + 1, currentJ] = currentCost;
                        LastI.Add(currentI + 1);
                        LastJ.Add(currentJ);
                        LastCost.Add(currentCost);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[currentI, currentJ + 1] == 0)
                    {
                        Matrix[currentI, currentJ + 1] = currentCost;
                        LastI.Add(currentI);
                        LastJ.Add(currentJ + 1);
                        LastCost.Add(currentCost);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[currentI - 1, currentJ] == 0)
                    {
                        Matrix[currentI - 1, currentJ] = currentCost;
                        LastI.Add(currentI - 1);
                        LastJ.Add(currentJ);
                        LastCost.Add(currentCost);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[currentI, currentJ - 1] == 0)
                    {
                        Matrix[currentI, currentJ - 1] = currentCost;
                        LastI.Add(currentI);
                        LastJ.Add(currentJ - 1);
                        LastCost.Add(currentCost);
                    }
                }
                catch { }
                if (Matrix[PointEndI, PointEndJ] != 0)
                {
                    break;
                }
            }


            //теперь зарисовываем
            //если волна дошла
            if (Matrix[PointEndI, PointEndJ] > 0)
            {
                int CurrentMax = Matrix[PointEndI, PointEndJ];

                while (CurrentMax > 1)
                {
                    try
                    {
                        if (Matrix[PointEndI - 1, PointEndJ] == CurrentMax - 1)
                        {

                            PointEndI--; 
                            CurrentMax--;

                            MatrixResult[PointEndI, PointEndJ] = "+";
                            continue;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[PointEndI + 1, PointEndJ] == CurrentMax - 1)
                        {
                            PointEndI++; 
                            CurrentMax--;

                            MatrixResult[PointEndI, PointEndJ] = "+";
                            continue;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[PointEndI, PointEndJ+1] == CurrentMax - 1)
                        {
                            PointEndJ++;
                            CurrentMax--;

                            MatrixResult[PointEndI, PointEndJ] = "+";
                            continue;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[PointEndI , PointEndJ-1] == CurrentMax - 1)
                        {
                            PointEndJ--; 
                            CurrentMax--;

                            MatrixResult[PointEndI, PointEndJ] = "+";
                            continue;

                        }
                    }
                    catch { }   
                }

                Console.WriteLine("Yes");
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        Console.Write(MatrixResult[i,j]);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
