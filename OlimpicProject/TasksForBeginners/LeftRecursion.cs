using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class LeftRecursion
    {
        public static void X()
        {
            int count = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                string S = Console.ReadLine(); 
                if (S[0]==S[3])
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
