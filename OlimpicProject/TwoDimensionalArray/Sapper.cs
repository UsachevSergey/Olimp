using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Sapper
    {
        public static void X()
        {
            string[] InputStr = Console.ReadLine().Split();
            int str = int.Parse(InputStr[0]);
            int col = int.Parse(InputStr[1]);
            int countmine = int.Parse(InputStr[2]);
            string[,] Matrix = new string[str, col];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Matrix[i, j] = ".";

                }
            }

            for (int i = 0; i < countmine; i++)
            {
                string[] coordinatemine = Console.ReadLine().Split();
                Matrix[int.Parse(coordinatemine[0]) - 1, int.Parse(coordinatemine[1]) - 1] = "*";
            }
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Matrix[i,j]!="*")
                    {
                        int countminearound = 0;

                        for (int ii = -1; ii < 2; ii++)
                        {
                            for (int jj = -1; jj < 2; jj++)
                            {
                                try
                                {
                                    if (Matrix[i+ii, j+jj] == "*")
                                    {
                                        countminearound++;
                                    }
                                }
                                catch { }
                            }
                        }
                        
                        if (countminearound > 0)
                        {
                            Matrix[i, j] = countminearound.ToString();
                        }
                    } 
                }
                string result = "";
                for (int j = 0; j < col; j++)
                {
                    result += Matrix[i, j];
                }
                Console.WriteLine(result);
            }

        }
    }
}
