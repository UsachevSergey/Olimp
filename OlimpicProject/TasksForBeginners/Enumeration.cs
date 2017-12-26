using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Enumeration
    {
        public static void X()
        {
            int countpeople = int.Parse(Console.ReadLine());
            int maxage = -1;
            int numbermaxage = -1;
            for (int i = 0; i < countpeople; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int age = int.Parse(s[0]);
                int sex = int.Parse(s[1]);
                if (sex == 1 && age>maxage)
                {
                    maxage = age;
                    numbermaxage = i + 1;
                }
            }
    Console.WriteLine(numbermaxage);
        }
    }
}


   
    