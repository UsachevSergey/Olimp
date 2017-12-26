using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Flap
    {
        public static void X()
        {
            string[] MN = Console.ReadLine().Split(' ');
            int CountStr = int.Parse(MN[0]);
            int CountCol = int.Parse(MN[1]);
            int[,] Matrix = new int[CountStr, CountCol];
            for (int i = 0; i < CountStr; i++)
            {
                string[] currentinputstr = Console.ReadLine().Split(' ');
                for (int j = 0; j < CountCol; j++)
                {
                    Matrix[i, j] = int.Parse(currentinputstr[j]); 
                }
            }

            int COUNTFLAP= 0;
            for (int cstr = 0; cstr < CountStr; cstr++)
            {
                for (int ccol = 0; ccol < CountCol; ccol++)
                {
                    //если клетка вырезана
                    if (Matrix[cstr, ccol] == 0)
                    {
                        COUNTFLAP++;
                        List<int> I = new List<int>() { cstr };
                        List<int> J = new List<int>() { ccol };
                        while (I.Count > 0)
                        {
                            int i = I[0]; I.RemoveAt(0);
                            int j = J[0]; J.RemoveAt(0);
                            try
                            {
                                if (Matrix[i + 1, j] == 0)
                                {
                                    Matrix[i + 1, j] = 1;
                                    I.Add(i + 1);
                                    J.Add(j);
                                }
                            }
                            catch { }
                            try
                            {
                                if (Matrix[i - 1, j] == 0)
                                {
                                    Matrix[i - 1, j] = 1;
                                    I.Add(i - 1);
                                    J.Add(j);
                                }
                            }
                            catch { }
                            try
                            {
                                if (Matrix[i, j + 1] == 0)
                                {
                                    Matrix[i, j + 1] = 1;
                                    I.Add(i);
                                    J.Add(j + 1);
                                }
                            }
                            catch { }
                            try
                            {
                                if (Matrix[i, j - 1] == 0)
                                {
                                    Matrix[i, j - 1] = 1;
                                    I.Add(i);
                                    J.Add(j - 1);
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
            Console.WriteLine(COUNTFLAP);
        }

    }
}
