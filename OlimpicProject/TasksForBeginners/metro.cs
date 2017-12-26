using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Metro
    {
        public static void X() {
            string[] s = Console.ReadLine().Split(' ');
            int countstation = int.Parse(s[0]);
            int curentstation = int.Parse(s[1]);
            int endstation = int.Parse(s[2]);
            //прямой путь
            int var1 =Math.Abs(curentstation - endstation)-1;
            int var2 = countstation - Math.Max(curentstation, endstation) + Math.Min(curentstation, endstation)-1;           
            Console.WriteLine(Math.Min(var1,var2));
        }
    }
}
