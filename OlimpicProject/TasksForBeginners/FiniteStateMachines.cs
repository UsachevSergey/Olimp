using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class FiniteStateMachines
    {
        public static void X()
        {
            int count = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < count; i++)
            { 
                int result = 0;
                string[] curents = Console.ReadLine().Split(' ');
                int n = int.Parse(curents[0]);
                int m = int.Parse(curents[1]);
                result = 19 * m + (n + 239) * (n + 366) / 2; 
                Console.WriteLine(result);
            }
        }
    }
}
