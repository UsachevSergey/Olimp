using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class HouseSchoolHouse
    {
        public static void X()
        {
            string station = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            if (station=="School" && count%2==0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
