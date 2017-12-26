using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Circlesinnumbers
    {
        public static void X()
        {
            string s = Console.ReadLine();
            int count = 0;
            foreach (var item in s)
            {
                if (item.ToString()=="6"|| item.ToString()=="9" ||item.ToString()=="0")
                {
                    count++;
                }
                else if (item.ToString() == "8")
                {
                    count += 2;
                }
            }
            Console.WriteLine(count);
        }
    }
}
