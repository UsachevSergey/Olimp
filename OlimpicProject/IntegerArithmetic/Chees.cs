using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Chees
    {
        public static void X() {
            try
            {
                string Stroke = Console.ReadLine();
                string pat = "qABCDEFGH";

                int startA = pat.IndexOf(Stroke[0].ToString());
                int startB = int.Parse(Stroke[1].ToString());

                int endA = pat.IndexOf(Stroke[3].ToString());
                int endB = int.Parse(Stroke[4].ToString());

                if (startA > 8 || startA < 1 ||
                    startB > 8 || startB < 1 ||
                    endA > 8 || endA < 1 ||
                    endB > 8 || endB < 1 ||
                    Stroke[2].ToString()!="-"
                    )
                {
                    int a = int.Parse("dsd");
                }

                if ((Math.Abs(startA - endA) == 2 && Math.Abs(startB - endB) == 1)
                    ||
                   (Math.Abs(startA - endA) == 1 && Math.Abs(startB - endB) == 2))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
            



        }
    }
}
