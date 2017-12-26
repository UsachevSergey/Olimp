using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class Wedding
    {
        public static void X()
        {

            double CountMan = double.Parse(Console.ReadLine());
            List<double> SumMoney = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => double.Parse(asertew));
            double Money = double.Parse(Console.ReadLine());
            SumMoney.Sort();
            for (int i = 0; i < CountMan; i++)
            {
                if (SumMoney[i]>Money)
                {
                    Money = (Money + SumMoney[i]) / 2; 
                }
            }
            Money = Math.Round(Money, 6);
            string result = Money.ToString().Replace(",", ".");
            int indexdot = result.IndexOf(".");
            if (indexdot>0)
            {
                int f = result.Split('.')[1].Count();
                for (int i = f; i < 6; i++)
                {
                    result += "0";
                }
            }
            else
            {
                result += ".000000";
            }
            Console.WriteLine(result);

        }
    }
}
