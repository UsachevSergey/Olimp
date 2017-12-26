using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Geometry
{
    class Traps
    {
        public static void X()
        {

            int CountTraps = int.Parse(Console.ReadLine());
            List<int> CoordX = new List<int>() { 0 };
            List<int> CoordY = new List<int>() { 0 };
            for (int i = 0; i < CountTraps; i++)
            { 
                List<int> currentTraps = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
                CoordX.Add(currentTraps[0]);
                CoordY.Add(currentTraps[1]);
            }
            CoordX.Add(0);
            CoordY.Add(0);
            double result = 0;

            for (int i = 0; i < CoordX.Count-1; i++)
            {
                int X1 = CoordX[i];
                int X2 = CoordX[i + 1];
                int lenghtX = Math.Abs(X2 - X1);
                int Y1 = CoordY[i];
                int Y2 = CoordY[i + 1]; 
                int lenghtY = Math.Abs(Y2 - Y1);
                result += Math.Sqrt(lenghtX * lenghtX + lenghtY * lenghtY);
            }
            
            Console.WriteLine(result.ToString().Replace(",","."));

        }
    }
}
