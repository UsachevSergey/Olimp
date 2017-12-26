using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class HomeWork
    {
        public static void X()
        {
            //количество цифр
            int CountNumber = int.Parse(Console.ReadLine());

            //колекция чисел
            List<int> Numbers = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));

            int CurrentMin = 9999999;
            int MinIndex = 0;
            int CurrentMax =-9999999;
            int MaxIndex = 0;
            int Sum = 0;
            for (int i = 0; i < CountNumber; i++)
            {
                if (Numbers[i] < CurrentMin)
                {
                    CurrentMin = Numbers[i];
                    MinIndex = i;
                }
                if (Numbers[i] >CurrentMax)
                {
                    CurrentMax = Numbers[i];
                    MaxIndex = i;
                }
                if (Numbers[i]>0)
                {
                    Sum += Numbers[i];
                }
            }

            if (MinIndex>MaxIndex)
            {
                int D = MinIndex;
                MinIndex = MaxIndex;
                MaxIndex = D;
            }

            int Mult = 1;
            bool T = true;
            for (int i = MinIndex+1; i < MaxIndex; i++)
            {
                T = false;
                Mult *= Numbers[i];
            } 
            if (T)
            {
                Mult = 0;
            }
            Console.WriteLine(Sum+" "+Mult);



        }
    }
}
