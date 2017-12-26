using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class BirthDay
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split('.');
            string[] s2 = Console.ReadLine().Split('.');
            DateTime dt1 = new DateTime(int.Parse(s[2]), int.Parse(s[1]), int.Parse(s[0]));
            DateTime dt2 = new DateTime(int.Parse(s2[2]), int.Parse(s2[1]), int.Parse(s2[0]));
            TimeSpan ts = dt1 - dt2;
            Console.WriteLine(Math.Abs(ts.Days));
        }
    }
}
