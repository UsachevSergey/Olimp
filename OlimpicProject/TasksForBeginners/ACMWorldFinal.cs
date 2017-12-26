using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class ACMWorldFinal
    {
        public static void X()
        {
            string team = Console.ReadLine();
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            List<string> Names = new List<string>();
            Names.Add(name1);
            Names.Add(name2);
            Names.Add(name3);
            Names.Sort();

            Console.WriteLine(team+": " + Names[0] + ", " + Names[1] + ", " + Names[2]);

        }
    }
}
