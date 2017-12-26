using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class BinaryNumbers
    {
        public static void X()
        {
            int a = int.Parse(Console.ReadLine());
            string ret = "NO";
            for (int i = 2; i < 10001; i*=2)
            {
                if (i==a)
                {
                    ret = "YES";
                }
            }
            if (a==1)
            {
                ret = "YES";
            }
            Console.WriteLine(ret);
        }
    }
}
