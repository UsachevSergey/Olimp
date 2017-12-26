using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class QueueVasilii
    {
        public static void X()
        {
            int a =int.Parse(Console.ReadLine());
            DateTime dt = new DateTime(1, 1, 1, 8, 0, 0);
            int timeinqueue = 0;
            for (int i = 1; i < a; i++)
            {
                timeinqueue += 5;
               dt= dt.AddMinutes(5);
            }
            if (dt.Hour < 20 && dt.Day == 1)
            {
                string result = (timeinqueue / 60) + " " + (timeinqueue % 60);
                Console.WriteLine(result);
            }
            else
            {
                if (dt.Hour == 20 && dt.Minute==0 && dt.Day == 1)
                {
                    string result = (timeinqueue / 60) + " " + (timeinqueue % 60);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}
