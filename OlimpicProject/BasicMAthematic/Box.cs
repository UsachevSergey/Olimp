using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.BasicMAthematic
{
    class Box
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            string[] s2 = Console.ReadLine().Split();
            List<int> box1 = new List<int>() { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };
            List<int> box2 = new List<int>() { int.Parse(s2[0]), int.Parse(s2[1]), int.Parse(s2[2]) };
            box1.Sort();
            box2.Sort();
            if (box1[0] == box2[0] && box1[1] == box2[1] && box1[2] == box2[2] )
            {
                Console.WriteLine("Boxes are equal");
            }
            else if (box1[0] >= box2[0] && box1[1] >= box2[1] && box1[2] >= box2[2])
            { Console.WriteLine("The first box is larger than the second one");
               
            }
            else if (box1[0] <= box2[0] && box1[1] <= box2[1] && box1[2] <= box2[2])
            {
                Console.WriteLine("The first box is smaller than the second one");
            }
            else
            {
                Console.WriteLine("Boxes are incomparable");
            }
        }
    }
}
