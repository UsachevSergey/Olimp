using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Birthday2
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int EndDay = int.Parse(s[0]);
            int EndMonth = int.Parse(s[1]);
            string[] s2 = Console.ReadLine().Split(' ');
            DateTime CurentDT = new DateTime(int.Parse(s2[2]), int.Parse(s2[1]), int.Parse(s2[0]));

            int result = 0;
            bool end = true;

            //пока дни не совпадают 
            while (end)
            { 
                if (CurentDT.Month == EndMonth && CurentDT.Day == EndDay)
                {
                    end = false;
                }
                else
                {
                    CurentDT = CurentDT.AddDays(1);
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
