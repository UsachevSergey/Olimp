using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Snake2
    {
        public static void X()
        {
            ulong NumberPosition = ulong.Parse(Console.ReadLine());
            //сумма добавляемая каждый цикл
            ulong Added = 1;
            //последние из результатирующих чисел
            ulong LastNumber = 0;
            ulong CounterStep = 0; //количество добавляемых движений(первое или второе добавление)
            ulong CountZeroBefore = 0;
            ulong CountZeroAfter = 0;
            //заполнять номера
            for (ulong i = 0; i < NumberPosition; i++)
            {
                CounterStep = CounterStep + 1;
                CounterStep = CounterStep % 2;

                //добавляем к результатирующем значению число
                LastNumber = LastNumber + Added;
                //считаем сколько чисел заканчивалось нулем  после добавления 
                CountZeroAfter = LastNumber / 10;
                //добавляяем столько числе сколько было нулей между текущим и предыдущем 
                LastNumber = LastNumber + (CountZeroAfter - CountZeroBefore);

                //промежуточный итог = количество цифр которые делятся на 10  - количество нулей после  начислений
                ulong prom = (LastNumber / 10) - CountZeroAfter;

                while (prom > 0)
                {
                    CountZeroBefore = LastNumber / 10;
                    LastNumber = LastNumber + prom;
                    CountZeroAfter = LastNumber / 10;
                    prom = CountZeroAfter - CountZeroBefore;

                }

                if (CounterStep == 0)
                {
                    Added += 2;
                }
                
                CountZeroBefore = CountZeroAfter; 
            }

            Console.WriteLine(LastNumber);

        }
    }
}
