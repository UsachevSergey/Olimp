using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class DayProgrammer
    {
        public static void X()
        {
            int year = int.Parse(Console.ReadLine());
            DateTime dt = new DateTime(year,1,1);
            dt = dt.AddDays(255);
            Console.WriteLine(dt.ToString().Substring(0,10).Replace('.','/'));

        }
    }
}
