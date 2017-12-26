using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Basketball
    {
        public static void X()
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                 a+= int.Parse(s[0]);
                 b+= int.Parse(s[1]); 
            }
            if (a>b)
            {
                Console.WriteLine(1);
            }
            else if (b>a)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine("DRAW");
            }

        }
    }
}
