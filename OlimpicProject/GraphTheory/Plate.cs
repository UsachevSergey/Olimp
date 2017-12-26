using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Plate
    {
        public static void X()
        {

            string[] MN = Console.ReadLine().Split(' ');
            int CountRow = int.Parse(MN[0]);
            int CountCol = int.Parse(MN[1]);
            int[,] Matrix = new int[CountRow, CountCol];
            List<int> LastI = new List<int>();
            List<int> LastJ = new List<int>();
            List<int> LastCost = new List<int>(); 
            for (int i = 0; i < CountRow; i++)
            { 
                string[] CurrentStr = Console.ReadLine().Split(' ');

                for (int j = 0; j < CountCol; j++)
                {
                    Matrix[i, j] = int.Parse(CurrentStr[j]);
                    if (Matrix[i,j]==1)
                    {
                        LastJ.Add(j);
                        LastI.Add(i);
                        LastCost.Add(1);
                        Matrix[i, j] = -1;
                    }
                }
            }
            //пока есть токуда идти
            while (LastI.Count>0)
            {
                int currentI = LastI[0];
                int currentJ = LastJ[0];
                int currentCost = LastCost[0];
                LastI.RemoveAt(0);
                LastJ.RemoveAt(0);
                LastCost.RemoveAt(0);

                try
                {
                    if (Matrix[currentI + 1, currentJ] == 0)
                    {
                        Matrix[currentI + 1, currentJ] = currentCost;
                        LastI.Add(currentI + 1);
                        LastJ.Add(currentJ);
                        LastCost.Add(currentCost + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[currentI - 1, currentJ] == 0)
                    {
                        Matrix[currentI- 1, currentJ] = currentCost;
                        LastI.Add(currentI - 1);
                        LastJ.Add(currentJ);
                        LastCost.Add(currentCost + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[currentI, currentJ + 1] == 0)
                    {
                        Matrix[currentI , currentJ+ 1] = currentCost;
                        LastI.Add(currentI );
                        LastJ.Add(currentJ+ 1);
                        LastCost.Add(currentCost + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[currentI , currentJ - 1] == 0)
                    {
                        Matrix[currentI , currentJ - 1] = currentCost;
                        LastI.Add(currentI );
                        LastJ.Add(currentJ- 1);
                        LastCost.Add(currentCost + 1);
                    }
                }
                catch { } 
            }
            for (int i = 0; i < CountRow; i++)
            {
                string result = "";
                for (int j = 0; j < CountCol; j++)
                {
                    if (Matrix[i,j]==-1)
                    {
                        Matrix[i, j] = 0;
                    }
                    result += Matrix[i, j] + " ";
                }
                Console.WriteLine(result.Trim());
            } 
        }
    }
}
