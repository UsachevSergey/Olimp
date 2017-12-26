using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class LazyPerson
    {
        public static void X()
        {
            
int CountTeatcher = int.Parse(Console.ReadLine());
            string[] s = new string[32];
            for (int i = 0; i < s.Count(); i++)
            {
                s[i] = "yes"; 
            }
            for (int i = 0; i < CountTeatcher; i++)
            {
                string[] curents = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(curents[0]); j++)
                {
                    s[j] = "no";
                }
                for (int j = int.Parse(curents[1])+1; j < 32; j++)
                {
                    s[j] = "no";
                }
            }

            string result = "NO";
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i]=="yes")
                {
                    result = "YES";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
