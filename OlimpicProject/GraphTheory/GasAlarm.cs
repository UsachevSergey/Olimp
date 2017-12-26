using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class GasAlarm
    {
          
        sd
        public static void X()
        { 
            string[] MN = Console.ReadLine().Split(' ');
            int CountStr = int.Parse(MN[0]);
            int CountCol = int.Parse(MN[1]);
            int[,] Matrix = new int[CountStr, CountCol]; 
            for (int i = 0; i < CountStr; i++)
            {
                string[] currentStr = Console.ReadLine().Split(' ');
                for (int j = 0; j < CountCol; j++)
                { 
                    Matrix[i, j] = int.Parse(currentStr[j]);
                } 
            }
            //посещеные строки
            //bool[] visit = new bool[CountStr];
            //int infinity = 999999999;

            ////масив минимальных путей
            //int[] Minimumpath = new int[CountStr];
            //for (int i = 0; i < CountStr; i++)
            //{
            //    Minimumpath[i] = infinity;
            //}
            ////идемс из клетки 0.0 
            //Minimumpath[0] = 0;


           





        }
    }
}
