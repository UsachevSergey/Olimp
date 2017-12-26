using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GreedyAlgorithm
{
    class PlayTheFool
    {
        public static void X()
        {
            string[] S = Console.ReadLine().Split(' ');
            int CountCard = int.Parse(S[0]);
            int CountCardBeatOff = int.Parse(S[1]);
            string Trump = S[2];
            List<string> ArrayCard = Console.ReadLine().
                Replace("  "," ").Trim().
                Replace("T", "10").Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14").
                Split(' ').ToList();
            List<string> ArrayCardBeatOff = Console.ReadLine().
                Replace("  ", " ").Trim().
                Replace("T", "10").Replace("J", "11").Replace("Q", "12").Replace("K", "13").Replace("A", "14")
              .Split(' ').ToList();
            //делаем колекции из карт
            Dictionary<string, List<int>> CARD = new Dictionary<string, List<int>>();
            //добавляем все масти
            CARD.Add("S", new List<int>());
            CARD.Add("C", new List<int>());
            CARD.Add("D", new List<int>());
            CARD.Add("H", new List<int>()); 
            //переводим все карты в масивы
            for (int i = 0; i < ArrayCard.Count; i++)
            {
                //текущая масть 
                string CurrentTrump = ArrayCard[i].Length > 2 ?
                    ArrayCard[i][2].ToString() 
                    :
                    ArrayCard[i][1].ToString();
                //текущее значение
                int CurrentNumber = ArrayCard[i].Length > 2 ?
                 int.Parse(ArrayCard[i].Substring(0, 2)) 
                    : 
                  int.Parse(ArrayCard[i].Substring(0, 1));


                CARD[CurrentTrump].Add(CurrentNumber);
            }
            bool yes = true;

            for (int i = 0; i < ArrayCardBeatOff.Count; i++)
            {
                //текущая масть 
                string CurrentTrump = ArrayCardBeatOff[i].Length > 2 ?
                    ArrayCardBeatOff[i][2].ToString()
                    :
                    ArrayCardBeatOff[i][1].ToString();
                //текущее значение
                int CurrentNumber = ArrayCardBeatOff[i].Length > 2 ?
                 int.Parse(ArrayCardBeatOff[i].Substring(0, 2))
                    :
                  int.Parse(ArrayCardBeatOff[i].Substring(0, 1));





                int currentmin = 9999;
                //идем по масиву масти и смотрим есть ли чем можно побить
                for (int tr = 0; tr < CARD[CurrentTrump].Count; tr++)
                {
                    if (CARD[CurrentTrump][tr]>CurrentNumber)
                    {
                        currentmin = Math.Min(currentmin, CARD[CurrentTrump][tr]);
                    }
                }
                if (currentmin!=9999)
                {//если нашлось хоть 1 то удаляем это минимальное из масива

                    CARD[CurrentTrump].Remove(currentmin);
                }
                else
                {//иначе смотим в козырях
                    for (int tr = 0; tr < CARD[Trump].Count; tr++)
                    {
                        //если оба козыри то проверяем на минимальное 
                        if (Trump == CurrentTrump)
                        {
                            if (CARD[Trump][tr] > CurrentNumber)
                            {
                                currentmin = Math.Min(currentmin, CARD[Trump][tr]);
                            }
                        }
                        else
                        {//если побить надо не козырь то просто выбираем минимальные
                            currentmin = Math.Min(currentmin, CARD[Trump][tr]);
                        }
                    }

                    if (currentmin != 9999)
                    {//если нашлось хоть 1 то удаляем это минимальное из масива
                        CARD[Trump].Remove(currentmin);
                    }
                    else
                    {
                        //невозможно побить
                        yes = false;
                        break;
                    } 
                } 
            } 
            if (yes)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
