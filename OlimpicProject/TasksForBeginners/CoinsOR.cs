using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class CoinsOR
    {
        public static void X()
        {
            int countcoins = int.Parse(Console.ReadLine());
            int spA = 0;
            int spB = 0;
            for (int i = 0; i < countcoins; i++)
            {
                if (Console.ReadLine()=="0")
                {
                    spA++;
                }
                else
                {
                    spB++;
                }
            }
            Console.WriteLine(Math.Min(spB,spA));
        }
    }
}
//
