using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class BlackAndWhiteGraphics
    {
        public static void X()
        {
            string IJ = Console.ReadLine();
            int J = int.Parse(IJ.Split()[0]);
            int I = int.Parse(IJ.Split()[1]);
            byte[,] MatrixA = new byte[I, J];
            byte[,] MatrixB = new byte[I, J];
            for (int i = 0; i < I; i++)
            {
                string currentstr = Console.ReadLine();
                for (int j = 0; j < J; j++)
                {
                    MatrixA[i, j] = byte.Parse(currentstr[j].ToString());
                }
            }
            for (int i = 0; i < I; i++)
            {
                string currentstr = Console.ReadLine();
                for (int j = 0; j < J; j++)
                {
                    MatrixB[i, j] = byte.Parse(currentstr[j].ToString());
                }
            }
            string pattern = Console.ReadLine();
            for (int i = 0; i < I; i++)
            { 
                for (int j = 0; j < J; j++)
                {
                    byte A = MatrixA[i, j];
                    byte B = MatrixB[i, j];
                    if (A == 0 && B == 0) { Console.Write(pattern[0].ToString()); }
                    if (A == 0 && B == 1) { Console.Write(pattern[1].ToString()); }
                    if (A == 1 && B == 0) { Console.Write(pattern[2].ToString()); }
                    if (A == 1 && B == 1) { Console.Write(pattern[3].ToString()); }
                }
                Console.WriteLine();
            }


        }
    }
}
