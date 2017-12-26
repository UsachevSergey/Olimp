using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class ConvexHull
    {
        public static void X()
        {
            string[] S = Console.ReadLine().Split();
            int N = int.Parse(S[0]);
            int M = int.Parse(S[1]);
            int minY = 999999;
            int maxY = -1;
            int minX = 999999;
            int maxX = -1;
            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                //если есть звезда
                if (s.Contains("*"))
                {
                    int currentminY = s.IndexOf("*");
                    int currentmaxY = s.LastIndexOf("*");
                    if (currentminY < minY)
                    {
                        minY = currentminY;
                    }
                    if (currentmaxY > maxY)
                    {
                        maxY = currentmaxY;
                    }
                    if (i < minX)
                    {
                        minX = i;
                    }
                    if (i > maxX)
                    {
                        maxX = i;
                    }
                }
            } 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i>=minX && i<=maxX && j>=minY && j<=maxY)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    } 
                }
                Console.WriteLine();
            }



        }
    }
}
