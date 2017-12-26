using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Taxes
    {
        public static void X()
        {
            int countfactory = int.Parse(Console.ReadLine());
            int maxpr = 0;
            int favorites = 1;
            string[] income = Console.ReadLine().Split(' ');
            string[] percent = Console.ReadLine().Split(' ');

            for (int i = 0; i < countfactory; i++)
            {
                int curentincome = int.Parse(income[i]);
                int curentpercent = int.Parse(percent[i]);
                int curenttaxes = curentincome * curentpercent;
                if (curenttaxes>maxpr)
                {
                    maxpr = curenttaxes;
                    favorites = i+1;
                } 
            }
            Console.WriteLine(favorites);

        }
		 
    }
}
