using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Beds
    {
        public static void X()
        { 
            string[] MN = Console.ReadLine().Split(' ');
            int CountStr = int.Parse(MN[0]);
            int CountCol = int.Parse(MN[1]);
            int[,] Matrix = new int[CountStr, CountCol]; 
            for (int i = 0; i < CountStr; i++)
            {
                string currentinputstr = Console.ReadLine();
                for (int j = 0; j < CountCol; j++)
                {
                    Matrix[i, j] = currentinputstr[j] == '#' ? 1 : 0; 
                }
            }

            int COUNTBEDS = 0;
            for (int cstr = 0; cstr < CountStr; cstr++)
            {
                for (int ccol = 0; ccol < CountCol; ccol++)
                {
                    //если клетка вскопана то пускато от нее волну и убирать раскопаные в текущей грядке
                    if (Matrix[cstr, ccol] ==1)
                    {
                        COUNTBEDS++;
                        List<int> I = new List<int>() { cstr };
                        List<int> J = new List<int>() { ccol }; 
                        while (I.Count>0)
                        {
                            int i = I[0]; I.RemoveAt(0);
                            int j = J[0]; J.RemoveAt(0);
                            try
                            {
                                if (Matrix[i + 1, j] == 1)
                                {
                                    Matrix[i + 1, j] = 0;
                                    I.Add(i + 1);
                                    J.Add(j);
                                }
                            }
                            catch { }
                            try
                            {
                                if (Matrix[i - 1, j] == 1)
                                {
                                    Matrix[i - 1, j] = 0;
                                    I.Add(i - 1);
                                    J.Add(j);
                                }
                            }
                            catch { }
                            try
                            {
                                if (Matrix[i , j+ 1] == 1)
                                {
                                    Matrix[i , j+ 1] = 0;
                                    I.Add(i );
                                    J.Add(j+ 1);
                                }
                            }
                            catch { }
                            try
                            {
                                if (Matrix[i  , j-1] == 1)
                                {
                                    Matrix[i , j-1] = 0;
                                    I.Add(i);
                                    J.Add(j-1);
                                }
                            }
                            catch { }
                        } 
                    }
                }
            }
            Console.WriteLine(COUNTBEDS);
             

            


        }
    }
}
