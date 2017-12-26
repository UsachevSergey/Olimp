using System;
using System.Collections.Generic; 

namespace OlimpicProject.Geometry
{
    class Checkers2
    {
        public static void X()
        {
            string[] coord = Console.ReadLine().Split(' ');
            string pattern = "_abcdefgh";
            int A2 = pattern.IndexOf(coord[0][0].ToString())-1;
            int A1 = int.Parse(coord[0][1].ToString())-1;
            int B2 = pattern.IndexOf(coord[1][0].ToString())-1;
            int B1 = int.Parse(coord[1][1].ToString())-1;
            int[,] Matrix = new int[8, 8];
            List<int> Coordx = new List<int>() { A1 };
            List<int> Coordy = new List<int>() { A2 };
            Matrix[A1, A2] = 1;
            while (Coordx.Count>0)
            {
                int i = Coordx[0]; Coordx.RemoveAt(0);
                int j = Coordy[0]; Coordy.RemoveAt(0);

                try
                {
                    if (Matrix[i+1,j+1]==0)
                    {
                        Matrix[i + 1, j + 1] = 1;
                        Coordx.Add(i + 1); Coordy.Add(j + 1); 
                    }
                }
                catch
                {

                }
                try
                {
                    if (Matrix[i + 1, j - 1] == 0)
                    {
                        Matrix[i + 1, j - 1] = 1;
                        Coordx.Add(i + 1); Coordy.Add(j - 1);
                    }
                }
                catch
                {

                } 
            }
            if (Matrix[B1,B2]>0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
