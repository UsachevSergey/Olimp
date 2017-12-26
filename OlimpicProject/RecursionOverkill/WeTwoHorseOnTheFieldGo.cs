using System;
using System.Collections.Generic; 

namespace OlimpicProject.RecursionOverkill
{
    class WeTwoHorseOnTheFieldGo
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(',');
            s[0] = s[0].Trim();
            s[1] = s[1].Trim();

            int starti = int.Parse(s[0][0].ToString()
                .Replace("a", "1").Replace("b", "2").Replace("c", "3")
                .Replace("d", "4").Replace("e", "5").Replace("f", "6")
                .Replace("g", "7").Replace("h", "8")
                ) - 1;
            int startj = int.Parse(s[0][1].ToString()) - 1;
            int endi = int.Parse(s[1][0].ToString()
                .Replace("a", "1").Replace("b", "2").Replace("c", "3")
                .Replace("d", "4").Replace("e", "5").Replace("f", "6")
                .Replace("g", "7").Replace("h", "8")
                ) - 1;
            int endj = int.Parse(s[1][1].ToString()) - 1;

            int[,] Matrix = new int[8, 8]; 
            List<int> I = new List<int>() { starti };
            List<int> J = new List<int>() { startj };
            List<int> Cost = new List<int>() { 1 };

            while (I.Count > 0)
            {
                int currenti = I[0]; I.RemoveAt(0);
                int currentj = J[0]; J.RemoveAt(0);
                int currentcost = Cost[0]; Cost.RemoveAt(0);

                for (int i = -2; i < 3; i++)
                {
                    for (int j = -2; j < 3; j++)
                    {
                        if (Math.Abs(i) + Math.Abs(j) == 3)
                        {
                            try
                            {
                                if (Matrix[currenti + i, currentj + j] == 0)
                                {
                                    Matrix[currenti + i, currentj + j] = currentcost;
                                    I.Add(currenti + i);
                                    J.Add(currentj + j);
                                    Cost.Add(currentcost + 1);
                                }
                            }  catch  { }
                        }
                    }
                }
            }

            if (Matrix[endi, endj] != 2 && Matrix[endi, endj] != 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine(Matrix[endi, endj]);
            }

        }

    }
}
