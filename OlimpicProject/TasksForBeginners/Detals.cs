using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Detals
    {
        public static void X()
        {
            string s = Console.ReadLine();
            int str = int.Parse(s.Split(' ')[0]);
            int column = int.Parse(s.Split(' ')[1]);
            int min = 1000;
            for (int i = 0; i < str; i++)
            {
                string ss = Console.ReadLine(); 
                int curentdot = ss.Count(ssd => ssd == '.');
                if (curentdot<min)
                {
                    min = curentdot;
                } 
            }
            Console.WriteLine(min);
        }
    }
}
