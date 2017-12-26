using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GreedyAlgorithm
{
    class FunWithTheMeter
    {
        public static void X()
        { 
            int CountPoint = int.Parse(Console.ReadLine());
            List<point> Points = new List<point>();
            for (int i = 0; i < CountPoint; i++)
            {
                string[] s = Console.ReadLine().Split();
                Points.Add(new point()
                {
                    a = int.Parse(s[0]),
                    b = int.Parse(s[1])
                }); 
            }
            List<double> ListDoubleResult = new List<double>();
            for (int i = 0; i < CountPoint; i++)
            {
                for (int j = i+1; j < CountPoint; j++)
                {
                    int width  = Math.Abs(Points[i].a - Points[j].a);
                    int height = Math.Abs(Points[i].b - Points[j].b);
                    ListDoubleResult.Add(
                        Math.Sqrt(width * width + height * height)
                        );
                }
            }
            ListDoubleResult = ListDoubleResult.Distinct().ToList();
            ListDoubleResult.Sort();
            Console.WriteLine(ListDoubleResult.Count);
            for (int i = 0; i < ListDoubleResult.Count; i++)
            {
                Console.WriteLine(ListDoubleResult[i].ToString().Replace(',','.'));
            } 
        }
        struct point
        {
            public int a, b;
        }
    }
}
