using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Cake
    {
        public static void X()
        {
            int guest = int.Parse(Console.ReadLine());
            if (guest % 2 == 0)
            {
                Console.WriteLine(guest / 2);
            }
            else
            {
                if (guest == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
