using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Subarrayarray
    {
        public static void X()
        {
            int countarray = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            int countsubarray = int.Parse(Console.ReadLine());
            for (int i = 0; i < countsubarray; i++)
            { 
                string[] currentS = Console.ReadLine().Split(' ');
                //начальная позиция
                int a = int.Parse(currentS[0])-1;
                //конечная позиция
                int b = int.Parse(currentS[1]);
                string r="";
                for (int j = a; j < b; j++)
                {
                    r = r + " " + arr[j];
                }
               r= r.Trim();
                Console.WriteLine(r);
            }
        }
    }
}
