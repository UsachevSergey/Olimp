using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Shop
    {
        public static void X()
        { 
            string[] s = Console.ReadLine().Split(' ');
            int CountStep= Convert.ToInt32(s[1]);//количество шагов
            int StepToShop = Convert.ToInt32(s[0]);//количесвто шагов до магазина
            //результатирующая таблица шагов
            List<Dictionary<int,int>> resultationTable = new List<Dictionary<int,int>>();
            Dictionary<int, int> FirstDictionary = new Dictionary<int, int>();
            for (int i = 1; i < CountStep+1; i++)
            {
                FirstDictionary.Add(i,0);
                FirstDictionary.Add(-i,0);
            }
            FirstDictionary.Add(0, 1); //с первого шага в магазин можно попасть только 1 способом
            //добавляем в Финальную таблицу 
            resultationTable.Add(FirstDictionary);
            //проходим по всем вариантам шагов
            for (int i = 1; i < CountStep+1; i++)
            {
                //В дальнейшем добавляется к результату
                Dictionary<int, int> CurrentDictionary = new Dictionary<int, int>();
                CurrentDictionary.Add(0, 0);
                for (int F = 1; F < CountStep+1; F++)
                {
                    CurrentDictionary.Add(F, 0);
                    CurrentDictionary.Add(-F, 0);
                }
                //проходим по предыдущим результатам
                foreach (var item in resultationTable[i-1])
                {
                    int curentKey = item.Key;
                    int currentValue = item.Value;
                    //если не выходит за рамки 
                    if (curentKey< StepToShop-1 && currentValue > 0)
                    { 
                        CurrentDictionary[curentKey+1] = CurrentDictionary[curentKey+1] + currentValue;
                    }
                    if (currentValue > 0)
                    {
                        CurrentDictionary[curentKey - 1] = CurrentDictionary[curentKey-1] + currentValue;
                    }
                }
                resultationTable.Add(CurrentDictionary);
            }
           
            
            Console.WriteLine(resultationTable[CountStep-1][StepToShop-1]);
        }

    }
}

