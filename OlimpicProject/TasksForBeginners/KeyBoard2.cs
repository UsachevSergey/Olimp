using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class KeyBoard2
    {
        public static void X()
        {
            int countKey = int.Parse(Console.ReadLine());
            int[] MaxPress = new int[countKey];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < countKey; i++)
            {
                MaxPress[i] = int.Parse(s[i]);
            }
            int Press = int.Parse(Console.ReadLine());
            string[] presss = Console.ReadLine().Split(' ');
            for (int i = 0; i < Press; i++)
            {
                int curentpress = int.Parse(presss[i])-1;
                MaxPress[curentpress]--;
            }
            for (int i = 0; i < MaxPress.Count(); i++)
            {
                if (MaxPress[i] >= 0)
                {
                    Console.WriteLine("no");
                }
                else
                {
                    Console.WriteLine("yes");
                }
            }


        }
    }
}
