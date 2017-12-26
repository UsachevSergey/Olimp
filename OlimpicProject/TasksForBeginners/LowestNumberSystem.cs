using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class LowestNumberSystem
    {
        public static void X()
        {
            string S = Console.ReadLine();
            string et = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int MinSystem=2;
            for (int i = 0; i < S.Length; i++)
            {
                int curentMinSystem = et.IndexOf(S[i].ToString());
                if (curentMinSystem==-1)
                {
                    MinSystem = -1;
                    break; 
                }
                else
                {
                    if (curentMinSystem+1>MinSystem)
                    {
                        MinSystem = curentMinSystem+1;
                    }
                }
            }
            Console.WriteLine(MinSystem);
        }
    }
} 