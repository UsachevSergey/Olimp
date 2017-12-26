using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Turn
    {
        public static void X()
        {
            int a =int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            for (int i = a - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
                if (i!=0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
