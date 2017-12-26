using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Arithmetic
    {
        public static void X()
        {
            string a = Console.ReadLine();
            if (int.Parse(a.Split(' ')[0])* int.Parse(a.Split(' ')[1])== int.Parse(a.Split(' ')[2]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
