using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class GameBashe
    {
        public static void X()
        {

            string[] currentstr = Console.ReadLine().Split(' ');
            int countBase = int.Parse(currentstr[0]);
            int maxstep = int.Parse(currentstr[1]);
            int countStep = int.Parse(currentstr[2]);

            for (int i = 0; i < countStep; i++)
            {
                int CurrentP = int.Parse(Console.ReadLine());
                int currentTrue = 0;
                if (countBase <= maxstep)
                {
                    currentTrue = countBase;
                }
                else
                {
                    currentTrue = countBase - ((countBase / (maxstep + 1)) * (maxstep + 1));
                }

                if (currentTrue == 0)
                {
                    Console.WriteLine("T");
                }
                else
                {
                    if (CurrentP == currentTrue)
                    {
                        Console.WriteLine("T");
                    }
                    else
                    {
                        Console.WriteLine("F");
                    }


                }
                countBase -= CurrentP;
            }
        }
    }
}
