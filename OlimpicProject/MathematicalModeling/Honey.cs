using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Honey
{
    public static void X()
    {
        string[] N_V_K = Console.ReadLine().Replace("  ", " ").Split(' ');
        int DietDay = Convert.ToInt32(N_V_K[0]);
        long HoneyEveryDay = Convert.ToInt64(N_V_K[1]);
        long Appetite = Convert.ToInt64(N_V_K[2]);
        List<long> lint = new List<long>();
        long CurrentAppetite = 0;
        for (int i = 0; i < DietDay; i++)
        {
            //текущий съеденый мед 
            long currrent_honney = HoneyEveryDay - CurrentAppetite;
            //если ест больше чем собирает
            if (currrent_honney < 0)
            {
                currrent_honney = 0;
            }
            //добавляем в колекцию
            lint.Add(currrent_honney);
            //увеличиваем аппетит
            CurrentAppetite += Appetite;
        }
        //если в колекции есть пустая запись значит не дошел
        if (lint.Contains(0))
        {
            Console.Write("NO"); 
        }
        else
        {
            Console.Write("YES");
        }

        Console.Write(" " + lint.Sum());
    }



}