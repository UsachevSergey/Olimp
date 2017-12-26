using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

class AllRussianOlympiadInInformatics
{
    //НЕ ХВАТАЕТ ВРЕМЕНИ //гдето не верно
    public static void X()
    {
        string[] s = Console.ReadLine().Split();
        //дней в месяце
        int CountDayInMonth = int.Parse(s[0]);
        //продолжительность олимпиады
        int LengthOlymiad = int.Parse(s[1]);
        s = Console.ReadLine().Split();
        int CountDayInWeek = int.Parse(s[0]);
        //количество дней в которое нельзя проводить
        int CountDayDontOlympicInWeek = int.Parse(s[1]);
        //текущий день недели
        int DAYWEEK = int.Parse(s[2])-1;
        s = Console.ReadLine().Split();
        List<int> DayWeekDontOlympic = new List<int>();
        //зполняем дни недели в которые запрешено проводить олимпиады
        for (int i = 0; i < CountDayDontOlympicInWeek; i++)
        {
            DayWeekDontOlympic.Add(int.Parse(s[i]));
        }
        int CountDayDontOlympiInMonth = int.Parse(Console.ReadLine());
        List<int> DayDontOlympiInMonth = new List<int>();
        s = Console.ReadLine().Split();
        for (int i = 0; i < CountDayDontOlympiInMonth; i++)
        {
            DayDontOlympiInMonth.Add(int.Parse(s[i]));
        }
        if (DayWeekDontOlympic.Contains(CountDayInWeek))
        {
            DayWeekDontOlympic.Remove(CountDayInWeek);
            DayWeekDontOlympic.Add(0);
        } 
        //тут только занесены данные теперь нужно проверять  
        bool[] result = new bool[CountDayInMonth+1];
        int resulta = 0;
        //проходим по всем дням месяца начиная с количества дне олимпиады и смотирим можно ли в предыдущих днях провести
        for (int i = LengthOlymiad; i <= CountDayInMonth; i++)
        { 
            bool yes = true;
            //проходим по предыдущим дням входящих в период проведения олимпиады и проверяем можно ли проводить в эти дни
            //начинаем с конца для наиболее быстрого прохода
            for (int j = i ; j > i-LengthOlymiad ; j--)
            {
                int dayw = Math.Abs((j + DAYWEEK) % CountDayInWeek);
                //проверяем можно ли в этот день месяца проводить 
                if (DayDontOlympiInMonth.Contains(j) ||
                    DayWeekDontOlympic.Contains(dayw) 
                    )
                {
                    //если в этот дель нельзя то добавляем к 
                    //i количество дней в котрые нельзя проводить
                    i =j+LengthOlymiad-1;
                    yes = false;
                    break;
                }
                else
                {
                    //если в этот день можно и в предыдущий тоже можно то сразу да
                    if (result[j-1])
                    {
                        break;
                    }
                }
            }
            if (yes)
            {
                result[i] = true;
                resulta++;
                //тут добавили хороший вариант..можно двигатся головой вперед и просчитывать удачные варианты

                for (int lst  = i+1; lst <= CountDayInMonth; lst ++)
                {
                    int dayw = Math.Abs((lst + DAYWEEK) % CountDayInWeek);
                    //проверяем можно ли в этот день месяца проводить 
                    if (!DayDontOlympiInMonth.Contains(lst) &&
                        !DayWeekDontOlympic.Contains(dayw)){
                        result[i] = true;
                        resulta++;
                    }
                    else
                    {
                        i = lst + LengthOlymiad - 1;  
                        break; 
                    }
                }


            } 
        } 
        Console.WriteLine(resulta); 
    }

} 