using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Watermelons
    {
        public static void X()
        {
            int count =int.Parse(Console.ReadLine());
            string[] arraystring = Console.ReadLine().Split(' ') ;
            int[] arrayint = new int[count];
            for (int i = 0; i < count; i++)
            {
                arrayint[i] = int.Parse(arraystring[i]);
            }
            int s = arrayint[0];
            int t = arrayint[0];
            foreach (var item in arrayint)
            {
                if (s<item)
                {
                    s = item;
                }
                if (t>item)
                {
                    t = item;
                }
            }
            Console.WriteLine(t+" "+s);
        }
    }
}
