using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class BusTour
    {
        public static void X()
        {
            int countBridge = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            bool ok = true;
            int numberBridgeCrash = 0;
            for (int i = 0; i < countBridge; i++)
            {
                if (int.Parse(s[i])<=437)
                {
                    numberBridgeCrash = i+1;
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                Console.WriteLine("No crash");
            }
            else
            {
                Console.WriteLine("Crash {0}",numberBridgeCrash);
            }
        }
    }
}
