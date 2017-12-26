using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Clock
    {
        public static void X()
        {
            List<int> A = Console.ReadLine().Split(':').ToList().ConvertAll(a => int.Parse(a));
            List<int> B = Console.ReadLine().Split(':').ToList().ConvertAll(a => int.Parse(a));
            DateTime StartDT = new DateTime(1, 1, 1, A[0], A[1], A[2]);
            DateTime EndDT   = new DateTime(1, 1, 1, B[0], B[1], B[2]);
            int[] ArrayInt = new int[10];

            bool end = false;
            while (!end)
            {
                string Hours = StartDT.TimeOfDay.Hours.ToString();
                string Minutes = StartDT.TimeOfDay.Minutes.ToString();
                string Second = StartDT.TimeOfDay.Seconds.ToString();
                if (Hours.Count() == 1)
                {
                    ArrayInt[0]++;
                }
                if (Minutes.Count() == 1)
                {
                    ArrayInt[0]++;
                }
                if (Second.Count() == 1)
                {
                    ArrayInt[0]++;
                }
                for (int i = 0; i < Hours.Count(); i++)
                {
                    ArrayInt[int.Parse(Hours[i].ToString())]++;
                }
                for (int i = 0; i < Minutes.Count(); i++)
                {
                    ArrayInt[int.Parse(Minutes[i].ToString())]++;
                }
                for (int i = 0; i < Second.Count(); i++)
                {
                    ArrayInt[int.Parse(Second[i].ToString())]++;
                } 
                if (StartDT.TimeOfDay==EndDT.TimeOfDay)
                {
                    end = true;
                }
                StartDT= StartDT.AddSeconds(1);
            }
            for (int i = 0; i < ArrayInt.Count(); i++)
            {
                Console.WriteLine(ArrayInt[i]);
            }

        }
    }
}
