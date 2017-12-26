using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class AlgorithmFloida2
    {
        public static void X()
        {

            int SizeMatrix = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[SizeMatrix, SizeMatrix];
            for (int i = 0; i < SizeMatrix; i++)
            { 
                string[] CurrentStr = Console.ReadLine().Split(' '); 
                for (int j = 0; j < SizeMatrix; j++)
                {
                    //если пути нет то ставим большое растояние(пряма не достяжимое)
                    Matrix[i, j] =(CurrentStr[j] == "-1" ? 99999 : int.Parse(CurrentStr[j]));
                }
            }

            for (int k = 0; k < SizeMatrix; k++)
            {
                for (int i = 0; i < SizeMatrix; i++)
                {
                    for (int j = 0; j < SizeMatrix; j++)
                    {
                        Matrix[i, j] = Math.Min(
                            Matrix[i, j],
                            Matrix[i, k] + Matrix[k, j] 
                            );
                    }
                }
            }
            int Max =-1;
            for (int i = 0; i < SizeMatrix; i++)
            {
                for (int j = 0; j < SizeMatrix; j++)
                {
                    if (Matrix[i,j]>Max && Matrix[i,j]!=99999)
                    {
                        Max = Matrix[i, j];
                    }
                }
            }
            Console.WriteLine(Max);








        }
    }
}
