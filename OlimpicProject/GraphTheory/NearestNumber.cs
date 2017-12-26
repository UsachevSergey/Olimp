using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OlimpicProject.GraphTheory
{
    class NearestNumber
    {
        //НЕ УСПЕВАЕТ НУЖЕН АЛГОРИТМ
        public static void X()
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            //те что проверять
            List<int> ListI = new List<int>();
            List<int> ListJ = new List<int>();


            int Size = int.Parse(sr.ReadLine());
            int[,] Matrix = new int[Size, Size];
            bool[,] MatrixBool = new bool[Size, Size];
            int countInt = 0;
            int lastint = 0;
            for (int i = 0; i < Size; i++)
            {
                string[] CurrentStr = sr.ReadLine().Split();
                for (int j = 0; j < Size; j++)
                {
                    //если не конвертировался то откатить j
                    if (int.TryParse(CurrentStr[j], out Matrix[i, j]))
                    {
                        if (Matrix[i, j] > 0)
                        {
                            lastint = Matrix[i, j];
                            countInt++;
                        }
                        else
                        {
                            MatrixBool[i, j] = true;
                            ListI.Add(i);
                            ListJ.Add(j);
                        }

                    }
                    else
                    {
                        j--;
                    }


                }
            } //Тут данные внесены

            if (countInt == 1)
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        Matrix[i, j] = lastint;
                    }
                }
            }
            else if (countInt > 0)
            {
                int MaxWave = Size * 2;

                //идем по всем доступным волнам
                for (int c = 1; c < MaxWave; c++)
                {
                    List<int> indexForDel = new List<int>();
                    List<int> indexforindersI = new List<int>();
                    List<int> indexforindersJ = new List<int>();


                    for (int lij = 0; lij < ListI.Count; lij++)
                    {
                        int i = ListI[lij];
                        int j = ListJ[lij];
                        int up = 0;
                        int left = 0;
                        int right = 0;
                        int down = 0;
                        try { up = Matrix[i - 1, j]; } catch { }
                        try { down = Matrix[i + 1, j]; } catch { }
                        try { left = Matrix[i, j - 1]; } catch { }
                        try { right = Matrix[i, j + 1]; } catch { }
                        List<int> L = new List<int>() { up, down, right, left };
                        int countDistinct = L.Distinct().Count(x => x > -1);
                        if (countDistinct == 2 && L.Contains(0))
                        {
                            Matrix[i, j] = L.Max() * -1;
                            indexForDel.Add(lij);
                            indexforindersI.Add(i);
                            indexforindersJ.Add(j);

                        }
                        else if (countDistinct > 2)
                        {
                            indexForDel.Add(lij);
                        }
                    }

                    //меняем - на +
                    for (int i = 0; i < indexforindersI.Count; i++)
                    {
                        Matrix[indexforindersI[i], indexforindersJ[i]] *= -1;
                    }
                    //удаляем уже просмтренные
                    for (int i = indexForDel.Count - 1; i >= 0; i--)
                    {
                        ListI.RemoveAt(indexForDel[i]);
                        ListJ.RemoveAt(indexForDel[i]);
                    }

                }//конец прохода по кругам

            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    sw.Write((Matrix[i, j] >= 0 ? Matrix[i, j] : Matrix[i, j] * -1) + " ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}
