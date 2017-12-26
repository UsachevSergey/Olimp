using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Flowers
    {
        public static void X()
        {
            int day = int.Parse(Console.ReadLine());
            if (day%3==0)
            {
                Console.WriteLine("GCV");
            }
            else if (day%3==1)
            {
                Console.WriteLine("VGC");
            }
            else
            {
                Console.WriteLine("CVG");
            }
            
        }
    }
}
