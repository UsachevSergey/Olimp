using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Pizza
    {
        public static void X()
        {
            int n = int.Parse(Console.ReadLine());
            int result = (n * (n + 1) / 2) + 1;
            Console.WriteLine(result);
        }
    }
}
