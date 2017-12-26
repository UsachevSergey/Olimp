using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Cutlets
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            //количество одновременных
            int CountAtOnce = int.Parse(s[0]);
            //количество минут с каждой стороны
            int CountMinutesForEver = int.Parse(s[1]);
            //количество
            int CountCutlets = int.Parse(s[2]);
            int CountCultetsHalf = 0;
            int result = 0;
            //пока есть ещё не тронутые
            while (CountCultetsHalf>0 || CountCutlets>0)
            {
                int currentCutlets = 0;
                //если есть нетронутые с 2 сторон берем их
                if (CountCutlets>0)
                {
                    //добавляем или максимально допустимое или остаток
                    currentCutlets += CountCutlets >= CountAtOnce ? CountAtOnce : CountCutlets;
                    //изымаем остаток
                    CountCutlets -= currentCutlets;
                }
                //если есть одностороних смотрим сколько можно ещё взять
                if (CountCultetsHalf>0)
                {
                    //можно ещё положить
                    int Yet = CountAtOnce - currentCutlets;
                    //берем или все или максимально допустимое количество
                    CountCultetsHalf -= CountCultetsHalf > Yet ? Yet : CountCultetsHalf;
                }
                //добавляем взятые из целых в половину прожарреные
                CountCultetsHalf += currentCutlets;
                //добавляем затраченое время
                result += CountMinutesForEver;
            }
            Console.WriteLine(result);
        }
    }
}
