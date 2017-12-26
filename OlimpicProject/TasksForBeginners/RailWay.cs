using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class RailWay
    {
        public static void X()
        {
            int X = int.Parse(Console.ReadLine());
            string[] S = Console.ReadLine().Split(' ');
            double result = 0;
            for (int i = 1; i < X; i++)
            {
                double curenthei = double.Parse(S[i]);
                double previoushei = double.Parse(S[i - 1]);
                //минимальный объем
                double curentcub = Math.Min(curenthei, previoushei);
                curentcub += Math.Abs(curenthei - previoushei)/2;

                result += curentcub;
            }
           
            Console.WriteLine((result/(X-1)).ToString().Replace(',','.'));

        }
    }
}
