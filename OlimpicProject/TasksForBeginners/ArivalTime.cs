using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class ArivalTime
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(':');
            DateTime D = new DateTime(1, 1, 1, int.Parse(s[0]), int.Parse(s[1]), 0);
            string[] s2 = Console.ReadLine().Split(' ');
            TimeSpan t = new TimeSpan(int.Parse(s2[0]), int.Parse(s2[1]), 0);
            D = D.Add(t);
            Console.WriteLine(D.TimeOfDay.ToString().Substring(0,5));
        }
    }
}
