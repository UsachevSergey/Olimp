using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class LuckyTicket2
    {
        public static void X()
        {
            string STR = Console.ReadLine();
            bool yes = false;

            for (int i = 1; i < STR.Length-1; i++)
            {
                int NumberA = 0;
                int NumberB = 0;
                for (int a = 0; a < i; a++)
                {
                    NumberA += int.Parse(STR[a].ToString());
                }
                for (int b = i; b < STR.Length; b++)
                {
                    NumberB += int.Parse(STR[b].ToString());
                }

                while (NumberA.ToString().Length > 1)
                {
                    NumberA = int.Parse(NumberA.ToString().Last().ToString()) + NumberA / 10;
                }
                while (NumberB.ToString().Length > 1)
                {
                    NumberB = int.Parse(NumberB.ToString().Last().ToString()) + NumberB / 10;
                }
                if (NumberA==NumberB)
                {
                    yes = true;
                    break;
                } 
            }

            if (STR.Count() == 2)
            {
                if (STR[0] == STR[1])
                {
                    yes = true;
                }
            }

            if (yes)
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
