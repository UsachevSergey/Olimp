using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.Geometry
{
    class TwoCircles
    {
        public static void X()
        {
            List<int> a = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            List<int> b = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            int vert = Math.Abs(a[0] - b[0]);
            int horiz = Math.Abs(a[1] - b[1]);
            double Width = Math.Sqrt((horiz * horiz) + (vert * vert));
            //если растояние между отрезками - сумма радиусов >0  
            //или одна из окружностей находится внутри другой окружности 
            if (Width-(a[2]+b[2])>0 || Width + Math.Min(a[2], b[2]) < Math.Max(a[2], b[2]))
            {
                  
                    Console.WriteLine("NO");
               
            }
            else
            {
                Console.WriteLine("YES");
            }




        }
    }
}
