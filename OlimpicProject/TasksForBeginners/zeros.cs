using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Zeros
    {
        public static void X()
        {
            string s = Console.ReadLine();
            string maxcount = "0";
            int result=0;
            for (int i = 0; i < 101; i++)
            {
                if (s.Contains(maxcount))
                {
                    result++;
                    maxcount = maxcount + "0";
                }
                else
                {
                    i = 102;
                }
            }
            Console.WriteLine(result);
        }
    }
}
