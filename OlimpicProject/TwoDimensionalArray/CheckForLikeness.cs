using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class CheckForLikeness
    {
        public static void X()
        {
            int CountTest = int.Parse(Console.ReadLine());
            for (int kk = 0; kk < CountTest; kk++)
            {
                string result = "YES";
                string[] mn = Console.ReadLine().Split();
                int str = int.Parse(mn[0]);
                int col = int.Parse(mn[1]);
                byte[,] CurrentMatrix = new byte[str, col]; 
                for (int i = 0; i < str; i++)
                {
                    string[] currentinputstringmatrix = Console.ReadLine().Split();
                    for (int j = 0; j < col; j++)
                    {
                        CurrentMatrix[i, j] = byte.Parse(currentinputstringmatrix[j]);
                    }
                }
                for (int i = 1; i < str; i++)
                {
                    for (int j = 1; j < col; j++)
                    {
                        if (CurrentMatrix[i, j]+ 
                            CurrentMatrix[i-1, j]+
                            CurrentMatrix[i, j-1]+
                            CurrentMatrix[i-1, j-1]==0
                            )
                        {
                            result = "NO";
                        }
                    }
                } 
                Console.WriteLine(result);
            }
        }
    }
}
