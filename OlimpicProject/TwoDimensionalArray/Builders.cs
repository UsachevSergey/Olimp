using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Builders
    {
        public static void X()
        {
            int CountBuild = int.Parse(Console.ReadLine()); 
            int[,] BuildTerritory = new int[101, 101];
            for (int H = 0; H < CountBuild; H++)
            {
                string[] currentbuild = Console.ReadLine().Replace("  "," ").Split(' ');
                int x1 = int.Parse(currentbuild[0]);
                int x2 = int.Parse(currentbuild[2]);
                int y1 = int.Parse(currentbuild[1]);
                int y2 = int.Parse(currentbuild[3]);
                if (x1 > x2)
                {
                    int a = x1;
                    x1 = x2;
                    x2 = a;
                }
                if (y1 > y2)
                {
                    int a = y1;
                    y1 = y2;
                    y2 = a;
                }
                for (int i = x1; i < x2; i++)
                {
                    for (int j = y1; j < y2; j++)
                    {
                        BuildTerritory[i, j]++;
                    }
                }   
            }
            string[] MainBuild = Console.ReadLine().Split(' ');
            int X1= int.Parse(MainBuild[0]);
            int X2 = int.Parse(MainBuild[2]);
            int Y1 = int.Parse(MainBuild[1]);
            int Y2 = int.Parse(MainBuild[3]);
            if (X1 > X2)
            {
                int a = X1;
                X1 = X2;
                X2 = a;
            }
            if (Y1 > Y2)
            {
                int a = Y1;
                Y1 = Y2;
                Y2 = a;
            }
                int result = 0;
            for (int i = X1; i < X2; i++)
            {
                for (int j = Y1; j <Y2; j++)
                { 
                        result+= BuildTerritory[i, j]; 
                }
            }
                Console.WriteLine(result); 
        }
    }
}
