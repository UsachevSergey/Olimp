using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class AlgorithmFloida
    {
        public static void X()
        {

            int SizeMatrix = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[SizeMatrix, SizeMatrix];

            for (int i = 0; i < SizeMatrix; i++)
            { 
                string[] CurrentString = Console.ReadLine().Split(' ');
                for (int j = 0; j < SizeMatrix; j++)
                {
                    Matrix[i, j] = int.Parse(CurrentString[j]);
                }
            }
            //заполнено 

            //применяем алгоритм
            for (int k = 0; k < SizeMatrix; k++)
            {
                for (int i = 0; i < SizeMatrix ; i++)
                {
                    for (int j = 0; j < SizeMatrix; j++)
                    {
                        Matrix[i, j] = Math.Min(Matrix[i, j],
                             Matrix[i, k] + Matrix[k, j]);
                    }
                }
            }

            //выводим
            for (int i = 0; i < SizeMatrix; i++)
            {
                string currentResult = "";
                for (int j = 0; j < SizeMatrix; j++)
                {
                    currentResult += Matrix[i, j] + " ";
                }
              currentResult = currentResult.Trim();
                Console.WriteLine(currentResult);
            }









        }
    }
}
