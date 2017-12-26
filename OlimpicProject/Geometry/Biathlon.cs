using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.Geometry
{
    class Biathlon
    {
        public static void X()
        {
            int result = 0;
            bool[] ups = new bool[5];

            for (int i = 0; i < 5; i++)
            {
                List<int> CoordinateShot = Console.
                    ReadLine().
                    Replace("  ", " ").
                    Trim().Split().
                    ToList().
                    ConvertAll(asertew => int.Parse(asertew));

                for (int s = 0; s < 5; s++)
                {
                    int x = s * 25;
                    int y = 0;
                    if (ups[s])
                    {
                        x = 11111111;
                    }
                    int lenghtx = Math.Abs(CoordinateShot[0] - x);
                    int lenghty = Math.Abs(CoordinateShot[1] - y);
                    //если радиус меньше растояния по попали в мишень
                    if (Math.Sqrt(lenghtx * lenghtx + lenghty * lenghty) <= 10)
                    {
                        result++;
                        ups[s] = true;
                    }
                } 
            }
            Console.WriteLine(result);
        }
    }
} 
