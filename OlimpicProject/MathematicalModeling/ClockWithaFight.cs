using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class ClockWithaFight
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');

            string[] s2 = Console.ReadLine().Split(' ');
            int StartTimeHours = int.Parse(s[0]);
            int StartTimeMinutes = int.Parse(s[1]);
            int EndTimeHours = int.Parse(s2[0]);
            int EndTimeMinutes = int.Parse(s2[1]);

            DateTime CurentDate = new DateTime(1, 1, 1, StartTimeHours, StartTimeMinutes, 0);
            DateTime DateEnd = new DateTime(1, 1, 1, EndTimeHours, EndTimeMinutes, 0);
            int BOOM = 0;
            //пока время не совподает такать по минуте и если время ровно то добавлять удары
            while (CurentDate.TimeOfDay!=DateEnd.TimeOfDay)
            {
                CurentDate= CurentDate.AddMinutes(1);
                if (CurentDate.TimeOfDay.Minutes == 0)
                {
                    BOOM += (CurentDate.Hour)%12;
                    
                    if (CurentDate.Hour==0 ||CurentDate.Hour==12)
                    {
                        BOOM += 12;
                    }
                }
                else if (CurentDate.TimeOfDay.Minutes == 30)
                {
                    BOOM += 1;
                }
            }
            Console.WriteLine(BOOM);

        }
    }
}
