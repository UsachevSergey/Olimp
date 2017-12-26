using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Thaw
    {public static void X()
        {
            int countday = int.Parse(Console.ReadLine());
            string[] S = Console.ReadLine().Split(' ');
            int daythaw = 0;
            int current = 0;

            for (int i = 0; i < countday; i++)
            {
                int currenttemper = int.Parse(S[i]);
                if (currenttemper > 0)
                {
                    current++;
                    if (current>daythaw)
                    {
                        daythaw = current;
                    }
                }
                else
                {
                    current = 0;
                }
            }
            Console.WriteLine(daythaw);
        }
    }
}
