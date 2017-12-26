using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class CollectBlueBerries
    {
        public static void X()
        {
            int count = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int max = 0;
            for (int i = 0; i < count; i++)
            {
                int currentmax = 0;
                if (i == 0)
                {
                    currentmax = int.Parse(s[0]) + int.Parse(s[1]) + int.Parse(s[count-1]);
                }
                else if (i ==(count-1) )
                {
                    currentmax = int.Parse(s[0]) + int.Parse(s[count-2]) + int.Parse(s[count - 1]);
                }
                else
                {
                    currentmax = int.Parse(s[i - 1]) + int.Parse(s[i]) + int.Parse(s[i + 1]);
                }
                if (max<currentmax)
                {
                    max = currentmax;
                }
            }
            Console.WriteLine(max);
        }
    }
}
