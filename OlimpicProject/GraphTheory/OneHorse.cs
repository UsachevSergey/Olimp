using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class OneHorse
    {
        public static void X()
        {

            int Size = int.Parse(Console.ReadLine());

            string[] CoordinateStars = Console.ReadLine().Split(' ');
            int StartI = int.Parse(CoordinateStars[0])-1;
            int StartJ = int.Parse(CoordinateStars[1])-1;
            string[] CoordinateEnd = Console.ReadLine().Split(' ');
            int EndI = int.Parse(CoordinateEnd[0])-1;
            int EndJ = int.Parse(CoordinateEnd[1])-1; 
            List<int> CurrentI = new List<int>() { StartI };
            List<int> CurrentJ = new List<int>() { StartJ };
            List<int> CurrentCost = new List<int>() { 1 };


            int[,] Matrix = new int[Size, Size];
            Matrix[StartI, StartJ] = 1;
            int INDEX = 0;
            while (INDEX<CurrentI.Count)
            { 
                //берем значения и удаляем их из списка
                int CI = CurrentI[INDEX]; 
                int CJ = CurrentJ[INDEX];
                int CC = CurrentCost[INDEX];
                INDEX++; 
                try
                {
                    if (Matrix[CI - 1, CJ - 2] == 0)
                    {
                        Matrix[CI - 1, CJ - 2] = CC + 1;
                        CurrentI.Add(CI - 1); CurrentJ.Add(CJ - 2); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI - 2, CJ - 1] == 0)
                    {
                        Matrix[CI - 2, CJ - 1] = CC + 1;
                        CurrentI.Add(CI - 2); CurrentJ.Add(CJ - 1); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI - 1, CJ +2] == 0)
                    {
                        Matrix[CI - 1, CJ + 2] = CC + 1;
                        CurrentI.Add(CI - 1); CurrentJ.Add(CJ + 2); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI - 2, CJ +1] == 0)
                    {
                        Matrix[CI - 2, CJ +1] = CC + 1;
                        CurrentI.Add(CI -2); CurrentJ.Add(CJ +1); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI + 1, CJ - 2] == 0)
                    {
                        Matrix[CI + 1, CJ - 2] = CC + 1;
                        CurrentI.Add(CI + 1); CurrentJ.Add(CJ - 2); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI + 1, CJ + 2] == 0)
                    {
                        Matrix[CI + 1, CJ + 2] = CC + 1;
                        CurrentI.Add(CI + 1); CurrentJ.Add(CJ + 2); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI + 2, CJ - 1] == 0)
                    {
                        Matrix[CI + 2, CJ - 1] = CC + 1;
                        CurrentI.Add(CI + 2); CurrentJ.Add(CJ - 1); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }
                try
                {
                    if (Matrix[CI + 2, CJ + 1] == 0)
                    {
                        Matrix[CI + 2, CJ + 1] = CC+1;
                        CurrentI.Add(CI + 2); CurrentJ.Add(CJ + 1); CurrentCost.Add(CC + 1);
                    }
                }
                catch { }

                if (Matrix[EndI, EndJ]>0)
                {
                    break;
                }
            }

            Console.WriteLine(Matrix[EndI,EndJ]-1);




        }
    }
}
