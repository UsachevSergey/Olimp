using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Date
    {
        public static void X()
        {
            int a =int.Parse(Console.ReadLine());
            DateTime DT = new DateTime(2008, 1, 1);
           DT= DT.AddDays(a); 
            string m = DT.Month.ToString();
            string d = DT.Day.ToString();
            if (m.Count()==1)
            {
                m = "0" + m;
            }
            if (d.Count()==1)
            {
                d = "0" + d;
            }
            Console.WriteLine(DT.DayOfWeek+", "+d+"."+m);
        }
    }
}
