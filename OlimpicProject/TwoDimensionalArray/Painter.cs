using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Painter
    {
        public static void X()
        {
            string[] inputCoord = Console.ReadLine().Split(' ');
            int str = int.Parse(inputCoord[0]);
            int col = int.Parse(inputCoord[1]);
            byte[,] Matrix = new byte[str, col];
            int countSquar = int.Parse(Console.ReadLine());
            int result = 0;
            for (int d = 0; d < countSquar; d++)
            {
                string[] coord = Console.ReadLine().Split();
                int X1 = int.Parse(coord[0]);
                int X2 = int.Parse(coord[2]);
                int Y1 = int.Parse(coord[1]);
                int Y2 = int.Parse(coord[3]);
                for (int i = X1; i < X2; i++)
                {
                    for (int j = Y1; j < Y2; j++)
                    {
                        if (Matrix[i,j]!=1)
                        {
                            Matrix[i, j] = 1;
                            result++;
                        }
                    }
                } 
            }

            Console.WriteLine(str*col - result);

        }

    }
}
