using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Paths
    {
        public static void X()
        {

            int size = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {

                string[] currentstr = Console.ReadLine().Split(' ');
                for (int j = 0; j < size; j++)
                {
                    Matrix[i, j] = currentstr[j] == "0" ? 99999 : int.Parse(currentstr[j]);
                }
            }
            //ищем кратчайшие пути всего алгоритмом флойда

            for (int k = 0; k < size; k++)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Matrix[i, j] = Math.Min(
                            Matrix[i, j],
                            Matrix[i, k] + Matrix[k, j]
                            );
                    }
                }
            } 
            string[] IJ = Console.ReadLine().Split(' ');
            int I = int.Parse(IJ[0])-1;
            int J = int.Parse(IJ[1])-1;
            string result = (Matrix[I, J] == 99999 ? -1 : Matrix[I, J]).ToString();
            if (I==J)
            {
                result = "0";
            }
            Console.WriteLine(result);


        }
    }
}
