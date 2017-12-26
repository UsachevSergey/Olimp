using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.Geometry
{
    class LenghtOfSegment
    {
        public static void X()
        { 
            List<int> x1y1x2y2 = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            int Vert = Math.Abs(x1y1x2y2[1] - x1y1x2y2[3]);
            int Horizont = Math.Abs(x1y1x2y2[0] - x1y1x2y2[2]);
            double result = Math.Sqrt(Vert * Vert + Horizont * Horizont);
            Console.WriteLine(result.ToString().Replace(",","."));
        }
    }
}
