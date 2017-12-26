using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class BattleShip2
    {
        public static void X() {
            string[] s = Console.ReadLine().Split();
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            string[,] arrayballte = new string[N, M];
            for (int i = 0; i < N; i++)
            {
                string cs = Console.ReadLine();
                for (int j = 0; j < M; j++)
                {
                    arrayballte[i,j]= cs[j].ToString();
                }
            }
            int result = 0;
            //всё расставлено.смотрим куда можно поставить
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int countBusyShip = 0;
                    if (arrayballte[i,j]=="*")
                    {
                        countBusyShip++;
                    }
                    try
                    {
                        if (arrayballte[i - 1, j] == "*")
                        {
                            countBusyShip++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (arrayballte[i + 1, j] == "*")
                        {
                            countBusyShip++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (arrayballte[i  , j-1] == "*")
                        {
                            countBusyShip++;
                        }
                    }
                    catch { }
                    try
                    {
                        if (arrayballte[i  , j+1] == "*")
                        {
                            countBusyShip++;
                        }
                    }
                    catch { }
                    if (countBusyShip==0)
                    {
                        result++;
                    }
                } 
            }
            Console.WriteLine(result);

        }
    }
}
