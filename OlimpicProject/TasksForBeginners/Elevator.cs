using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Elevator
    {
        public static void X()
        {
            string s = Console.ReadLine();

            int curentet = 100;
            int maxet = curentet;
            int minelev = curentet;
            for (int i = 0; i < s.Count(); i++)
            {
                if (s[i].ToString()=="1")
                {
                    curentet++;
                }
                else
                {
                    curentet--;
                }
                
                if (minelev>curentet)
                {
                    minelev = curentet;
                }
                if (maxet<curentet)
                {
                    maxet = curentet;
                } 
            }
            Console.WriteLine(maxet-minelev+1);

        }
    }
}
